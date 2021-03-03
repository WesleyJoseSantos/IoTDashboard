using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTDashboardControls.Components
{
    [ToolboxItem(false)]
    public partial class ButtonTheme : Component
    {
        public Color Color { get; set; }
        public Color ColorOnEnter { get; set; }
        public Color ColorOnClick { get; set; }

        public ButtonTheme()
        {
            InitializeComponent();
        }

        public ButtonTheme(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
