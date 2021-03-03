using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoTDashboard.Components
{
    [ToolboxItem(false)]
    public partial class ScreenTheme : Component
    {
        public Color BackgroundColor { get; set; }

        public ScreenTheme()
        {
            InitializeComponent();
        }

        public ScreenTheme(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

    }
}
