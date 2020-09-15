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
    public partial class  OtherTool : SfForm
    {
        public OtherTool()
        {
            InitializeComponent();
        }

        private bool IsOkay = false;

        public Models.OtherTool Value => IsOkay?new Models.OtherTool()
        {
            Password = txtPassword.Text,
            Description = txtPort.Text,
            Price = (int) (txtPrice.Value??0),
            Smtp = txtSmtp.Text,
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
