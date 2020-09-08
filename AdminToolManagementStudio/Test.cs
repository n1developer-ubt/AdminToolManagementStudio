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
using Syncfusion.WinForms.Controls;

namespace AdminToolManagementStudio
{
    public partial class Test : SfForm
    {
        public Test()
        {
            InitializeComponent();
            message1.LoadMessage(new Models.Message() { Text = "daskhd sahaskhska sakh skh ksah sakdhsakd hskajdh sakjdhsakjdhskjadhkjsadhkjsahdsjkad sakjd akshd sa", Type = MessageType.Customer });
            message2.LoadMessage(new Models.Message() { Text = "daskhd sahaskhska sakh skh ksah sakdhsakd hskajdh sakjdhsakjdhskjadhkjsadhkjsahdsjkad sakjd akshd sa", Type = MessageType.Customer });
            message3.LoadMessage(new Models.Message() { Text = "daskhd sahaskhska sakh skh ksah sakdhsakd hskajdh sakjdhsakjdhskjadhkjsadhkjsahdsjkad sakjd akshd sa" });
            message4.LoadMessage(new Models.Message() { Text = "daskhd sahaskhska sakh skh ksah sakdhsakd hskajdh sakjdhsakjdhskjadhkjsadhkjsahdsjkad sakjd akshd sa" });
            message5.LoadMessage(new Models.Message() { Text = "daskhd sahaskhska sakh skh ksah sakdhsakd hskajdh sakjdhsakjdhskjadhkjsadhkjsahdsjkad sakjd akshd sa" });
            //message.LoadMessage(new Models.Message() { Text = "daskhd sahaskhska sakh skh ksah sakdhsakd hskajdh sakjdhsakjdhskjadhkjsadhkjsahdsjkad sakjd akshd sa" });
        }
    }
}
