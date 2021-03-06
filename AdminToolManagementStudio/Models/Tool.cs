﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminToolManagementStudio.Models
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
        public bool Purchased { get; set; }
    }
}
