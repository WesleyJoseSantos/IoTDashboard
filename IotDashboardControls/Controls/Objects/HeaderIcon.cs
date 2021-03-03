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

namespace IotDashboard.Controls.Objects
{
    [ToolboxItem(false)]
    public partial class HeaderIcon : PictureBox, INewControl
    {
        public Theme Theme { get; set; }

        public HeaderIcon()
        {
            InitializeComponent();
        }
    }
}
