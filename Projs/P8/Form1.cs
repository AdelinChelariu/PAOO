using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P8
{
    public partial class Form1: Form
    {
        
        public Form1()
        {
            InitializeComponent();
            ConstruiesteHeader();
        }
        private void ConstruiesteHeader() {
            ColumnHeader colHead;
            colHead = new ColumnHeader();
            colHead.Text = "Nume fisier";
            this.lista_fisiere.Columns.Add(colHead);
            colHead = new ColumnHeader();
            colHead.Text = "Dimensiune";
            this.lista_fisiere.Columns.Add(colHead);
            colHead = new ColumnHeader();
            colHead.Text = "Ultima accesare";
            this.lista_fisiere.Columns.Add(colHead);

            ListViewItem lvi;
            ListViewItem.ListViewSubItem lvsi;
            string radacina = @"D:/";
            this.calea_curenta.Text = radacina + "(Dublu Click pe folder)";
            DirectoryInfo dir = new DirectoryInfo(radacina);
            DirectoryInfo[] dirs = dir.GetDirectories();
            FileInfo[] files = dir.GetFiles();

            this.lista_fisiere.Items.Clear();
            this.lista_fisiere.BeginUpdate();

            foreach(DirectoryInfo fi in dirs) {
                lvi = new ListViewItem();
                lvi.Text = fi.Name;
                lvi.ImageIndex = 1;
                lvi.Tag = fi.FullName;
                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = "";
                lvi.SubItems.Add(lvsi);
                lvsi = new ListViewItem.ListViewSubItem();
                lvsi.Text = fi.LastAccessTime.ToString();
                lvi.SubItems.Add(lvsi);
                this.lista_fisiere.Items.Add(lvi);
            }
        }
    }
}
