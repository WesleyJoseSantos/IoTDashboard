using IoTDashboardControls.Components;
using IoTDashboardControls.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoTDashboardControls.Controls
{
    public partial class Menu : UserControl, INewControl
    {

        private Theme theme;
        public Theme Theme
        {
            get => theme;
            set
            {
                theme = value;
                if (theme == null) return;
                UpdateTheme();
            }
        }

        public Menu()
        {
            InitializeComponent();
        }

        private void UpdateTheme()
        {
            if(Theme != null)
            {
                BackColor = Theme.MenuTheme.MenuColor;
                menuHeader.BackColor = Theme.MenuTheme.HeaderColor;
                labelHeader.Font = Theme.MenuTheme.TextTheme.TextFont;
                labelHeader.ForeColor = Theme.MenuTheme.TextTheme.TextColor;
                foreach (Control control in Controls)
                {
                    if(control is INewControl c)
                    {
                        c.Theme = Theme;
                    }
                }
            }
        }
    }
}
