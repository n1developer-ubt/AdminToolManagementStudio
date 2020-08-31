using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using ToolsMarket.Models;

namespace ToolsMarket.DbContext
{
    public class UserDbContext:Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Customer> Customers  { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(new MySqlConnectionStringBuilder()
            {
                Server = "localhost",
                Port = 3306,
                UserID = "root",
                Password = "",
                Database = "WCDToolManagement"
            }.ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
