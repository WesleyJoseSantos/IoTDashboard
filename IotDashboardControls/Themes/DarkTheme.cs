using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IotDashboardControls.Themes
{
    [ToolboxItem(true)]
    public partial class DarkTheme : IoTDashboard.Components.Theme
    {
        public DarkTheme()
        {
            InitializeComponent();
        }

        public DarkTheme(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
