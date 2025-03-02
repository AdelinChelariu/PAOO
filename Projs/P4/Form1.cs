using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void etichetaC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            etichetaC.LinkVisited = true;
            System.Diagnostics.Process.Start(@"C:\");
        }

        private void etichetaI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            etichetaI.LinkVisited = true;
            System.Diagnostics.Process.Start("https://tinyurl.com/ymxmwjdm");
        }

        private void etichetaN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            etichetaN.LinkVisited = true;
            System.Diagnostics.Process.Start("notepad");
        }
    }
}
