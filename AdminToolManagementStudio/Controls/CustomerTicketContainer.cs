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
    public partial class CustomerTicketContainer : UserControl
    {
        public CustomerTicket SelectCustomerTicket;

        public delegate void TicketSelected(Models.CustomerTicket tic);

        public event TicketSelected TicketSelectionChanged;
        public CustomerTicketContainer()
        {
            InitializeComponent();
        }

        public void LoadCustomerTicket(List<Models.CustomerTicket> tickets)
        {
            pnlTick.Controls.Clear();
            pnlTick.SuspendLayout();
            foreach (var customerTicket in tickets.OrderBy(x => x.LastUpdate))
            {
                var c = new CustomerTicket(customerTicket);
                c.Height = 42;
                c.Dock = DockStyle.Top;
                pnlTick.Controls.Add(c);
                c.Selected += COnSelected;
            }
            pnlTick.ResumeLayout();
        }

        private void COnSelected(object sender, EventArgs e)
        {
            if (SelectCustomerTicket != null)
            {
                SelectCustomerTicket.IsSelected = false;
            }

            SelectCustomerTicket = (sender as CustomerTicket);
            SelectCustomerTicket.IsSelected = true;

            TicketSelectionChanged?.Invoke(SelectCustomerTicket.Ticket);
        }
    }
}
