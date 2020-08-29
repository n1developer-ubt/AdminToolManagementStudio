using System;
using AdminToolManagementStudio.Models;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;

namespace AdminToolManagementStudio.DatabaseContext
{
    public class CustomerDbContext:DbContext
    {
        private static readonly MySqlConnectionStringBuilder ConnectionStringBuilder = new MySqlConnectionStringBuilder()
            {
                Server = "localhost",
                Port = 3306,
                UserID = "root",
                Password = "",
                Database = "WCDToolManagement"
            };
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConnectionStringBuilder.ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Tool> Tools { get; set; }
        public DbSet<Order> Orders { get; set; }

    }
}
