using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e) {
            this.label1.Text = "Interval selectat: Start = " + e.Start.ToShortDateString() + " : End = " + e.End.ToShortDateString();
            if(e.Start.ToShortDateString() == e.End.ToShortDateString()) {
                String x = e.Start.ToShortDateString();
                if(!(comboBox1.Items.Contains(x)))
                    comboBox1.Items.Add(e.End.ToShortDateString());
            }
        }
    }
}
