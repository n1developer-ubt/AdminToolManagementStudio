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
using ToolsMarket.Models;

namespace ToolsMarket.Forms
{
    public partial class AddSupportTicket : SfForm
    {
        public delegate void Ticket(Models.Ticket tic);

        public event Ticket GenerateTicket;
        public AddSupportTicket()
        {
            InitializeComponent();
        }

        private void btnGenerateNewTicket_Click(object sender, EventArgs e)
        {
            GenerateTicket?.Invoke(new Models.Ticket(){Subject = txtSubject.Text, Description = txtDescription.Text, TicketStatus = TicketStatus.Pending});
            Hide();
        }
    }
}
