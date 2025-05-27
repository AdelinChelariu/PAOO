using System;
using MySql.Data.MySqlClient;

namespace MagazinPieseAuto {
    public static class LogService {
        public static void LogAction(int userId, string action, string sqlCommand) {
            var conn = Database.GetConnection();
            var cmd = new MySqlCommand(
                @"INSERT INTO LogActiuni 
                   (id_user, actiune, comanda_sql, data_ora)
                  VALUES
                   (@uid, @act, @sql, @dt)", conn);
            cmd.Parameters.AddWithValue("@uid", userId);
            cmd.Parameters.AddWithValue("@act", action);
            cmd.Parameters.AddWithValue("@sql", sqlCommand);
            cmd.Parameters.AddWithValue("@dt", DateTime.Now);
            cmd.ExecuteNonQuery();
        }
    }
}
