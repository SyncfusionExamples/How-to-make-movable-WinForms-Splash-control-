﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplashControlSample
{
    public partial class Form1 : Form
    {
        //Determined the cursor point 
        Point cursorPoint = new Point();

        public Form1()
        {
            InitializeComponent();
            this.splashControl1.SplashControlPanel.MouseDown += SplashControlPanel_MouseDown;
            this.splashControl1.SplashControlPanel.MouseMove += SplashControlPanel_MouseMove;
        }

        private void SplashControlPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (Control.MouseButtons == MouseButtons.Left)
            {
                if (this.splashControl1.SplashControlPanel.Parent is Form)
                {
                    (this.splashControl1.SplashControlPanel.Parent as Form).Left = Cursor.Position.X - cursorPoint.X;
                    (this.splashControl1.SplashControlPanel.Parent as Form).Top = Cursor.Position.Y - cursorPoint.Y;
                }
            }
        }

        private void SplashControlPanel_MouseDown(object sender, MouseEventArgs e)
        {
            cursorPoint = e.Location;
        }
    }
}