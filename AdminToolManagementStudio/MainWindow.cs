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
using AdminToolManagementStudio.Models;
using EnvDTE;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Syncfusion.WinForms.Controls;

namespace AdminToolManagementStudio
{
    public partial class MainWindow : SfForm
    {
        private static MySqlConnectionStringBuilder ConnectionStringBuilder;

        public MainWindow()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            settings1.SettingsUpdated += Settings1OnSettingsUpdated;
            LoadSettings();
            CheckDatabase();
        }

        private void EnableAll(bool enable)
        {
            tools1.Enabled = enable;
            users1.Enabled = enable;
            order1.Enabled = enable;
        }

        private void CheckDatabase()
        {
            Task.Run(() =>
            {
                EnableAll(false);
                Text = "Admin Management - Loading";
                var result = ConfigureDatabase();

                Invoke(new Action(() => {
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
            });
        }

        enum DatabaseStatus
        {
            ConfigureDatabaseSetting,
            ConnectionError,
            Unknown,
            Ok
        }

        private DatabaseStatus ConfigureDatabase()
        {
            _setting.DatabaseInfo = new DatabaseInfo()
            {
                DatabaseName = "sql12363680",
                Username = "sql12363680",
                Port = "3306",
                Host = "sql12.freemysqlhosting.net",
                Password = "TJpzhECnwq"
            };
            if (_setting.DatabaseInfo == null)
            {
                _setting.DatabaseInfo = new DatabaseInfo(){
                    DatabaseName = "sql12363680",
                    Username = "sql12363680",
                    Port = "3306",
                    Host = " sql12.freemysqlhosting.net",
                    Password = "TJpzhECnwq"
                };
                //_setting.DatabaseInfo = new DatabaseInfo(){
                //    DatabaseName = "admin_usa",
                //    Username = "admin_usa",
                //    Port = "3306",
                //    Host = "191.101.164.254",
                //    Password = "S7hSaHHQI1"
                //};
            }

            try
            {
                CustomerDbContext.ConnectionStringBuilder=new MySqlConnectionStringBuilder()
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

            //MessageBox.Show(JsonConvert.SerializeObject(CustomerDbContext.ConnectionStringBuilder));
            CustomerDbContext dbContext = null;

            try
            {
                dbContext = new CustomerDbContext();
                //_dbContext.Database.EnsureDeleted();
                dbContext.Database.EnsureCreated();
            }
            catch (Exception e)
            {
                return DatabaseStatus.ConnectionError;
            }

            try
            {
                users1.DbContext = dbContext;
                tools1.DbContext = dbContext;
                order1.DbContext = dbContext;
                order1.LoadAll();
                users1.LoadAll();
                tools1.LoadAll();
            }
            catch (Exception e)
            {
                return DatabaseStatus.Unknown;
            }

            return DatabaseStatus.Ok;
        }

        private void SaveSetting()
        {
            Properties.Settings.Default.AppSettings = JsonConvert.SerializeObject(_setting);
            Properties.Settings.Default.Save();
        }

        private void LoadSettings()
        {
            if (Properties.Settings.Default.AppSettings.Equals(""))
            {
                _setting = new Settings();
                return;
            }

            _setting = JsonConvert.DeserializeObject<Settings>(Properties.Settings.Default.AppSettings);
            tools1.TempMail = _setting.TempEmail;
            settings1.LoadSettings(_setting);
        }

        private void UpdateSetting()
        {
            tools1.TempMail = _setting.TempEmail;
            CheckDatabase();
        }

        private Settings _setting;
        private void Settings1OnSettingsUpdated(Settings newSettings)
        {
            _setting = newSettings;
            SaveSetting();
            UpdateSetting();
        }
    }
}
