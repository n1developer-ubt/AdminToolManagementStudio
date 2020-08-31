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
            settings1.SettingsUpdated += Settings1OnSettingsUpdated;
            LoadSettings();
            var result = ConfigureDatabase();

            switch (result)
            {
                case DatabaseStatus.ConnectionError:
                    MessageBox.Show("Connection To Database Failed! Configure Settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case DatabaseStatus.Unknown:
                    MessageBox.Show("Unknow Error, Contact Admin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                case DatabaseStatus.ConfigureDatabaseSetting:
                    MessageBox.Show("Please Configure Database Setting!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
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
            if (_setting.DatabaseInfo == null) return DatabaseStatus.ConfigureDatabaseSetting;

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
                return;

            _setting = JsonConvert.DeserializeObject<Settings>(Properties.Settings.Default.AppSettings);
            tools1.TempMail = _setting.TempEmail;
            settings1.LoadSettings(_setting);
        }

        private void UpdateSetting()
        {
            tools1.TempMail = _setting.TempEmail;
            ConfigureDatabase();
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
