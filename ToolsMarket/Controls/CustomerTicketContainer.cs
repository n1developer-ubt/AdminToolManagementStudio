using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using AdminToolManagementStudio.Controls;

namespace ToolsMarket.Controls
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
            TicketSelectionChanged?.Invoke(null);
            pnlTick.Controls.Clear();
            pnlTick.SuspendLayout();
            foreach (var customerTicket in tickets.OrderBy(x => x.LastUpdate))
            {
                var c = new CustomerTicket(customerTicket);
                c.Height = 42;
                c.Dock = DockStyle.Top;
                if (pnlTick.InvokeRequired)
                    pnlTick.Invoke(new System.Action(() =>
                        pnlTick.Controls.Add(c)));
                else
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
