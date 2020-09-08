using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Syncfusion.WinForms.Controls;
using ToolsMarket.DbContext;
using ToolsMarket.Models;

namespace ToolsMarket.Forms
{
    public partial class MainWindow : SfForm
    {
        public MainWindow()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            //dbContext.Database.EnsureDeleted();
            //dbContext.Database.EnsureCreated();
            try
            {
                Text = "Tool Market - Loading";
                LoadAll(new UserDbContext());
                Text = "Tool Market - Welcome, " + Customer.CurrentCustomer.Name;
            }
            catch (Exception e)
            {
                Invoke(new Action(() => MessageBox.Show("Database Error Occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)));
            }
        }

        private void LoadAll(UserDbContext dbContext)
        {
            EnableAll(false);
            order1.DbContext = dbContext;
            order1.LoadAll();
            tools1.DbContext = dbContext;
            tools1.LoadAll();
            EnableAll(true);
        }

        private void EnableAll(bool enable)
        {
            tools1.Enabled = enable;
            order1.Enabled = enable;
        }
    }
}
