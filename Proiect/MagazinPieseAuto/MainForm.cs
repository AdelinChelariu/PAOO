using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MagazinPieseAuto {
    public partial class MainForm : Form {
        private readonly int _userId;
        private readonly string _username;
        private readonly string _role;

        public MainForm(int userId, string username, string role) {
            InitializeComponent();

            _userId = userId;
            _username = username;
            _role = role;

            // Exemplu: afișăm rolul și username-ul într-un label
            lblWelcome.Text = $"Bun venit, {_username}, rolul tau: {_role}";

            // Dacă e client, ascundem butoane de admin
            if(_role == "CLIENT") {
                btnAdminPanel.Visible = false;
                btnAddPiesa.Visible = false;
                btnAddProducator.Visible = false;
                btnEditPiesa.Visible = false;
                btnDeletePiesa.Visible = false;
            }
        }

        private void LoadPiese(string search = "",
                                int prodId = 0,
                                double priceMin = 0,
                                double priceMax = double.MaxValue,
                                int stockMin = 0,
                                string orderBy = "p.denumire",
                                string orderDir = "ASC") {
            LoadProducatoriFilter();
            var sql = @"SELECT p.id_piesa, p.denumire, p.producator, p.stoc, p.pret,
                        c.nume_categorie, pr.nume_producator
                        FROM PieseAuto p
                        LEFT JOIN CategoriiPiese c ON p.id_categorie = c.id_categorie
                        LEFT JOIN Producatori pr ON p.id_producator = pr.id_producator
                        WHERE (p.denumire LIKE @search OR p.producator LIKE @search)
                        AND p.pret BETWEEN @pmin AND @pmax
                        AND p.stoc >= @smin";

            if(prodId > 0)
                sql += " AND p.id_producator = @prod";

            // Adaugă ORDER BY din parametri
            sql += $" ORDER BY {orderBy} {orderDir}";

            using(var conn = Database.GetConnection())
            using(var cmd = new MySqlCommand(sql, conn)) {
                cmd.Parameters.AddWithValue("@search", $"%{search}%");
                cmd.Parameters.AddWithValue("@pmin", priceMin);
                cmd.Parameters.AddWithValue("@pmax", priceMax);
                cmd.Parameters.AddWithValue("@smin", stockMin);
                if(prodId > 0)
                    cmd.Parameters.AddWithValue("@prod", prodId);

                using(var adapter = new MySqlDataAdapter(cmd)) {
                    var table = new DataTable();
                    adapter.Fill(table);
                    dgvPieseAuto.DataSource = table;
                    dgvPieseAuto.AllowUserToAddRows = false;
                    dgvPieseAuto.RowHeadersVisible = false;
                    if(dgvPieseAuto.Columns["id_piesa"] != null)
                        dgvPieseAuto.Columns["id_piesa"].Visible = false;
                }
            }
        }



        private void LoadProducatoriFilter() {
            using(var conn = Database.GetConnection())
            using(var cmd = new MySqlCommand(
                "SELECT id_producator, nume_producator FROM Producatori", conn))
            using(var reader = cmd.ExecuteReader()) {
                var dt = new DataTable();
                dt.Load(reader);
                var allRow = dt.NewRow();
                allRow["id_producator"] = 0;
                allRow["nume_producator"] = "-- Toți --";
                dt.Rows.InsertAt(allRow, 0);

                cbFilterProducer.DisplayMember = "nume_producator";
                cbFilterProducer.ValueMember = "id_producator";
                cbFilterProducer.DataSource = dt;
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

        private void MainForm_Load(object sender, EventArgs e) {
            LoadProducatoriFilter();
            dgvPieseAuto.RowHeadersVisible = false;
            LoadPiese();
        }

        private void btnAddProducator_Click(object sender, EventArgs e) {
            using(var form = new ProducatorForm()) {
                if(form.ShowDialog() == DialogResult.OK) {
                    LoadPiese();
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            LoadPiese(txtSearch.Text.Trim());
        }

        private void btnApplyFilter_Click(object sender, EventArgs e) {
            if(nudPriceMax.Value == 0)
                LoadPiese(txtSearch.Text.Trim(),
                    prodId: Convert.ToInt32(cbFilterProducer.SelectedValue),
                    priceMin: (double)nudPriceMin.Value,
                    priceMax: (double)nudPriceMax.Maximum,
                    stockMin: (int)nudStockMin.Value);
            else
                LoadPiese(txtSearch.Text.Trim(),
                    prodId: Convert.ToInt32(cbFilterProducer.SelectedValue),
                    priceMin: (double)nudPriceMin.Value,
                    priceMax: (double)nudPriceMax.Value,
                    stockMin: (int)nudStockMin.Value);
        }

        private void btnClearFilter_Click(object sender, EventArgs e) {
            txtSearch.Clear();
            nudPriceMin.Value = 0;
            nudPriceMax.Value = nudPriceMax.Maximum;
            nudStockMin.Value = 0;
            cbFilterProducer.SelectedIndex = 0;
            LoadPiese();
        }

        private void brnClearSearch_Click(object sender, EventArgs e) {
            txtSearch.Clear();
            LoadPiese();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) {
            LoadPiese(txtSearch.Text.Trim());
        }
    }
}
