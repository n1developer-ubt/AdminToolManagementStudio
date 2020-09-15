using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using MySql.Data.MySqlClient;
using ToolsMarket.Models;

namespace ToolsMarket.DbContext
{
    public class UserDbContext:Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<Customer> Customers  { get; set; }
        public DbSet<Tool> Tools  { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OtherOrder> OtherOrders { get; set; }
        public DbSet<OtherTool> OtherTools { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseMySql(new MySqlConnectionStringBuilder()
            //{
            //    Server = "sql12.freemysqlhosting.net",
            //    Port = 3306,
            //    UserID = "sql12363680",
            //    Password = "TJpzhECnwq",
            //    Database = "sql12363680"
            //}.ConnectionString, b => { b.EnableRetryOnFailure(5); });
            optionsBuilder.UseMySql(new MySqlConnectionStringBuilder()
            {
                Server = "191.101.164.254",
                Port = 3306,
                UserID = "admin_usa",
                Password = "S7hSaHHQI1",
                Database = "admin_usa"
            }.ConnectionString, b => { b.EnableRetryOnFailure(5); });

            //optionsBuilder.UseMySql(new MySqlConnectionStringBuilder()
            //{
            //    Server = "localhost",
            //    Port = 3306,
            //    UserID = "root",
            //    Password = "",
            //    Database = "WCDToolManagement"
            //}.ConnectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
