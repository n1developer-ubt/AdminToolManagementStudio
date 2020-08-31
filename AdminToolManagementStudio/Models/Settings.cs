using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminToolManagementStudio.Models
{
    public class Settings
    {
        public string TempEmail { get; set; }
        public DatabaseInfo DatabaseInfo { get; set; }
    }

    public class DatabaseInfo
    {
        public string Username { get; set; }
        public string Host { get; set; }
        public string Port { get; set; }
        public string Password { get; set; }
        public string DatabaseName { get; set; }
    }

}
