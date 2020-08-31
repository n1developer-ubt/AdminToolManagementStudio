using System.ComponentModel.DataAnnotations;

namespace ToolsMarket.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsBlocked { get; set; }
    }
}
