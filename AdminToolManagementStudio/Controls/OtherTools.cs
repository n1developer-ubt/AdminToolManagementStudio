﻿using System;
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
    public partial class OtherTools : UserControl, LoadableControl
    {

        public CustomerDbContext DbContext { get; set; }

        public OtherTools()
        {
            InitializeComponent();
        }

        public async Task LoadAll()
        {
            if (DbContext == null)
                return;

            await DbContext.OtherTools.LoadAsync();

            try
            {
                
            }
            catch (Exception e)
            {
                
            }

            sdgTools.DataSource = DbContext.OtherTools.Local.ToBindingList();
        }

        private async void btnAddNewTool_Click(object sender, EventArgs e)
        {
            using (var t = new OtherTool())
            {
                t.ShowDialog();

                if (t.Value == null)
                    return;

                DbContext.OtherTools.Add(t.Value);
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

            var d = (Models.OtherTool) sdgTools.GetRecordAtRowIndex(e.RowIndex);

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

                            DbContext.OtherTools.Add(t);
                        }

                        await DbContext.SaveChangesAsync();
                    }
                }
            }
        }

        private Models.OtherTool ParseTool(string str)
        { 
            var s = str.Split('|');
            s = s.Select(x => x.Trim()).ToArray();
            try
            {
                return new Models.OtherTool(){
                    Smtp = s[0],
                    Description = s[1],
                    Username = s[2],
                    Password = s[3],
                    Status = ToolStatus.Unknown.ToString(),
                    Price = Convert.ToInt32(s[4])
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

            var r = (Models.OtherTool) sdgTools.GetRecordAtRowIndex(e.RowIndex);

            if (r == null)
            {
                IsWorking = false;
                return;
            }

            DbContext.OtherTools.Remove(r);

            await DbContext.SaveChangesAsync();
            IsWorking = false;
        }
    }

    public enum ToolStatus
    {
        Unknown,
        Working,
        NotWorking,
        Checking,
        Error
    }
}
