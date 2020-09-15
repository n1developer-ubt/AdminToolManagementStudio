using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using ToolsMarket.DbContext;
using ToolsMarket.Forms;
using ToolsMarket.Models;
using Message = ToolsMarket.Controls.Message;

namespace ToolsMarket.Controls
{
    public partial class CustomerTicketControl : UserControl, LoadableControl
    {
        public UserDbContext DbContext { get; set; }
        public CustomerTicketControl()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
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
            if (tic == null)
            {
                chat.Clear();
                CurrentTicket = null;
                return;
            }

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

        public void LoadAll()
        {
            if (DbContext == null)
                throw new Exception("Error My Write");

            var customers = DbContext.Customers.Include(x => x.Tickets).ThenInclude(x => x.Messages).FirstOrDefault(x=>x.Id == Models.Customer.CurrentCustomer.Id);

            var tic = customers.Tickets.Select(x => new Models.CustomerTicket()
                { Name = customers.Name, LastUpdate = x.Messages.OrderBy(i => i.Time).FirstOrDefault() != null ? x.Messages.OrderByDescending(i => i.Time).FirstOrDefault().Time:DateTime.MinValue, TicketId = x.Id, CustomerId = customers.Id, Status = x.TicketStatus }).ToList();

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

        private void btnCreateNewTicket_Click(object sender, EventArgs e)
        {
            using (AddSupportTicket tic = new AddSupportTicket())
            {
                tic.GenerateTicket+=TicOnGenerateTicket;
                tic.ShowDialog();
                tic.GenerateTicket -= TicOnGenerateTicket;
            }
        }

        private async void TicOnGenerateTicket(Ticket tic)
        {
            var cus = await DbContext.Customers.Include(x=>x.Tickets).FirstOrDefaultAsync(x => x.Id == Customer.CurrentCustomer.Id);
            cus.Tickets.Add(tic);
            await DbContext.SaveChangesAsync();
            var ticket = DbContext.Customers.Include(c => c.Tickets).ThenInclude(x => x.Messages)
                .FirstOrDefault(f => f.Id == Customer.CurrentCustomer.Id).Tickets.FirstOrDefault(t => t.Id == tic.Id);
            ticket.Messages.Add(new Models.Message(){Text = $"Subject: {tic.Subject}\n\nDescription: {tic.Description.Trim()}", Time = DateTime.Now, Type = MessageType.Customer});
            await DbContext.SaveChangesAsync();
            LoadAll();
        }

        private async void btnReload_Click(object sender, EventArgs e)
        {
            Enabled = false;
            LoadAll();
            Enabled = true;
        }
    }
}
