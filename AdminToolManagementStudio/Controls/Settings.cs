using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminToolManagementStudio.Models;

namespace AdminToolManagementStudio.Controls
{
    public partial class Settings : UserControl
    {
        public enum SettingType
        {
            TempEmail,
            DatabaseInfo
        }

        public delegate void ActionPerformed(Models.Settings newSettings, SettingType s);
        public event ActionPerformed SettingsUpdated;
        public Settings()
        {
            InitializeComponent();
        }

        public void LoadSettings(Models.Settings s)
        {
            txtTempEmail.Text = s.TempEmail??"";

            if (s.DatabaseInfo == null)
                return;

            txtPassword.Text = s.DatabaseInfo.Password;
            txtUsername.Text = s.DatabaseInfo.Username;
            txtHost.Text = s.DatabaseInfo.Host;
            txtPort.Text = s.DatabaseInfo.Port;
            txtDatabaseName.Text = s.DatabaseInfo.DatabaseName;
        }
        public Models.Settings Setting
        {
            get=>new Models.Settings()
            {
                TempEmail = txtTempEmail.Text,
                DatabaseInfo = new DatabaseInfo()
                {
                    Port = txtPort.Text.Trim(),
                    DatabaseName = txtDatabaseName.Text.Trim(),
                    Host = txtHost.Text.Trim(),
                    Password = txtPassword.Text??"",
                    Username = txtUsername.Text.Trim()
                }
            };
            set
            {
                txtTempEmail.Text = value.TempEmail;
                if (value.DatabaseInfo == null) return;

                txtPassword.Text = value.DatabaseInfo.Password;
                txtPort.Text = value.DatabaseInfo.Port;
                txtDatabaseName.Text = value.DatabaseInfo.DatabaseName;
                txtHost.Text = value.DatabaseInfo.Host;
                txtUsername.Text = value.DatabaseInfo.Username;
            }
        }

        private void btnSaveTempEmail_Click(object sender, EventArgs e)
        {
            SettingsUpdated?.Invoke(Setting, SettingType.TempEmail);
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            SettingsUpdated?.Invoke(Setting,SettingType.DatabaseInfo);
        }
    }
}
