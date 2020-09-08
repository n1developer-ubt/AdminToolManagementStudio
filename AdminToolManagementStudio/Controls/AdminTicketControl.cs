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

            var ticket = customer.Tickets.FirstOrDefault(x => x.Id == tic.TicketId);

            CurrentTicket = ticket;

            if (ticket != null)
            {
                chat.LoadAllMessages(ticket.Messages);
            }
        }


        public async Task LoadAll()
        {
            var customers = await DbContext.Customers.Include(x => x.Tickets).ThenInclude(x => x.Messages)
                .Where(x => x.Tickets.Count > 0).ToListAsync();

            var tic = customers.SelectMany(x => x.Tickets.Select(y => new Models.CustomerTicket()
            { Name = x.Name, LastUpdate = DateTime.Now, TicketId = y.Id, CustomerId = x.Id, Status = y.TicketStatus })).ToList();

            tickets.LoadCustomerTicket(tic);
        }
    }
}
