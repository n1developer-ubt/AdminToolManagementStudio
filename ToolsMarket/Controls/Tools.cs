using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.DataGrid.Interactivity;
using ToolsMarket.DbContext;
using ToolsMarket.Models;

namespace ToolsMarket.Controls
{
    public partial class Tools : UserControl
    {
        public UserDbContext DbContext { get; set; }

        public Tools()
        {
            InitializeComponent();
        }

        public void LoadAll()
        {
            if (DbContext == null)
                return;

            DbContext.Tools.Load();

            var tools = DbContext.Tools.ToList();

            tools.ForEach(t =>
            {
                var result = DbContext.Orders.Include(x=>x.Customer).Include(x=>x.Tool).FirstOrDefault(o =>
                    o.Customer.Id == Customer.CurrentCustomer.Id && o.Tool.Id == t.Id);

                if(result != null)
                    t.Buy = "Purchased";

                t.Password = "********************";
                t.Username= "********************";
            });


            try
            {
                //sdgTools.DataSource = null;
                sdgTools.DataSource = tools;
            }
            catch (Exception e)
            {
                // ignored
            }
        }

        private async void txtReload_Click(object sender, EventArgs e)
        {
            if (!(sender is Control c))
                return;
            c.Enabled = false;
            LoadAll();
            //await Task.Run();
            c.Enabled = true;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (!(sender is TextBoxExt x)) return;

            if (x.Text.Trim().Equals(""))
            {
                sdgTools.SearchController.ClearSearch();
                return;
            }

            sdgTools.SearchController.Search(x.Text);

        }

        private void sdgTools_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (DesignMode)
                return;
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            var d = (Tool) sdgTools.GetRecordAtRowIndex(e.RowIndex);

            if (d == null)
                return;

            if (d.Status.Equals(ToolStatus.Unknown.ToString()))
            {
                e.Style.TextColor = Color.Black;
                e.Style.BackColor = Color.White;
            }
            else if (d.Status.Equals(ToolStatus.Working.ToString()))
            {
                e.Style.TextColor = Color.White;
                e.Style.BackColor = Color.Green;
            }
            else if (d.Status.Equals(ToolStatus.NotWorking.ToString()))
            {
                e.Style.TextColor = Color.White;
                e.Style.BackColor = Color.Red;
            }
            else if (d.Status.Equals(ToolStatus.Checking.ToString()))
            {
                e.Style.TextColor = Color.White;
                e.Style.BackColor = Color.DodgerBlue;
            }
        }

        private async void sdgTools_CellButtonClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellButtonClickEventArgs e)
        {
            var r = (Tool) sdgTools.GetRecordAtRowIndex(e.RowIndex);

            if (r == null)
                return;

            if (r.Buy.Equals("Purchased"))
            {
                MessageBox.Show("Already Purchased!");
                return;
            }

            Models.Order o = new Models.Order()
            {
                Tool = DbContext.Tools.SingleOrDefault(t=>t.Id == r.Id),
                Customer = DbContext.Customers.SingleOrDefault(c=>c.Id== Customer.CurrentCustomer.Id)
            };

            r.Buy = "Purchased";

            DbContext.Orders.Add(o);
            await DbContext.SaveChangesAsync();
        }
    }

    public enum ToolStatus
    {
        Unknown,
        Working,
        NotWorking,
        Checking
    }
}
