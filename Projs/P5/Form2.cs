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

namespace P5
{
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
            PopulateCheckedListBox();
        }

        private void PopulateCheckedListBox() {
            checkedListBox1.Items.Add(".txt", false);
            checkedListBox1.Items.Add(".pdf", false);
            checkedListBox1.Items.Add(".docx", false);
            checkedListBox1.Items.Add(".xlsx", false);
            checkedListBox1.Items.Add(".jpg", false);
            checkedListBox1.Items.Add(".png", false);
        }

        private void FilterFiles(string folderPath) {
            listBox1.Items.Clear();

            var selectedExtensions = checkedListBox1.CheckedItems.Cast<string>().ToList();

            if(selectedExtensions.Count == 0) {
                MessageBox.Show("Selectați cel puțin un tip de fișier!", "Avertizare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else {
                var files = Directory.GetFiles(folderPath)
                                     .Where(f => selectedExtensions.Contains(Path.GetExtension(f)))
                                     .ToList();

                if(files.Count == 0) {
                    listBox1.Items.Add("Niciun fișier găsit.");
                }
                else {
                    listBox1.Items.AddRange(files.ToArray());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            using(FolderBrowserDialog folderDialog = new FolderBrowserDialog()) {
                if(folderDialog.ShowDialog() == DialogResult.OK) {
                    string selectedPath = folderDialog.SelectedPath;
                    FilterFiles(selectedPath);
                }
            }
        }
    }
}
