using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MagazinPieseAuto {
    public partial class RegistrationForm : Form {
        public RegistrationForm() {
            InitializeComponent();

            // Role
            cbRegRole.Items.AddRange(new object[] { "Client", "Angajat" });
            cbRegRole.SelectedIndex = 1;
            cbRegRole.SelectedIndexChanged += (s, e) => TogglePanels();

            // Load departamente / functii
            LoadCombo("SELECT id_dept,nume_dept FROM Departamente", cbEmpDept, "nume_dept", "id_dept");
            LoadCombo("SELECT id_functie,nume_functie FROM Functii", cbEmpFunc, "nume_functie", "id_functie");
        }

        private void TogglePanels() {
            bool isClient = cbRegRole.SelectedItem.ToString().ToUpper() == "CLIENT";
            grpClient.Visible = isClient;
            grpEmployee.Visible = !isClient;
        }

        private void LoadCombo(string sql, ComboBox cb, string disp, string val) {
            var dt = new DataTable();
            using(var conn = Database.GetConnection())
            using(var cmd = new MySqlCommand(sql, conn))
            using(var rdr = cmd.ExecuteReader())
                dt.Load(rdr);
            cb.DisplayMember = disp;
            cb.ValueMember = val;
            cb.DataSource = dt;
        }

        private void btnRegOK_Click(object sender, EventArgs e) {
            // date de bază
            var user = txtRegUsername.Text.Trim();
            var pass = txtRegPassword.Text.Trim();
            var role = (cbRegRole.SelectedItem.ToString() == "Client") ? "CLIENT" : "EMPLOYEE";
            if(string.IsNullOrEmpty(user) || string.IsNullOrEmpty(pass)) {
                MessageBox.Show("Completează username şi parolă.");
                return;
            }

            using(var conn = Database.GetConnection())
            using(var tx = conn.BeginTransaction()) {
                // 1) INSERT Users
                var cmd1 = new MySqlCommand(
                    "INSERT INTO Users(username,password,role) VALUES(@u,@p,@r)", conn, tx);
                cmd1.Parameters.AddWithValue("@u", user);
                cmd1.Parameters.AddWithValue("@p", pass);
                cmd1.Parameters.AddWithValue("@r", role);
                cmd1.ExecuteNonQuery();
                int newId = (int)cmd1.LastInsertedId;
                LogService.LogAction(
    LoginForm.userId,
    "Înregistrare utilizator",
    cmd1.CommandText);

                if(role == "CLIENT") {
                    // INSERT Clienti
                    var cmd2 = new MySqlCommand(
                      @"INSERT INTO Clienti(id_client,nume,prenume,telefon,email)
                        VALUES(@id,@n,@pr,@tel,@mail)", conn, tx);
                    cmd2.Parameters.AddWithValue("@id", newId);
                    cmd2.Parameters.AddWithValue("@n", txtClientNume.Text.Trim());
                    cmd2.Parameters.AddWithValue("@pr", txtClientPrenume.Text.Trim());
                    cmd2.Parameters.AddWithValue("@tel", txtClientTelefon.Text.Trim());
                    cmd2.Parameters.AddWithValue("@mail", txtClientEmail.Text.Trim());
                    cmd2.ExecuteNonQuery();
                    LogService.LogAction(
    LoginForm.userId,
    "Creare client",
    cmd2.CommandText);
                }
                else {
                    // INSERT Angajati
                    var cmd2 = new MySqlCommand(
                      @"INSERT INTO Angajati
                        (id_angajat,id_dept,id_functie,data_angajare,salariu)
                        VALUES(@id,@dept,@func,@date,@sal)", conn, tx);
                    cmd2.Parameters.AddWithValue("@id", newId);
                    cmd2.Parameters.AddWithValue("@dept", cbEmpDept.SelectedValue);
                    cmd2.Parameters.AddWithValue("@func", cbEmpFunc.SelectedValue);
                    cmd2.Parameters.AddWithValue("@date", dtpEmpHire.Value.Date);
                    cmd2.Parameters.AddWithValue("@sal", (double)nudEmpSalary.Value);
                    cmd2.ExecuteNonQuery();
                    LogService.LogAction(
     LoginForm.userId,
    "Creare angajat",
    cmd2.CommandText);
                }

                tx.Commit();
            }

            MessageBox.Show("Înregistrare reușită!");
            this.Close();
        }

        private void btnRegCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
