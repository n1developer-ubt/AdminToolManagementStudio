using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminToolManagementStudio.DatabaseContext;
using Syncfusion.WinForms.Controls;

namespace AdminToolManagementStudio
{
    public partial class MainWindow : SfForm
    {
        private readonly CustomerDbContext _dbContext;
        public MainWindow()
        {
            InitializeComponent();
            _dbContext = new CustomerDbContext();
            //_dbContext.Database.EnsureDeleted();
            _dbContext.Database.EnsureCreated();

            users1.DbContext = _dbContext;
            tools1.DbContext = _dbContext;
            users1.LoadAll();
            tools1.LoadAll();
        }

        private void tabControlAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPageAdv1_Click(object sender, EventArgs e)
        {

        }

        private void tabPageAdv2_Click(object sender, EventArgs e)
        {

        }
    }
}
