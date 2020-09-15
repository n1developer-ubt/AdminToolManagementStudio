using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdminToolManagementStudio.DatabaseContext;
using AdminToolManagementStudio.Models;
using Microsoft.EntityFrameworkCore;

namespace AdminToolManagementStudio.Controls
{
    public partial class AdminTicketControl : UserControl, LoadableControl
    {
        public CustomerDbContext DbContext { get; set; }
        public AdminTicketControl()
        {
            InitializeComponent();
            tickets.TicketSelectionChanged += TicketsOnTicketSelectionChanged;
            chat.SendMessage += ChatOnSendMessage;
        }

        private async void ChatOnSendMessage(Models.Message message)
        {
            CurrentTicket.Messages.Add(message);
            await DbContext.SaveChangesAsync();
        }

        private Ticket CurrentTicket;

        private async void TicketsOnTicketSelectionChanged(Models.CustomerTicket tic)
        {
            var customer = await DbContext.Customers.Include(x => x.Tickets).ThenInclude(x => x.Messages).FirstOrDefaultAsync(x => x.Id == tic.CustomerId);

            if (customer == null)
            {
                MessageBox.Show("Customer nULL");
                return;
            }

            Message.CustomerName = customer.Name;

            var ticket = customer.Tickets.FirstOrDefault(x => x.Id == tic.TicketId);

            CurrentTicket = ticket;

            if (ticket != null)
            {
                chat.LoadAllMessages(ticket.Messages);
            }
        }


        public async Task LoadAll()
        {
            if (DbContext == null)
                throw new Exception("Error My Write");

            var customers = await DbContext.Customers.Include(x => x.Tickets).ThenInclude(x => x.Messages)
                .Where(x => x.Tickets.Count > 0).ToListAsync();

            var tic = customers.SelectMany(x => x.Tickets.Select(y => new Models.CustomerTicket()
            { Name = x.Name, LastUpdate = y.Messages.OrderBy(i => i.Time).FirstOrDefault() != null ? y.Messages.OrderByDescending(i => i.Time).FirstOrDefault().Time : DateTime.MinValue, TicketId = y.Id, CustomerId = x.Id, Status = y.TicketStatus })).ToList();

            tickets.LoadCustomerTicket(tic);
        }

        private async void btnMarkAsResolved_Click(object sender, EventArgs e)
        {
            if (!(sender is Control c)) return;
            c.Enabled = false;

            if(CurrentTicket == null) return;

            CurrentTicket.TicketStatus = TicketStatus.Resolved;

            await DbContext.SaveChangesAsync();

            tickets.SelectCustomerTicket.SetTicketStatus(TicketStatus.Resolved);

            c.Enabled = true;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Enabled = false;
            LoadAll();
            Enabled = true;
        }
    }
}
