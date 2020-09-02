using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolsMarket.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        [ForeignKey("ToolId")]
        public Tool Tool { get; set; }

        public string Status
        {
            get => OrderStatus.ToString();
            set
            {
                OrderStatus s;
                Enum.TryParse(value, out s);
                OrderStatus = s;
            }
        }

        [NotMapped]
        public OrderStatus OrderStatus { get; set; }
    }

    public enum OrderStatus
    {
        Pending,
        Accepted,
        Rejected
    }
}
