using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminToolManagementStudio.Models;
using Message = AdminToolManagementStudio.Models.Message;

namespace AdminToolManagementStudio
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();

            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            try
            {
                message1.LoadMessage(new Message(){Text = "akldjhaskdjsakldjsld jas ldasjldlasdjaskldjasldjaskldjas kld jaskld jaskldjas kldj alkd jald jaslkdjaslkd jasldjaldj asldj asldjlasdjasldj aldj asld jsl"});
            }
            catch (Exception e)
            {
                
            }
        }
    }
}
