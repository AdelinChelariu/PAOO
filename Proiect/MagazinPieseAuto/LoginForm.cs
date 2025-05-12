using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace MagazinPieseAuto {
    public partial class LoginForm : Form {
        public LoginForm() {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e) {
            var username = txtUsername.Text.Trim();
            var password = txtPassword.Text.Trim();

            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password)) {
                lblStatus.Text = "Completează username și parolă.";
                return;
            }

            using(var conn = Database.GetConnection()) {
                const string query =
                    "SELECT id_user, role FROM Users " +
                    "WHERE username = @user AND password = @pass";

                using(var cmd = new MySqlCommand(query, conn)) {
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);

                    using(var reader = cmd.ExecuteReader()) {
                        if(reader.Read()) {
                            var userId = reader.GetInt32("id_user");
                            var role = reader.GetString("role");

                            // Ascunde login și deschide MainForm
                            this.Hide();
                            var main = new MainForm(userId, username, role);
                            main.Show();
                        }
                        else {
                            lblStatus.Text = "Credentiale invalide.";
                        }
                    }
                }
            }
        }
    }
}
