using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Syncfusion.Data;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGrid.Interactivity;
using ToolsMarket.DbContext;
using ToolsMarket.Models;

namespace ToolsMarket.Controls
{
    public partial class OtherOrders : UserControl,LoadableControl
    {
        public UserDbContext DbContext;

        public OtherOrders()
        {
            InitializeComponent();
            SetupSummary();
            //sfDataGrid1.QueryRowStyle+=SfDataGrid1OnQueryRowStyle;
        }

        public void SetupSummary()
        {
            GridTableSummaryRow tableSummaryRow1 = new GridTableSummaryRow();
            tableSummaryRow1.Name = "TableSummary";
            tableSummaryRow1.ShowSummaryInRow = false;
            tableSummaryRow1.Position = VerticalPosition.Bottom;

            GridSummaryColumn summaryColumn1 = new GridSummaryColumn();
            summaryColumn1.Name = "Tool.Price";
            summaryColumn1.SummaryType = SummaryType.DoubleAggregate;
            summaryColumn1.Format = "Total Cost: {Sum:c}";
            summaryColumn1.MappingName = "Tool.Price";

            tableSummaryRow1.SummaryColumns.Add(summaryColumn1);

            this.sfDataGrid1.TableSummaryRows.Add(tableSummaryRow1);
        }

        private void SfDataGrid1OnQueryRowStyle(object sender, QueryRowStyleEventArgs e)
        {
            var o = (Models.OtherOrder) sfDataGrid1.GetRecordAtRowIndex(e.RowIndex);

            if (o == null) return;

            switch (o.OrderStatus)
            {
                case OrderStatus.Accepted:
                    e.Style.BackColor = Color.Green;
                    e.Style.TextColor = Color.White;
                    break;
                
                case OrderStatus.Rejected:
                    e.Style.BackColor = Color.Firebrick;
                    e.Style.TextColor = Color.White;
                    break;
                
                case OrderStatus.Pending:
                    e.Style.BackColor= Color.Orange;
                    e.Style.TextColor = Color.White;
                    break;
            }
        }

        public void LoadAll()
        {
            if(DbContext == null) return;

            try
            {
                DbContext.OtherOrders.Load();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                //DbContext = new UserDbContext();
                //DbContext.Orders.Load();
            }

            var orders = DbContext.OtherOrders.AsNoTracking().Include(x=>x.Customer).Include(x=>x.Tool).Where(o=>o.Customer.Id == Customer.CurrentCustomer.Id).ToList();
            AllOrders = orders;
            //MessageBox.Show(orders.Count + "");

            //orders.ForEach(order =>
            //{
            //    try
            //    {
            //        if (order.OrderStatus != OrderStatus.Accepted)
            //        {
            //            order.Tool.Password = "******************";
            //            order.Tool.Username = "******************";
            //        }
            //    }
            //    catch (Exception e)
            //    {

            //    }
            //});

            if (sfDataGrid1.InvokeRequired)
                sfDataGrid1.Invoke(new System.Action(() => sfDataGrid1.DataSource = orders));
            else
                sfDataGrid1.DataSource = orders;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            if(!(sender is Control c)) return;

            c.Enabled = false;

            LoadAll();

            c.Enabled = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            sfDataGrid1.SearchController.Search((sender as TextBoxExt).Text);
        }

        private void sfDataGrid1_CellButtonClick(object sender, CellButtonClickEventArgs e)
        {
            if(e.Column.HeaderText.Equals("Action", StringComparison.CurrentCultureIgnoreCase))
            {
                var r = (OtherOrder)sfDataGrid1.GetRecordAtRowIndex(e.RowIndex);

                Clipboard.SetText(r.Tool.ToString());
            }
        }
        private List<Models.OtherOrder> AllOrders;
        private void sfButton1_Click(object sender, EventArgs e)
        {
            var content = "";

            AllOrders.ForEach(o => content += o.Tool.ToString() + "\n");

            Clipboard.SetText(content.Trim());
        }
    }
}
