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

namespace P6 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void contruieste_lista_Click(object sender, System.EventArgs e) {
            string[] gif_uri = Directory.GetFiles(@"C:\Imagini\", "*.gif");
            flowLayoutPanel1.Controls.Clear(); // folosim FlowLayoutPanel pentru afișare dinamică

            foreach(string fisier_gif in gif_uri) {
                PictureBox pb = new PictureBox();
                pb.Image = Image.FromFile(fisier_gif);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                pb.Size = new Size(60, 60);
                pb.Padding = new Padding(3);
                pb.Cursor = Cursors.Hand;
                pb.Tag = fisier_gif; // reținem calea fișierului în Tag
                pb.Click += pictureBox1_Click; // adăugăm eveniment Click
                flowLayoutPanel1.Controls.Add(pb);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            // Încarcă fișierele gif din folder
            string[] gif_uri = Directory.GetFiles(@"C:\Imagini\", "*.gif");

            if(gif_uri.Length > 0) {
                // Încarcă primul GIF animat în PictureBox
                pictureBox1.Image = Image.FromFile(gif_uri[0]);

                // Setează PictureBox-ul să afișeze animația
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            
        }

    }

        private void pictureBox1_Click(object sender, EventArgs e) {
            PictureBox pbSelectat = sender as PictureBox;
            if(pbSelectat != null && pbSelectat.Tag != null) {
                // Setează imaginea animată selectată în PictureBox-ul principal
                pictureBox1.Image = Image.FromFile(pbSelectat.Tag.ToString());
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}

