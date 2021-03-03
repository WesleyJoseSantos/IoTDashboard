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
    [ToolboxItem(true)]
    public partial class DarkTheme : IoTDashboardControls.Components.Theme
    {
        public DarkTheme()
        {

            InitializeComponent();
        }

        public DarkTheme(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            ButtonTheme.TextTheme = TextTheme;
            WindowTheme.ButtonTheme.Color = Color.FromArgb(255, 45, 45, 48);
            WindowTheme.ButtonTheme.ColorOnEnter = Color.FromArgb(255, 63, 63, 65);
            WindowTheme.ButtonTheme.ColorOnClick = Color.FromArgb(255, 0, 122, 204);
            MenuTheme.ButtonTheme = ButtonTheme;
            MenuTheme.TextTheme = TextTheme;
            ScreenTheme.ButtonTheme = ButtonTheme;

        }
    }
}
