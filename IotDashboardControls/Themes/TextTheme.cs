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
    public partial class TextTheme : Component
    {
        public Color TextColor { get; set; }
        public Font TextFont { get; set; }

        public TextTheme()
        {
            InitializeComponent();
        }

        public TextTheme(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

    }
}
