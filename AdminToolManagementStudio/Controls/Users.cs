using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminToolManagementStudio.DatabaseContext;
using AdminToolManagementStudio.Forms;
using Microsoft.EntityFrameworkCore;
using Syncfusion.Data.Extensions;
using Syncfusion.WinForms.DataGrid.Interactivity;

namespace AdminToolManagementStudio.Controls
{
    public partial class Users : UserControl
    {
        public CustomerDbContext DbContext { get; set; }
        public Users()
        {
            InitializeComponent();
            sgvCustomers.SearchController.SearchColumns.Add("Name");
            sgvCustomers.SearchController.SearchColor = Color.GreenYellow;
            CheckForIllegalCrossThreadCalls = false;
            //sgvCustomers.changed
        }

        public void LoadAll()
        {
            if (DbContext == null)
                return;

            DbContext.Customers.Load();
            sgvCustomers.DataSource = DbContext.Customers.Local.ToBindingList();
        }

        private async void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            await DbContext.SaveChangesAsync();
            using (Customer c = new Customer())
            {
                c.ShowDialog();

                if (c.Value == null) return;

                if (c.Value.Email.Trim().Equals("") || c.Value.Password.Trim().Equals(""))
                    return;

                var result = DbContext.Customers.Count(x => x.Email.Equals(c.Value.Email.Trim()));

                if (result > 0)
                {
                    MessageBox.Show("Email Already Exist!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }

                DbContext.Customers.Add(c.Value);
                await DbContext.SaveChangesAsync();
            }
        }

        private async void sgvCustomers_DataSourceChanged(object sender, Syncfusion.WinForms.DataGrid.Events.DataSourceChangedEventArgs e)
        {
            if (DbContext == null)
                return;
            try
            {
                await DbContext?.SaveChangesAsync();
            }
            catch (Exception exception)
            {
                
            }
        }

        private async void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (!(sender is Control c))
                return;
            c.Enabled = false;
            await DbContext.SaveChangesAsync();
            c.Enabled = true;
        }

        private async void sgvCustomers_CellButtonClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellButtonClickEventArgs e)
        {
            if (e.Column.HeaderText.ToLower().Equals("action"))
            {
                var r = (Models.Customer) sgvCustomers.GetRecordAtRowIndex(e.RowIndex);
                DbContext.Customers.Remove(r);
                await DbContext.SaveChangesAsync();
                
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text .Equals(""))
            {
                sgvCustomers.SearchController.ClearSearch();
                return;
            }
            sgvCustomers.SearchController.Search(txtSearch.Text);
        }

        private async void txtReload_Click(object sender, EventArgs e)
        {
            if (!(sender is Control c))
                return;
            c.Enabled = false;
            await Task.Run(LoadAll);
            c.Enabled = true;
        }
    }
}
