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
            // Configureaza lista
            desene_animate.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            desene_animate.ImageSize = new System.Drawing.Size(60, 60);
            desene_animate.Images.Clear();
            string[] gif_uri = Directory.GetFiles("C:\\Imagini", "*.gif");
            // se construieste un obiect Imagine pentru fiecare fisier si se adauga la ImageList.
            foreach(string fisier_gif in gif_uri) {
                Bitmap desen = new Bitmap(fisier_gif);
                desene_animate.Images.Add(desen);
                pictureBox1.Image = desen;
            }
            Graphics g = this.CreateGraphics();
            // Deseneaza fiecare imagine utilizand metoda ImageList.Draw()
            for(int i = 0; i < desene_animate.Images.Count; i++)
                desene_animate.Draw(g, 60 + i * 60, 60, i);
            g.Dispose();
        }
    }
}
}
