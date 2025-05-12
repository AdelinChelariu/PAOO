using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MagazinPieseAuto {
    public partial class MainForm : Form {
        private readonly int _userId;
        private readonly string _username;
        private readonly string _role;

        // Constructorul care primește parametrii din LoginForm
        public MainForm(int userId, string username, string role) {
            InitializeComponent();

            _userId = userId;
            _username = username;
            _role = role;

            // Exemplu: afișăm rolul și username-ul într-un label
            lblWelcome.Text = $"Bun venit, {_username} ({_role})";

            // Dacă e client, ascundem butoane de admin
            if(_role == "CLIENT") {
                btnAdminPanel.Visible = false;
            }
        }
        private void LoadPiese() {
            using(var conn = Database.GetConnection())
            using(var adapter = new MySqlDataAdapter(
                @"SELECT p.id_piesa, p.denumire, p.producator, p.stoc, p.pret,
                         c.nume_categorie, pr.nume_producator
                  FROM PieseAuto p
                  LEFT JOIN CategoriiPiese c ON p.id_categorie = c.id_categorie
                  LEFT JOIN Producatori pr ON p.id_producator = pr.id_producator", conn)) {
                var table = new DataTable();
                adapter.Fill(table);
                dgvPieseAuto.DataSource = table;

                // Ascunde coloana id_piesa
                if(dgvPieseAuto.Columns["id_piesa"] != null)
                    dgvPieseAuto.Columns["id_piesa"].Visible = false;
            }
        }

        private int? GetSelectedPiesaId() {
            if(dgvPieseAuto.CurrentRow == null)
                return null;
            return Convert.ToInt32(dgvPieseAuto.CurrentRow.Cells["id_piesa"].Value);
        }

        private void btnAddPiesa_Click(object sender, EventArgs e) {
            using(var form = new PiesaForm()) {
                if(form.ShowDialog() == DialogResult.OK)
                    LoadPiese();
            }
        }

        private void btnEditPiesa_Click(object sender, EventArgs e) {
            var id = GetSelectedPiesaId();
            if(id == null) {
                MessageBox.Show("Selectează mai întâi o piesă.");
                return;
            }

            using(var form = new PiesaForm(id.Value)) {
                if(form.ShowDialog() == DialogResult.OK)
                    LoadPiese();
            }
        }

        private void btnDeletePiesa_Click(object sender, EventArgs e) {
            var id = GetSelectedPiesaId();
            if(id == null) {
                MessageBox.Show("Selectează mai întâi o piesă.");
                return;
            }

            if(MessageBox.Show("Ștergi piesa selectată?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                == DialogResult.Yes) {
                using(var conn = Database.GetConnection())
                using(var cmd = new MySqlCommand(
                    "DELETE FROM PieseAuto WHERE id_piesa = @id", conn)) {
                    cmd.Parameters.AddWithValue("@id", id.Value);
                    cmd.ExecuteNonQuery();
                    LoadPiese();
                }
            }
        }
    }
}
