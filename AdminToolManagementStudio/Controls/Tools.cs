using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminToolManagementStudio.DatabaseContext;
using AdminToolManagementStudio.Forms;
using Microsoft.EntityFrameworkCore;
using Syncfusion.Data.Extensions;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.DataGrid;
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

            try
            {
                
            }
            catch (Exception e)
            {
                
            }

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

                    tool.Status = ToolStatus.Checking.ToString();
                    sdgTools.Refresh();
                    var result = await GetUpdatedStatus(tool);

                    if (result == ToolStatus.Error)
                        break;

                    tool.Status = result.ToString();
                    sdgTools.Refresh();
                }

                await DbContext.SaveChangesAsync();
                
                c.Text = "Update All";
                EnableAllOnUpdate(true);
                c.Enabled = true;
            }
            else
            {
                c.Enabled = false;
                Pause = true;
            }
        }

        public string TempMail { get; set; }

        private bool IsEmail(string emailAddress)
        {
            try
            {
                new MailAddress(emailAddress);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private async Task<ToolStatus> GetUpdatedStatus(Models.Tool t)
        {
            if (!IsEmail(TempMail))
            {
                MessageBox.Show("Temp Email Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return ToolStatus.Error;
            }

            if (!IsEmail(t.Username))
                return ToolStatus.NotWorking;

            var result = ToolStatus.Working;

            await Task.Run(() =>
            {
                using (SmtpClient c = new SmtpClient(t.Smtp, t.Port))
                {
                    try
                    {
                        c.Credentials = new NetworkCredential(t.Username, t.Password);
                        c.EnableSsl = t.Ssl;
                        c.DeliveryMethod = SmtpDeliveryMethod.Network;
                        var m = new MailMessage();
                        m.From = new MailAddress(t.Username, t.Username.Split('@')[0]);
                        m.To.Add(TempMail);
                        m.Subject = "Test";
                        m.Body = "test";
                        c.Send(m);
                    }
                    catch (SmtpException e)
                    {
                        result = ToolStatus.NotWorking;
                    }
                    catch (Exception e)
                    {
                        result = ToolStatus.Unknown;
                    }
                }
            });
            return result;
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
            else if (d.Status.Equals(ToolStatus.Checking.ToString()))
            {
                e.Style.TextColor = Color.White;
                e.Style.BackColor = Color.DodgerBlue;
            }
        }

        private async void btnImportFile_Click(object sender, EventArgs e)
        {
            using (var f = new OpenFileDialog())
            {
                f.Filter = "Text File(*.txt)|*.txt";
                f.Multiselect = false;

                if (f.ShowDialog() == DialogResult.OK)
                {
                    var lines = File.ReadAllLines(f.FileName);

                    if (lines.Length > 0)
                    {
                        foreach (var line in lines)
                        {
                            var t = ParseTool(line);

                            if (t == null) continue;

                            DbContext.Tools.Add(t);
                        }

                        await DbContext.SaveChangesAsync();
                    }
                }
            }
        }

        private Models.Tool ParseTool(string str)
        { 
            var s = str.Split('|');
            s = s.Select(x => x.Trim()).ToArray();
            try
            {
                return new Models.Tool(){
                    Smtp = s[0],
                    Port = Convert.ToInt16(s[1]),
                    Username = s[2],
                    Password = s[3],
                    Status = ToolStatus.Unknown.ToString(),
                    Ssl = s[4].ToLower().Equals("ssl"),
                    Price = Convert.ToInt32(s[5])
                };
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private bool UpdatingStatus = false;

        private bool IsWorking = false;

        private async void sdgTools_CellButtonClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellButtonClickEventArgs e)
        {
            if (IsWorking)
                return;

            IsWorking = true;

            if (e.Column.HeaderText.ToLower().Equals("check status"))
            {
                if (UpdatingStatus)
                {
                    IsWorking = false;
                    return;
                }

                UpdatingStatus = true;

                var rr = (Models.Tool)sdgTools.GetRecordAtRowIndex(e.RowIndex);

                rr.Status = ToolStatus.Checking.ToString();

                sdgTools.Refresh();
                var result = await GetUpdatedStatus(rr);

                if (result == ToolStatus.Error)
                {
                    IsWorking = false;
                    return;
                }

                rr.Status = (result).ToString();

                UpdatingStatus = false;

                sdgTools.Refresh();

                IsWorking = false;

                return;
            }

            var r = (Models.Tool) sdgTools.GetRecordAtRowIndex(e.RowIndex);

            if (r == null)
            {
                IsWorking = false;
                return;
            }

            DbContext.Tools.Remove(r);

            await DbContext.SaveChangesAsync();
            IsWorking = false;
        }
    }

}
