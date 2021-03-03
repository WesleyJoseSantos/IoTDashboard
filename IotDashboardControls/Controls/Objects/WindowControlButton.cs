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

namespace IotDashboard.Controls.Objects
{
    [ToolboxItem(false)]
    public partial class WindowControlButton : Label, INewControl
    {
        private Theme theme;

        public Theme Theme 
        { 
            get => theme; 
            set
            {
                theme = value;
                if (theme == null) return;
                BackColor = theme.WindowTheme.ButtonTheme.Color;
            }
        }

        public WindowControlButton()
        {
            InitializeComponent();
        }

        private void WindowControlButton_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Theme.WindowTheme.ButtonTheme.ColorOnEnter;
        }

        private void WindowControlButton_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Theme.WindowTheme.ButtonTheme.Color;
        }

        private void WindowControlButton_MouseDown(object sender, MouseEventArgs e)
        {
            BackColor = Theme.WindowTheme.ButtonTheme.ColorOnClick;
        }

        private void WindowControlButton_MouseUp(object sender, MouseEventArgs e)
        {
            BackColor = Theme.WindowTheme.ButtonTheme.Color;
        }
    }
}
