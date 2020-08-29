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

namespace AdminToolManagementStudio.Forms
{
    public partial class Tool : SfForm
    {
        public Tool()
        {
            InitializeComponent();
        }

        private bool IsOkay = false;

        public Models.Tool Value => IsOkay?new Models.Tool()
        {
            Password = txtPassword.Text,
            Port = (int) (txtPort.Value ?? 0),
            Price = (int) (txtPrice.Value??0),
            Smtp = txtSmtp.Text,
            Ssl = chkSSL.Checked,
            Status = "Unknown",
            Username = txtUsername.Text,
            Type = txtProductType.Text
        }: null;

        private void btnAction_Click(object sender, EventArgs e)
        {
            IsOkay = true;
            Hide();
        }
    }
}
