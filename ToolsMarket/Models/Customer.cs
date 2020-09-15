using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ToolsMarket.Models
{
    public class Customer
    {
        public static Customer CurrentCustomer { get; set; }
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsBlocked { get; set; }
        public List<Ticket> Tickets { get; set; }
    }
}
