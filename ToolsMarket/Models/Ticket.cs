using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToolsMarket.Models
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }

        public string Subject { get; set; }
        public string Description { get; set; }

        public string Status
        {
            get => TicketStatus.ToString();
            set
            {
                var e = Enum.TryParse(value, out TicketStatus status);
                TicketStatus = status;
            }
        }

        public List<Message> Messages { get; set; }

        [NotMapped] public TicketStatus TicketStatus;
    }

    public class CustomerTicket
    {
        public TicketStatus Status { get; set; }
        public int CustomerId { get; set; }
        public int TicketId { get; set; }
        public string Name { get; set; }
        public DateTime LastUpdate { get; set; }
    }
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }

        public string Name { get; set; }

        public string MessageType
        {
            get => Type.ToString();
            set
            {
                var e = Enum.TryParse(value, out MessageType type);
                Type = type;
            }
        }

        [NotMapped]
        public MessageType Type { get; set; }
    }

    public enum MessageType
    {
        Admin,
        Customer
    }

    public enum TicketStatus
    {
        Pending,
        Resolved
    }
}
