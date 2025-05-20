using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace MagazinPieseAuto {
    public partial class PiesaForm : Form {
        private readonly int? _idPiesa;

        public PiesaForm(int? idPiesa = null) {
            InitializeComponent();
            _idPiesa = idPiesa;
            LoadCategorii();
            LoadProducatori();

            if(_idPiesa.HasValue)
                LoadPiesa();
        }

        private void LoadCategorii() {
            using(var conn = Database.GetConnection())
            using(var cmd = new MySqlCommand(
                "SELECT id_categorie, nume_categorie FROM CategoriiPiese", conn))
            using(var reader = cmd.ExecuteReader()) {
                var dt = new DataTable();
                dt.Load(reader);
                cbCategorie.DisplayMember = "nume_categorie";
                cbCategorie.ValueMember = "id_categorie";
                cbCategorie.DataSource = dt;
            }
        }

        private void LoadProducatori() {
            using(var conn = Database.GetConnection())
            using(var cmd = new MySqlCommand(
                "SELECT id_producator, nume_producator FROM Producatori", conn))
            using(var reader = cmd.ExecuteReader()) {
                var dt = new DataTable();
                dt.Load(reader);
                cbProducator.DisplayMember = "nume_producator";
                cbProducator.ValueMember = "id_producator";
                cbProducator.DataSource = dt;
            }
        }

        private void LoadPiesa() {
            using(var conn = Database.GetConnection())
            using(var cmd = new MySqlCommand(
                @"SELECT denumire, stoc, pret,
                 id_categorie, id_producator
          FROM PieseAuto WHERE id_piesa = @id", conn)) {
                cmd.Parameters.AddWithValue("@id", _idPiesa.Value);
                using(var reader = cmd.ExecuteReader()) {
                    if(reader.Read()) {
                        txtDenumire.Text = reader.GetString("denumire");
                        nudStoc.Value = reader.GetInt32("stoc");
                        nudPret.Value = Convert.ToDecimal(reader.GetDouble("pret"));
                        cbCategorie.SelectedValue = reader.GetInt32("id_categorie");
                        cbProducator.SelectedValue = reader.GetInt32("id_producator");
                    }
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e) {
            // preia atât id-ul producătorului, cât și textul pentru coloana producator
            var prodId = (int)cbProducator.SelectedValue;
            var prodName = cbProducator.Text;

            using(var conn = Database.GetConnection()) {
                MySqlCommand cmd;
                if(_idPiesa.HasValue) {
                    cmd = new MySqlCommand(
                      @"UPDATE PieseAuto
                SET denumire      = @den,
                    producator    = @prodName,
                    stoc          = @stoc,
                    pret          = @pret,
                    id_categorie  = @cat,
                    id_producator = @prodId
                WHERE id_piesa = @id", conn);
                    cmd.Parameters.AddWithValue("@id", _idPiesa.Value);
                }
                else {
                    cmd = new MySqlCommand(
                      @"INSERT INTO PieseAuto
                (denumire, producator, stoc, pret, id_categorie, id_producator)
                VALUES
                (@den, @prodName, @stoc, @pret, @cat, @prodId)", conn);
                }

                cmd.Parameters.AddWithValue("@den", txtDenumire.Text.Trim());
                cmd.Parameters.AddWithValue("@prodName", prodName);
                cmd.Parameters.AddWithValue("@stoc", (int)nudStoc.Value);
                cmd.Parameters.AddWithValue("@pret", (double)nudPret.Value);
                cmd.Parameters.AddWithValue("@cat", (int)cbCategorie.SelectedValue);
                cmd.Parameters.AddWithValue("@prodId", prodId);

                cmd.ExecuteNonQuery();
            }

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
