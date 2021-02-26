﻿using IoTDashboard.Components;
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
                BackColor = theme.WindowTheme.ButtonColor;
            }
        }

        public WindowControlButton()
        {
            InitializeComponent();
        }

        private void WindowControlButton_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Theme.WindowTheme.ButtonColorOnEnter;
        }

        private void WindowControlButton_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Theme.WindowTheme.ButtonColor;
        }

        private void WindowControlButton_MouseDown(object sender, MouseEventArgs e)
        {
            BackColor = Theme.WindowTheme.ButtonColorOnClick;
        }

        private void WindowControlButton_MouseUp(object sender, MouseEventArgs e)
        {
            BackColor = Theme.WindowTheme.ButtonColor;
        }
    }
}
