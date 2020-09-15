using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminToolManagementStudio.Models;
using Microsoft.EntityFrameworkCore;
using Syncfusion.WinForms.Controls;
using ToolsMarket.DbContext;
using ToolsMarket.Models;

namespace ToolsMarket.Forms
{
    public partial class MainWindow : SfForm
    {
        private LoadableControlType[] LoadableControls;
        public MainWindow()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Closing+=OnClosing;
        }

        private void OnClosing(object sender, CancelEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private async void TabControlAdv1OnSelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var x = LoadableControls[tabControlAdv1.SelectedIndex];

                if(x.Loaded) return;
                (x.Control as Control).Enabled = false;
                await Task.Run(()=> x.Control.LoadAll());
                x.Loaded = true;
                (x.Control as Control).Enabled = true;
                //MessageBox.Show("");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void LoadAll()
        {
            Task.Run(() =>
            {
                EnableAll(false);
                order1.DbContext = new UserDbContext();
                tools1.DbContext = new UserDbContext();
                tools1.LoadAll();
                //this.Invoke(new Action(() => tools1.LoadAll()));
                otherOrders1.DbContext = new UserDbContext();
                otherTools1.DbContext = new UserDbContext();
                customerTicketControl1.DbContext = new UserDbContext();
                EnableAll(true);
                Text = "Tool Market - Welcome, " + Customer.CurrentCustomer.Name;
            });
        }

        private void EnableAll(bool enable)
        {
            tabControlAdv1.Enabled = enable;
            return;
            tools1.Enabled = enable;
            order1.Enabled = enable;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            LoadableControls = new[] { new LoadableControlType() { Control = tools1, Loaded = true }, new LoadableControlType() { Loaded = false, Control = otherTools1 }, new LoadableControlType() { Control = order1, Loaded = false }, new LoadableControlType() { Loaded = false, Control = otherOrders1 }, new LoadableControlType() { Loaded = false, Control = customerTicketControl1 } };
            CheckForIllegalCrossThreadCalls = false;
            tabControlAdv1.SelectedIndexChanged += TabControlAdv1OnSelectedIndexChanged;
            //dbContext.Database.EnsureDeleted();
            //dbContext.Database.EnsureCreated();
            try
            {
                Text = "Tool Market - Loading";
                LoadAll();
            }
            catch (Exception ex)
            {
                Invoke(new Action(() => MessageBox.Show("Database Error Occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)));
            }
        }
    }
}
