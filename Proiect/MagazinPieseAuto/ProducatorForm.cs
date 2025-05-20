using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MagazinPieseAuto {
    public partial class ProducatorForm : Form {
        public ProducatorForm() {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e) {
            var nume = txtNumeProd.Text.Trim();
            if(string.IsNullOrEmpty(nume)) {
                MessageBox.Show("Completează numele producătorului.",
                                "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using(var conn = Database.GetConnection())
            using(var cmd = new MySqlCommand(
                "INSERT INTO Producatori (nume_producator) VALUES (@nume)", conn)) {
                cmd.Parameters.AddWithValue("@nume", nume);
                cmd.ExecuteNonQuery();
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
