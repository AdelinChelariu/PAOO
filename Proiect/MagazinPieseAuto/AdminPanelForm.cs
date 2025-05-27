using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using LiveCharts.WinForms;
using LiveCharts;
using LiveCharts.Wpf;

namespace MagazinPieseAuto {
    public partial class AdminPanelForm : Form {
        private readonly int _userId;
        private readonly string _username;

        public AdminPanelForm(int userId, string username) {
            InitializeComponent();
            _userId = userId;
            _username = username;

            // Inițializări
            InitReportsTab();
            InitChartsTab();
            InitEmployeesTab();
        }

        // === TAB Rapoarte ===
        private void InitReportsTab() {
            dtpRptStart.Value = DateTime.Today.AddDays(-30);
            dtpRptEnd.Value = DateTime.Today;
            cbRptBy.Items.AddRange(new object[] { "Categorie", "Client" });
            cbRptBy.SelectedIndex = 0;
        }

        private void btnRptGenerate_Click(object sender, EventArgs e) {
            // Similar cu MainForm.btnGenerateReport_Click,
            // dar populăm dgvRpt
            var start = dtpRptStart.Value.Date;
            var end = dtpRptEnd.Value.Date;
            if(end < start) { MessageBox.Show("Perioadă invalidă"); return; }

            string by = cbRptBy.SelectedItem.ToString();
            string sql = by == "Categorie"
                ? @"SELECT c.nume_categorie AS Categorie,
                           SUM(dc.cantitate*dc.pret_unitar) AS TotalVanzari
                    FROM DetaliiComenzi dc
                     JOIN Comenzi co ON dc.id_comanda=co.id_comanda
                     JOIN PieseAuto p ON dc.id_piesa=p.id_piesa
                     JOIN CategoriiPiese c ON p.id_categorie=c.id_categorie
                    WHERE co.data_comanda BETWEEN @start AND @end
                    GROUP BY c.id_categorie, c.nume_categorie
                    ORDER BY TotalVanzari DESC"
                : @"SELECT cl.nume AS NumeClient, cl.prenume AS PrenumeClient,
                           SUM(dc.cantitate*dc.pret_unitar) AS TotalVanzari
                    FROM DetaliiComenzi dc
                     JOIN Comenzi co ON dc.id_comanda=co.id_comanda
                     JOIN Clienti cl ON co.id_client=cl.id_client
                    WHERE co.data_comanda BETWEEN @start AND @end
                    GROUP BY cl.id_client, cl.nume, cl.prenume
                    ORDER BY TotalVanzari DESC";

            var dt = new DataTable();
            using(var conn = Database.GetConnection())
            using(var cmd = new MySqlCommand(sql, conn)) {
                cmd.Parameters.AddWithValue("@start", start);
                cmd.Parameters.AddWithValue("@end", end);
                new MySqlDataAdapter(cmd).Fill(dt);
            }
            dgvRpt.DataSource = dt;
        }

        // === TAB Grafice ===
        private void InitChartsTab() {
            dtpGfxStart.Value = DateTime.Today.AddDays(-30);
            dtpGfxEnd.Value = DateTime.Today;
        }

        private void btnGfxShow_Click(object sender, EventArgs e) {
            // Deschide ChartForm cu perioada selectată
            var start = dtpGfxStart.Value.Date;
            var end = dtpGfxEnd.Value.Date;
            using(var cf = new ChartPanelForm(start, end))
                cf.ShowDialog(this);
        }

        // === TAB Angajați ===
        private void InitEmployeesTab() {
            // Role fixe
            cbEmpRole.Items.AddRange(new object[] { "CLIENT", "EMPLOYEE" });
            cbEmpRole.SelectedIndex = 1;

            // Încărcăm departamente și funcții
            LoadCombo("SELECT id_dept,nume_dept FROM Departamente",
                      cbEmpDept, "nume_dept", "id_dept");

            LoadCombo("SELECT id_functie,nume_functie FROM Functii",
                      cbEmpFunc, "nume_functie", "id_functie");
        }

        private void LoadCombo(string sql, ComboBox cb,
                               string display, string value) {
            var dt = new DataTable();
            using(var conn = Database.GetConnection())
            using(var cmd = new MySqlCommand(sql, conn))
            using(var rdr = cmd.ExecuteReader())
                dt.Load(rdr);

            cb.DisplayMember = display;
            cb.ValueMember = value;
            cb.DataSource = dt;
        }

        private void btnEmpAdd_Click(object sender, EventArgs e) {
            // 1) Creăm user în tabela Users
            var username = txtEmpUsername.Text.Trim();
            var password = txtEmpPassword.Text.Trim();
            var role = cbEmpRole.SelectedItem.ToString();
            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) {
                MessageBox.Show("Completează username și parolă.");
                return;
            }

            using(var conn = Database.GetConnection())
            using(var tx = conn.BeginTransaction()) {
                // INSERT Users
                var cmd1 = new MySqlCommand(
                    "INSERT INTO Users(username,password,role) " +
                    "VALUES(@user,@pass,@role)", conn, tx);
                cmd1.Parameters.AddWithValue("@user", username);
                cmd1.Parameters.AddWithValue("@pass", password);
                cmd1.Parameters.AddWithValue("@role", role);
                cmd1.ExecuteNonQuery();

                // preluăm id-ul nou creat
                var newId = (int)cmd1.LastInsertedId;

                // INSERT Angajati
                var cmd2 = new MySqlCommand(
                    "INSERT INTO Angajati(id_angajat,id_dept,id_functie," +
                    "data_angajare,salariu) VALUES(@id,@dept,@fun,@date,@sal)",
                    conn, tx);
                cmd2.Parameters.AddWithValue("@id", newId);
                cmd2.Parameters.AddWithValue("@dept", cbEmpDept.SelectedValue);
                cmd2.Parameters.AddWithValue("@fun", cbEmpFunc.SelectedValue);
                cmd2.Parameters.AddWithValue("@date", dtpEmpHire.Value.Date);
                cmd2.Parameters.AddWithValue("@sal", (double)nudEmpSalary.Value);
                cmd2.ExecuteNonQuery();

                tx.Commit();
            }

            MessageBox.Show("Angajat adăugat cu succes!");
            // (Opțional) reîncarcă lista în dgvEmployees
        }
    }
}
