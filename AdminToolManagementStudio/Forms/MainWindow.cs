using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminToolManagementStudio.Controls;
using AdminToolManagementStudio.DatabaseContext;
using AdminToolManagementStudio.Models;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Syncfusion.WinForms.Controls;
using Message = AdminToolManagementStudio.Models.Message;
using Settings = AdminToolManagementStudio.Models.Settings;

namespace AdminToolManagementStudio.Forms
{
    public partial class MainWindow : SfForm
    {
        private static MySqlConnectionStringBuilder ConnectionStringBuilder;

        public MainWindow()
        {
            //Properties.Settings.Default.FirstTime = true;
            //Properties.Settings.Default.Save();
            InitializeComponent();
            LoadableControls = new[] { new LoadableControlType() { Control = users1, Loaded = true }, new LoadableControlType() { Loaded = false, Control = tools1 }, new LoadableControlType() { Control = otherTools1, Loaded = false }, new LoadableControlType() { Loaded = false, Control = order1 }, new LoadableControlType() { Control = otherOrder1, Loaded = false }, new LoadableControlType() { Loaded = false, Control = ticket }, new LoadableControlType() { Loaded = true }, };
            CheckForIllegalCrossThreadCalls = false;
            settings1.SettingsUpdated += Settings1OnSettingsUpdated;
            LoadSettings();
            CheckDatabase();
        }

        private void EnableAll(bool enable)
        {
            tabControlAdv1.Enabled = enable;
        }

        private void CheckDatabase()
        {
            Task.Run(() =>
            {
                EnableAll(false);
                Text = "Admin Management - Loading";
                var result = ConfigureDatabase();
                Notify(result);
            });
        }

        private void Notify(DatabaseStatus result)
        {
            Invoke(new Action(() =>
            {
                switch (result)
                {
                    case DatabaseStatus.ConnectionError:
                        MessageBox.Show("Connection To Database Failed! Configure Settings", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    case DatabaseStatus.Unknown:
                        MessageBox.Show("Unknow Error, Contact Admin!", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        break;
                    case DatabaseStatus.ConfigureDatabaseSetting:
                        MessageBox.Show("Please Configure Database Setting!", "Error", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                        break;
                }
            }));

            Text = "Admin Management - Error";
            if (result == DatabaseStatus.Ok)
            {
                EnableAll(true);
                Text = "Admin Management - Connected";
            }
        }



        private DatabaseStatus ConfigureDatabase()
        {
            //_setting.DatabaseInfo = new DatabaseInfo()
            //{
            //    DatabaseName = "WCDToolManagement",
            //    Username = "root",
            //    Port = "3306",
            //    Host = "localhost",
            //    Password = ""
            //};
            if (_setting.DatabaseInfo == null)
            {
                //_setting.DatabaseInfo = new DatabaseInfo()
                //{
                //    DatabaseName = "sql12363680",
                //    Username = "sql12363680",
                //    Port = "3306",
                //    Host = " sql12.freemysqlhosting.net",
                //    Password = "TJpzhECnwq"
                //};
                return DatabaseStatus.ConfigureDatabaseSetting;
                SaveSetting();
            }

            try
            {
                CustomerDbContext.ConnectionStringBuilder = new MySqlConnectionStringBuilder()
                {
                    Server = _setting.DatabaseInfo.Host,
                    Port = Convert.ToUInt16(_setting.DatabaseInfo.Port),
                    UserID = _setting.DatabaseInfo.Username,
                    Password = _setting.DatabaseInfo.Password,
                    Database = _setting.DatabaseInfo.DatabaseName
                };
            }
            catch (Exception e)
            {
                return DatabaseStatus.ConfigureDatabaseSetting;
            }

            CustomerDbContext dbContext = null;

            try
            {
                dbContext = new CustomerDbContext();
                //dbContext.Database.EnsureDeleted();
                dbContext.Database.EnsureCreated();
            }
            catch (Exception e)
            {
                return DatabaseStatus.ConnectionError;
            }

            try
            {
                users1.DbContext = dbContext;
                tools1.DbContext = new CustomerDbContext();
                otherOrder1.DbContext = new CustomerDbContext();
                otherTools1.DbContext = new CustomerDbContext();
                order1.DbContext = new CustomerDbContext();
                ticket.DbContext = new CustomerDbContext();
                users1.LoadAll().Wait();
            }
            catch (Exception e)
            {
                return DatabaseStatus.Unknown;
            }

            return DatabaseStatus.Ok;
        }

        #region Settings

        private void SaveSetting()
        {
            Properties.Settings.Default.AppSettings = JsonConvert.SerializeObject(_setting);
            Properties.Settings.Default.Save();
        }

        private void LoadSettings()
        {
            if(Properties.Settings.Default.FirstTime)
            {
                _setting = new Settings();
                _setting.DatabaseInfo = new DatabaseInfo()
                {
                    DatabaseName = "admin_usa",
                    Username = "admin_usa",
                    Port = "3306",
                    Host = "191.101.164.254",
                    Password = "S7hSaHHQI1"
                };
                settings1.LoadSettings(_setting);
                Properties.Settings.Default.FirstTime = false;
                Properties.Settings.Default.Save();
                SaveSetting();
                return;
            }
            
            if (Properties.Settings.Default.AppSettings.Equals(""))
            {
                _setting = new Settings();
                return;
            }

            _setting = JsonConvert.DeserializeObject<Settings>(Properties.Settings.Default.AppSettings);
            tools1.TempMail = _setting.TempEmail;
            settings1.LoadSettings(_setting);
        }

        private void UpdateSetting(Controls.Settings.SettingType s)
        {
            if(s == AdminToolManagementStudio.Controls.Settings.SettingType.TempEmail)
                tools1.TempMail = _setting.TempEmail;
            else if(s == AdminToolManagementStudio.Controls.Settings.SettingType.DatabaseInfo)
                CheckDatabase();
        }

        private Settings _setting;
        private void Settings1OnSettingsUpdated(Settings newSettings, Controls.Settings.SettingType s)
        {
            _setting = newSettings;
            SaveSetting();
            UpdateSetting(s);
        }
        #endregion

        public LoadableControlType[] LoadableControls;

        private async void tabControlAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!LoadableControls[tabControlAdv1.SelectedIndex].Loaded)
            {
                if (LoadableControls[tabControlAdv1.SelectedIndex].Control == null)
                    return;

                try
                {

                    await LoadableControls[tabControlAdv1.SelectedIndex].Control.LoadAll();
                    LoadableControls[tabControlAdv1.SelectedIndex].Loaded = true;
                }
                catch (Exception exception)
                {

                }
            }
        }
    }
    public enum DatabaseStatus
    {
        ConfigureDatabaseSetting,
        ConnectionError,
        Unknown,
        Ok
    }
}
