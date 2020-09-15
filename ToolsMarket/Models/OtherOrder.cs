using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToolsMarket.Models
{
    public class OtherOrder
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("CustomerId")]
        public Customer Customer { get; set; }

        [ForeignKey("ToolId")]
        public OtherTool Tool { get; set; }

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

}
