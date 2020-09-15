using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToolsMarket.Models
{
    public class OtherTool
    {
        [Key]
        public int Id { get; set; }
        public string Smtp { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Description { get; set; }
        public  string Status { get; set; }
        public int Price { get; set; }
        public string Type { get; set; }
        public bool Purchased { get; set; }

        [NotMapped]
        public string Buy { get; set; }

        public override string ToString()
        {
            return $"{Smtp}|{Username}|{Password}|{Description}|{Status}|{Type}|{Price}";
        }
    }
}
