using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminToolManagementStudio.DatabaseContext;
using AdminToolManagementStudio.Models;
using Microsoft.EntityFrameworkCore;
using Syncfusion.Data;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGrid.Interactivity;

namespace AdminToolManagementStudio.Controls
{
    public partial class OtherOrder : UserControl, LoadableControl
    {
        public CustomerDbContext DbContext;

        public OtherOrder()
        {
            InitializeComponent();
            sdgOrders.QueryRowStyle += SfDataGrid1OnQueryRowStyle;
        }

        public void SetupSummary()
        {
            GridTableSummaryRow tableSummaryRow1 = new GridTableSummaryRow();
            tableSummaryRow1.Name = "TableSummary";
            tableSummaryRow1.ShowSummaryInRow = false;
            tableSummaryRow1.Position = VerticalPosition.Bottom;

            GridSummaryColumn summaryColumn1 = new GridSummaryColumn();
            summaryColumn1.Name = "Tool.Price";
            summaryColumn1.Format = "{0}";
            summaryColumn1.SummaryType = SummaryType.DoubleAggregate;
            summaryColumn1.Format = "Total :{Sum:c}";
            summaryColumn1.MappingName = "Tool.Price";

            tableSummaryRow1.SummaryColumns.Add(summaryColumn1);

            sdgOrders.TableSummaryRows.Clear();
            sdgOrders.TableSummaryRows.Add(tableSummaryRow1);
        }

        private void SetupGroupSummary()
        {
            var groupSummaryRow1 = new GridSummaryRow { Name = "GroupSummary", ShowSummaryInRow = false };

            // Creates the GridSummaryColumn.
            var summaryColumn1 = new GridSummaryColumn
            {
                Name = "UnitPrice",
                SummaryType = SummaryType.DoubleAggregate,
                Format = "{Sum:c}",
                MappingName = "Tool.Price"
            };

            // Adds the GridSummaryColumn in SummaryColumns collection.
            groupSummaryRow1.SummaryColumns.Add(summaryColumn1);

            // Adds the summary row in the GroupSummaryRows collection.
            sdgOrders.GroupSummaryRows.Clear();
            sdgOrders.GroupSummaryRows.Add(groupSummaryRow1);
        }

        private void SetupGrouping()
        {
            sdgOrders.GroupColumnDescriptions.Clear();
            sdgOrders.GroupColumnDescriptions.Add(new GroupColumnDescription()
            {
                ColumnName = "Customer.Id"
            });
        }
        private void SfDataGrid1OnQueryRowStyle(object sender, QueryRowStyleEventArgs e)
        {
            var o = (Models.OtherOrder)sdgOrders.GetRecordAtRowIndex(e.RowIndex);

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
                    e.Style.BackColor = Color.Orange;
                    e.Style.TextColor = Color.White;
                    break;
            }
        }

        private ObservableCollection<Models.OtherOrder> Orders;

        public async Task LoadAll()
        {
            if (DbContext == null) return;

            //Orders = DbContext.Orders.Include(x => x.Customer).Include(x => x.Tool).ToObservableCollection();

            await DbContext.OtherOrders.LoadAsync();


            SetupGrouping();
            SetupGroupSummary();
            SetupSummary();

            DbContext.OtherOrders.Include(x=>x.Customer).Include(x=>x.Tool).Load();

            sdgOrders.DataSource = DbContext.OtherOrders.Local.ToBindingList();

            //var o = new Models.Order()
            //{
            //    Customer = new Models.Customer(){Id = 1},
            //    OrderStatus =  OrderStatus.Pending,
            //    Tool = new Tool() { Id = 1}
            //};

            //DbContext.Orders.Add(o);
            //sdgOrders.SortColumnDescriptions.Add(new SortColumnDescription(){ColumnName = "Customer Id",SortDirection = ListSortDirection.Descending});


            sdgOrders.Refresh();
        }

        private async void btnReload_Click(object sender, EventArgs e)
        {
            if (!(sender is Control c)) return;

            c.Enabled = false;

            await LoadAll();

            c.Enabled = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            sdgOrders.SearchController.Search((sender as TextBoxExt).Text);
        }

        private async void sfDataGrid1_CellButtonClick(object sender, CellButtonClickEventArgs e)
        {
            try
            {
                await Check(sender, e);
            }
            catch (Exception exception)
            {

            }
        }

        private async Task Check(object sender, CellButtonClickEventArgs e)
        {
            var r = (Models.OtherOrder)sdgOrders.GetRecordAtRowIndex(e.RowIndex);

            if (r == null)
                return;

            var order = await DbContext.OtherOrders.SingleOrDefaultAsync(o => o.Id == r.Id);

            switch (e.Column.HeaderText)
            {
                case "Reject":
                    r.OrderStatus = OrderStatus.Rejected;
                    break;
                case "Accept":
                    r.OrderStatus = OrderStatus.Accepted;
                    break;
                case "Delete":
                    DbContext.OtherOrders.Remove(r);
                    break;
            }

            await DbContext.SaveChangesAsync();

            sdgOrders.Refresh();
        }
    }
}
