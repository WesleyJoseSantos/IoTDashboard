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

namespace IoTDashboard.Controls
{
    public partial class TopBar : UserControl, INewControl
    {
        public delegate void TopBarEvent();

        public event TopBarEvent headerIconOnClick;

        private Theme theme;

        public string HeaderText {get => headerText.Text; set => headerText.Text = value;}

        public Image HeaderIcon { get => headerIcon.Image; set => headerIcon.Image = value; }

        public Theme Theme { 
            get => theme;
            set 
            {
                theme = value;
                if (theme == null) return;
                UpdateTheme();
            } 
        }

        public TopBar()
        {
            InitializeComponent();
            UpdateTheme();
            Dock = DockStyle.Top;
        }

        private void UpdateTheme()
        {
            if(Theme != null)
            {
                BackColor = Theme.WindowTheme.BackgroudColor;
                foreach (Control control in Controls)
                {
                    if(control is INewControl c){
                        c.Theme = Theme;
                    }
                }
            }
        }

        private void buttonMin_Click(object sender, EventArgs e)
        {
            ParentForm.WindowState = FormWindowState.Minimized;
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            ParentForm.WindowState = ParentForm.WindowState == FormWindowState.Normal
                ? FormWindowState.Maximized : FormWindowState.Normal;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            ParentForm.Close();
        }

        private void headerIcon_MouseEnter(object sender, EventArgs e)
        {
            headerIcon.BackColor = Theme.WindowTheme.ButtonColorOnEnter;
        }

        private void headerIcon_MouseLeave(object sender, EventArgs e)
        {
            headerIcon.BackColor = Theme.WindowTheme.ButtonColor;
        }

        private void headerIcon_MouseDown(object sender, MouseEventArgs e)
        {
            headerIcon.BackColor = Theme.WindowTheme.ButtonColorOnClick;
        }

        private void headerIcon_MouseUp(object sender, MouseEventArgs e)
        {
            headerIcon.BackColor = Theme.WindowTheme.ButtonColor;
        }

        private void headerIcon_Click(object sender, EventArgs e)
        {
            headerIconOnClick?.Invoke();
        }
    }
}
