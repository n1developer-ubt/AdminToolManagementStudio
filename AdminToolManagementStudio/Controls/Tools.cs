using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminToolManagementStudio.DatabaseContext;
using AdminToolManagementStudio.Forms;
using Microsoft.EntityFrameworkCore;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid.Interactivity;

namespace AdminToolManagementStudio.Controls
{
    public partial class Tools : UserControl
    {

        public CustomerDbContext DbContext { get; set; }

        public Tools()
        {
            InitializeComponent();
        }

        public void LoadAll()
        {
            if (DbContext == null)
                return;

            DbContext.Tools.Load();

            sdgTools.DataSource = DbContext.Tools.Local.ToBindingList();
        }

        private async void btnAddNewTool_Click(object sender, EventArgs e)
        {
            using (var t = new Tool())
            {
                t.ShowDialog();

                if (t.Value == null)
                    return;

                DbContext.Tools.Add(t.Value);
                await DbContext.SaveChangesAsync();
            }
        }

        private async void txtReload_Click(object sender, EventArgs e)
        {
            if (!(sender is Control c))
                return;
            c.Enabled = false;
            await Task.Run(LoadAll);
            c.Enabled = true;
        }

        private async void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (!(sender is SfButton b)) return;

            b.Enabled = false;

            await DbContext.SaveChangesAsync();

            b.Enabled = true;
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

        private bool Pause = false;
        

        private async void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            if (!(sender is Control c))
                return;

            if (c.Text.Equals("Update All"))
            {
                c.Text = "Pause";

                foreach (var tool in DbContext.Tools)
                {
                    if (Pause)
                    {
                        Pause = false;
                        break;
                    }
                    var result = await GetUpdatedStatus(tool);
                    tool.Status = result.ToString();
                    MessageBox.Show(result.ToString());
                }

                c.Text = "Update All";
            }
            else
            {
                c.Enabled = false;
                Pause = true;
                while (Pause) ;
                c.Text = "Update All";
                c.Enabled = true;
            }
        }

        public string TempMail { get; set; }

        private async Task<ToolStatus> GetUpdatedStatus(Models.Tool t)
        {
            ToolStatus Result = ToolStatus.Working;
            await Task.Run(() =>
            {
                using (SmtpClient c = new SmtpClient(t.Smtp, t.Port))
                {
                    try
                    {
                        c.Credentials = new NetworkCredential(t.Username, t.Password);

                        c.Send(t.Username, TempMail, "Test", "Testing");
                    }
                    catch (SmtpException e)
                    {
                        Result = ToolStatus.NotWorking;
                    }
                    catch (Exception e)
                    {
                        Result = ToolStatus.Unknown;
                    }
                }
            });
            return Result;
        }

        private void EnableAllOnUpdate(bool enable)
        {
            btnReload.Enabled = enable;
            txtSearch.Enabled = enable;
            pnlControls1.Enabled = enable;
        }

        private void sdgTools_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (DesignMode)
                return;
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            var d = (Models.Tool) sdgTools.GetRecordAtRowIndex(e.RowIndex);

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
        }
    }

    public enum ToolStatus
    {
        Unknown,
        Working,
        NotWorking
    }
}
