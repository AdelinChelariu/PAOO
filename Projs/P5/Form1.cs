using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void button1_Click(object source, System.EventArgs e) {
            String s = "Am selectat si am adaugat itemii: ";
            listBox1.Items.Clear();
            foreach(object c in checkedListBox1.CheckedItems) {
                listBox1.Items.Add(c);
                s = s + c.ToString();
                s = s + " ";
            }
            label1.Text = s;
            if(s == "Am selectat si am adaugat itemii: ")
                label1.Visible = false;
            else
                label1.Visible = true;
        }
    }
}
