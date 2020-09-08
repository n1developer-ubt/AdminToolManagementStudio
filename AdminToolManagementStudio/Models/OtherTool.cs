using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminToolManagementStudio.Models
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
    }
}
