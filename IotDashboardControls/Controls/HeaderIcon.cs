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
    public partial class HeaderIcon : PictureBox, INewControl
    {
        private Theme theme;

        public Theme Theme { get; set; }

        public HeaderIcon()
        {
            InitializeComponent();
        }
    }
}
