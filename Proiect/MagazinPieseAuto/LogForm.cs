using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MagazinPieseAuto {
    public partial class LogForm : Form {
        public LogForm() {
            InitializeComponent();
            LoadLog();
        }

        private void LoadLog() {
            var conn = Database.GetConnection();
            var cmd = new MySqlCommand(@"
        SELECT 
            la.data_ora     AS DataOra,
            u.username      AS Utilizator,
            u.role          AS Rol,
            la.actiune      AS Actiune,
            la.comanda_sql  AS ComandaSQL
        FROM LogActiuni la
        LEFT JOIN Users u ON la.id_user = u.id_user
        ORDER BY la.data_ora DESC
    ", conn);

            var adapter = new MySqlDataAdapter(cmd);
            var table = new DataTable();
            adapter.Fill(table);
            dgvLog.DataSource = table;
        }


        private void btnRefreshLog_Click(object sender, EventArgs e) {
            LoadLog();
        }
    }
}
