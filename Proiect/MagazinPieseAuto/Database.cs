using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace MagazinPieseAuto {
    public static class Database {
        private const string ConnString =
            "server=localhost;user=root;password=Adelin2711;database=magazinpieseautopaoo;SslMode=none";

        public static MySqlConnection GetConnection() {
            var conn = new MySqlConnection(ConnString);
            try {
                conn.Open();
            } catch(MySqlException ex) {
                MessageBox.Show("Eroare conexiune DB: " + ex.Message,
                                "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return conn;
        }
    }
}
