using System;
using System.Data;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Wpf;
using MySql.Data.MySqlClient;

namespace MagazinPieseAuto {
    public partial class ChartPanelForm : Form {
        public ChartPanelForm(DateTime start, DateTime end) {
            InitializeComponent();
            var dt = LoadCategorySales(start, end);
            SetupBarChart(dt);
            SetupPieChart(dt);
        }

        private DataTable LoadCategorySales(DateTime s, DateTime e) {
            const string sql = @"
                SELECT c.nume_categorie AS Categorie,
                       SUM(dc.cantitate*dc.pret_unitar) AS TotalVanzari
                FROM DetaliiComenzi dc
                JOIN Comenzi co ON dc.id_comanda=co.id_comanda
                JOIN PieseAuto p ON dc.id_piesa=p.id_piesa
                JOIN CategoriiPiese c ON p.id_categorie=c.id_categorie
                WHERE co.data_comanda BETWEEN @s AND @e
                GROUP BY c.nume_categorie
                ORDER BY TotalVanzari DESC";
            var dt = new DataTable();
            using(var conn = Database.GetConnection())
            using(var cmd = new MySqlCommand(sql, conn)) {
                cmd.Parameters.AddWithValue("@s", s);
                cmd.Parameters.AddWithValue("@e", e);
                new MySqlDataAdapter(cmd).Fill(dt);
            }
            return dt;
        }

        private void SetupBarChart(DataTable dt) {
            var values = new ChartValues<double>();
            var labels = new string[dt.Rows.Count];
            for(int i = 0; i < dt.Rows.Count; i++) {
                labels[i] = dt.Rows[i]["Categorie"].ToString();
                values.Add(Convert.ToDouble(dt.Rows[i]["TotalVanzari"]));
            }
            cartesianChart1.Series = new SeriesCollection
            {
                new ColumnSeries{ Title="Vânzări", Values=values }
            };
            cartesianChart1.AxisX.Clear();
            cartesianChart1.AxisX.Add(new Axis { Labels = labels, Title = "Categorie" });
            cartesianChart1.AxisY.Clear();
            cartesianChart1.AxisY.Add(new Axis { Title = "Total Vânzări", LabelFormatter = val => val.ToString("N2") });
        }

        private void SetupPieChart(DataTable dt) {
            pieChart1.Series = new SeriesCollection();
            foreach(DataRow row in dt.Rows) {
                pieChart1.Series.Add(new PieSeries {
                    Title = row["Categorie"].ToString(),
                    Values = new ChartValues<double> { Convert.ToDouble(row["TotalVanzari"]) },
                    DataLabels = true
                });
            }
        }
    }
}
