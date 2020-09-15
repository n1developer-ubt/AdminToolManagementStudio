using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToolsMarket.Models
{
    public class Tool
    {
        [Key]
        public int Id { get; set; }

        public string Smtp { get; set; }
        public int Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Ssl { get; set; }
        public  string Status { get; set; }
        public int Price { get; set; }
        public string Type { get; set; }

        [NotMapped] public string Buy { get; set; } = "Buy";

        public override string ToString()
        {
            return $"{Smtp}|{Port}|{Username}|{Password}|{(Ssl ? "Ssl":"None")}|{Status}|{Type}|{Price}";
        }
    }
}
