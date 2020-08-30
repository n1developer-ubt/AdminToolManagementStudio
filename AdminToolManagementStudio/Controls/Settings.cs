using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminToolManagementStudio.Controls
{
    public partial class Settings : UserControl
    {
        public delegate void ActionPerformed(Models.Settings newSettings);
        public event ActionPerformed SettingsUpdated;
        public Settings()
        {
            InitializeComponent();
        }

        public void LoadSettings(Models.Settings s)
        {
            txtTempEmail.Text = s.TempEmail??"";
        }
        public Models.Settings Setting
        {
            get=>new Models.Settings()
            {
                TempEmail = txtTempEmail.Text
            };
            set { txtTempEmail.Text = value.TempEmail; }
        }

        private void btnSaveTempEmail_Click(object sender, EventArgs e)
        {
            SettingsUpdated?.Invoke(Setting);
        }
    }
}
