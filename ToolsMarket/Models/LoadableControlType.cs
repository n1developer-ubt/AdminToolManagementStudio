using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdminToolManagementStudio.Controls;
using ToolsMarket.Controls;

namespace AdminToolManagementStudio.Models
{
    public class LoadableControlType
    {
        public bool Loaded { get; set; }
        public LoadableControl Control { get; set; }
    }
}
