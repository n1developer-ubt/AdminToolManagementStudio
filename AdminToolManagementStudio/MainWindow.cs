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
using Newtonsoft.Json;
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
            settings1.SettingsUpdated+=Settings1OnSettingsUpdated;
            users1.DbContext = _dbContext;
            tools1.DbContext = _dbContext;
            users1.LoadAll();
            tools1.LoadAll();
            LoadSettings();
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
        }

        private Settings _setting;
        private void Settings1OnSettingsUpdated(Settings newSettings)
        {
            _setting = newSettings;
            SaveSetting();
            UpdateSetting();
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
