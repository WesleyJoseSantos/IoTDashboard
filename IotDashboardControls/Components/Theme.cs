using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IoTDashboardControls.Components
{
    [ToolboxItem(false)]
    public partial class Theme : Component
    {
        public Theme()
        {
            InitializeComponent();
        }

        public Theme(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }
    }
}
