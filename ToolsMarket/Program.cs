using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolsMarket.Forms;
using ToolsMarket.Models;

namespace ToolsMarket
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            
            Application.SetCompatibleTextRenderingDefault(false);

            Customer.CurrentCustomer = new Customer()
            {
                Id = 2
            };

            Application.Run(new MainWindow());
        }
    }
}
