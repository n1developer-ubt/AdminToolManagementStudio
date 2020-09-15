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
using Syncfusion.WinForms.DataGrid.Events;
using Syncfusion.WinForms.DataGrid.Interactivity;
using ToolsMarket.DbContext;
using ToolsMarket.Models;

namespace ToolsMarket.Controls
{
    public partial class OtherTools : UserControl, LoadableControl
    {
        public UserDbContext DbContext { get; set; }

        public OtherTools()
        {
            InitializeComponent();
            sdgTools.QueryRowHeight+=SdgToolsOnQueryRowHeight;
        }

        private void SdgToolsOnQueryRowHeight(object sender, QueryRowHeightEventArgs e)
        {
            var r = (OtherTool) sdgTools.GetRecordAtRowIndex(e.RowIndex);

            if (r != null)
            {
                if (r.Buy == null) return;

                if (r.Buy.Equals("purchased", StringComparison.CurrentCultureIgnoreCase))
                {
                    e.Height = 0;
                    e.Handled = true;
                }
            }
        }

        public void LoadAll()
        {
            if (DbContext == null)
                return;

            DbContext.OtherTools.Load();
            DbContext.OtherOrders.Include(x=>x.Tool).Load();
            
            //var otherOrder = DbContext.OtherOrders.AsNoTracking().ToList();

            var tools = DbContext.OtherTools.AsNoTracking().Where(x => DbContext.OtherOrders.FirstOrDefault(y=>y.Tool.Id == x.Id) == null).ToList();

            tools.ForEach(t =>
            {
                t.Password = "********************";
                t.Username= "********************";
            });


            if (sdgTools.InvokeRequired)
                sdgTools.Invoke(new System.Action(() =>
                    sdgTools.DataSource = tools));
            else
                sdgTools.DataSource = tools;
        }

        private async void txtReload_Click(object sender, EventArgs e)
        {
            if (!(sender is Control c))
                return;
            c.Enabled = false;
            LoadAll();
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

            var d = (OtherTool) sdgTools.GetRecordAtRowIndex(e.RowIndex);

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
            var r = (OtherTool) sdgTools.GetRecordAtRowIndex(e.RowIndex);

            if (r == null)
                return;

            Models.OtherOrder o = new Models.OtherOrder()
            {
                Tool = DbContext.OtherTools.SingleOrDefault(t=>t.Id == r.Id),
                Customer = DbContext.Customers.SingleOrDefault(c=>c.Id== Customer.CurrentCustomer.Id)
            };

            r.Buy = "Purchased";
            sdgTools.InvalidateRowHeight(e.RowIndex);
            sdgTools.TableControl.Invalidate();
            DbContext.OtherOrders.Add(o);
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
