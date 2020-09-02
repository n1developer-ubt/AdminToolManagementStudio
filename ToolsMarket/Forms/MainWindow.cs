using System.Threading.Tasks;
using Syncfusion.WinForms.Controls;
using ToolsMarket.DbContext;

namespace ToolsMarket.Forms
{
    public partial class MainWindow : SfForm
    {
        public MainWindow()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            var dbContext = new UserDbContext();
            //dbContext.Database.EnsureDeleted();
            dbContext.Database.EnsureCreated();
            tools1.DbContext = dbContext;
            tools1.LoadAll();
            order1.DbContext = dbContext;
            Task.Run(order1.LoadAll);
        }
    }
}
