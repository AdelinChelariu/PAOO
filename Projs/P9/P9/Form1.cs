using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace P9
{
    public partial class Form1: Form
    {
        private bool am_apasat;
        private Point forma_deplasata;

        public Form1()
        {
            InitializeComponent();
        }

        private void toolBar1_MouseDown(object sender, MouseEventArgs e) { // am apasat butonul de mouse pe toolbar 
            am_apasat = true;
            forma_deplasata = new Point(e.X, e.Y);
            toolBar.Capture = true;
        }
        private void toolBar1_MouseUp(object sender, MouseEventArgs e) { am_apasat = false; toolBar1.Capture = false; }
        private void toolBar1_MouseMove(object sender, MouseEventArgs e) {
            if(am_apasat) {
                if(toolBar.Dock == DockStyle.Top || toolBar.Dock == DockStyle.Left) { // daca depaseste atunci duc in stanga sus 
                    if(forma_deplasata.X < (e.X - 20) || forma_deplasata.Y < (e.Y - 20)) {
                        am_apasat = false;// Disconect toolbar 
                        toolBar.Dock = DockStyle.None;
                        toolBar.Location = new Point(10, 10);
                        toolBar.Size = new Size(200, 45);
                        toolBar.BorderStyle = BorderStyle.FixedSingle;
                    }
                }
                else if(toolBar.Dock == DockStyle.None) {
                    toolBar.Left = e.X + toolBar.Left - forma_deplasata.X;
                    toolBar.Top = e.Y + toolBar.Top - forma_deplasata.Y;
                    if(toolBar.Top < 5 || toolBar.Top > this.Size.Height - 20) {
                        am_apasat = false;
                        toolBar.Dock = DockStyle.Top;
                        toolBar.BorderStyle = BorderStyle.Fixed3D;
                    }
                    else if(toolBar.Left < 5 || toolBar.Left > this.Size.Width - 20) {
                        am_apasat = false;
                        toolBar.Dock = DockStyle.Left;
                        toolBar.BorderStyle = BorderStyle.Fixed3D;
                    }
                }
            }
        }
    }
}
