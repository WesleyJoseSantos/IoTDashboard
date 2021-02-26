using IoTDashboard.Components;
using IotDashboardControls.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IotDashboard.Controls
{
    public partial class HeaderText : Label, INewControl
    {
        private Theme theme;

        public Theme Theme
        {
            get => theme;
            set
            {
                theme = value;
                if (theme == null) return;
                ForeColor = theme.TextTheme.TextColor;
                Font = theme.TextTheme.TextFont;
            }
        }

        public HeaderText()
        {
            InitializeComponent();
        }
    }
}
