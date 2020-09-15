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
    public partial class CustomerTicket : UserControl
    {
        public event EventHandler Selected;
        public Models.CustomerTicket Ticket { get; set; }
        public CustomerTicket()
        {
            InitializeComponent();
        }

        public CustomerTicket(Models.CustomerTicket x) : this()
        {
            Ticket = x;
            lblName.Text = x.Name;
            lblDate.Text = x.LastUpdate.ToString("g");
            lblID.Text = x.TicketId.ToString();
            //MessageBox.Show(x.TicketId.ToString());
            if (Ticket.Status == TicketStatus.Pending)
            {
                BackColor = Color.FromArgb(246, 123, 0);
                return;
            }

            BackColor = Color.FromArgb(79, 123, 42);
        }

        public void SetTicketStatus(TicketStatus status)
        {
            Ticket.Status = status;

            if (IsSelected) return;

            if (Ticket.Status == TicketStatus.Pending)
            {
                BackColor = Color.FromArgb(246, 123, 0);
                return;
            }

            BackColor = Color.Green;
        }

        private void lblName_MouseEnter(object sender, EventArgs e)
        {
            Hover(true);
        }

        private void lblName_MouseLeave(object sender, EventArgs e)
        {
            Hover(false);
        }


        private void Hover(bool hover)
        {
            if (IsSelected)
                return;

            if (Ticket.Status == TicketStatus.Pending)
            {
                BackColor = hover ? Color.FromArgb(246, 98, 0) : Color.FromArgb(246, 123, 0);
            }
            else
            {
                BackColor = hover ? Color.FromArgb(0, 88, 0) : Color.FromArgb(0, 128, 0);
            }

        }

        private bool _isSelected;

        public bool IsSelected
        {
            get => _isSelected;
            set
            {
                _isSelected = value;
                if (value)
                {
                    BackColor = Color.FromArgb(0, 122, 204);
                    return;
                }

                if (Ticket.Status == TicketStatus.Pending)
                {
                    BackColor = Color.FromArgb(246, 123, 0);
                    return;
                }

                BackColor = Color.Green;
            }
        }

        private void lblName_MouseClick(object sender, MouseEventArgs e)
        {
            Selected?.Invoke(this, null);
        }
    }
}
