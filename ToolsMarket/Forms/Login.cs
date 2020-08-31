using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EnvDTE;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Syncfusion.WinForms.Controls;
using ToolsMarket.DbContext;
using ToolsMarket.Properties;

namespace ToolsMarket.Forms
{
    public partial class Login : SfForm
    {
        private readonly UserDbContext DbContext;
        public Login()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            try
            {
                DbContext = new UserDbContext();
            }
            catch (Exception e)
            {
                MessageBox.Show("Server is down at this time, try again letter!");
                return;
            }


            if (Settings.Default.LoginSettings.Equals("")) return;

            var s = JsonConvert.DeserializeObject<LoginSettings>(Settings.Default.LoginSettings);

            if(s.RememberMe)
            {
                txtUsername.Text = s.Username ?? "";
                txtPassword.Text = s.Password ?? "";
                Task.Run(() => btnLogin_Click(btnLogin, null));
            }

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {

            if (!(sender is Control c)) return;

            var sx = new LoginSettings
            {
                Password = txtPassword.Text,
                RememberMe = chkRememberMe.Checked,
                Username = txtUsername.Text.Trim()
            };

            c.Enabled = false;
            c.Text = "Logging in!";

            var u = await DbContext.Customers.SingleOrDefaultAsync(s => s.Email.Equals(txtUsername.Text.Trim()));

            c.Enabled = true;
            c.Text = "Login";

            if (u == null)
            {
                MessageBox.Show("User not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!u.Password.Equals(txtPassword.Text))
            {
                MessageBox.Show("Incorrent Credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (u.IsBlocked)
            {
                MessageBox.Show("Your account is blocked!\nContact Admin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Settings.Default.LoginSettings = JsonConvert.SerializeObject(sx);
            Settings.Default.Save();

            System.Threading.Thread t = new System.Threading.Thread(() => { Application.Run(new MainWindow()); });
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            Close();
        }
    }

    public class LoginSettings
    {
        public bool RememberMe { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
