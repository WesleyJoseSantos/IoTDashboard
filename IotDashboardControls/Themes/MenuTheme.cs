using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IotDashboardControls.Themes
{
    public partial class MenuTheme : Component
    {
        public Color HeaderColor { get; set; }
        public Color MenuColor { get; set; }

        public MenuTheme()
        {
            InitializeComponent();
        }

        public MenuTheme(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
