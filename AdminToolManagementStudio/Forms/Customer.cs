using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.WinForms.Controls;
using Syncfusion.WinForms.GridCommon.Collections.Generic;

namespace AdminToolManagementStudio.Forms
{
    public partial class Customer : SfForm
    {
        public Customer()
        {
            InitializeComponent();
        }

        private bool IsOkay = false;

        public Models.Customer Value => IsOkay
            ? new Models.Customer()
            {
                Password = txtPassword.Text,
                Email = txtEmail.Text,
                IsBlocked = false,
                Name = txtName.Text
            }
            : null;

        private void btnAction_Click(object sender, EventArgs e)
        {
            IsOkay = true;
            Hide();
        }
    }
}
