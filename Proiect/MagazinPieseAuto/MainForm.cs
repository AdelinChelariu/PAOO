using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Linq;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using Org.BouncyCastle.Asn1.X500;

namespace MagazinPieseAuto {
    public partial class MainForm : Form {
        private readonly int _userId;
        private readonly string _username;
        private readonly string _role;
        private readonly Dictionary<int, int> _cart = new Dictionary<int, int>();


        public MainForm(int userId, string username, string role) {
            InitializeComponent();

            _userId = userId;
            _username = username;
            _role = role;

            // Exemplu: afișăm rolul și username-ul într-un label
            lblWelcome.Text = $"Bine ai venit, {_username}. Rolul tau: {_role}.";

            // Dacă e client, ascundem butoane de admin
            if(_role == "CLIENT") {
                btnAddPiesa.Visible = false;
                btnAddProducator.Visible = false;
                btnEditPiesa.Visible = false;
                btnDeletePiesa.Visible = false;
                gbRapoarte.Visible = false;
            }
            else {
                btnAddToCart.Visible = false;
                btnViewCart.Visible = false;
                this.btnAddPiesa.Location = new System.Drawing.Point(18, 396 + 26);
                this.btnEditPiesa.Location = new System.Drawing.Point(18, 422 + 26);
                this.btnDeletePiesa.Location = new System.Drawing.Point(131, 396 + 26);
                this.btnAddProducator.Location = new System.Drawing.Point(131, 422 + 26);
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
                        AND p.stoc >= @smin
                        AND p.stoc > 0
                        ";

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
            using(var form = new PiesaForm(_userId)) {
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

            using(var form = new PiesaForm(_userId, id.Value)) {
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
                    LogService.LogAction(
    LoginForm.userId,
    "Ștergere piesă",
    cmd.CommandText);
                    LoadPiese();
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e) {
            LoadProducatoriFilter();
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

        private void btnGenerateReport_Click(object sender, EventArgs e) {
            // 1) Construiește DataTable-ul exact ca înainte
            DateTime start = dtpStart.Value.Date;
            DateTime end = dtpEnd.Value.Date;
            if(end < start) {
                MessageBox.Show("Data de sfârșit trebuie să fie după data de început.",
                                "Perioadă invalidă", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string by = cbReportBy.SelectedItem.ToString();
            string sql;
            if(by == "Categorie") {
                sql = @"
            SELECT 
              c.nume_categorie AS Categorie,
              SUM(dc.cantitate * dc.pret_unitar) AS TotalVanzari
            FROM DetaliiComenzi dc
            JOIN Comenzi co ON dc.id_comanda = co.id_comanda
            JOIN PieseAuto p   ON dc.id_piesa    = p.id_piesa
            JOIN CategoriiPiese c ON p.id_categorie = c.id_categorie
            WHERE co.data_comanda BETWEEN @start AND @end
            GROUP BY c.id_categorie, c.nume_categorie
            ORDER BY TotalVanzari DESC";
            }
            else // Client
            {
                sql = @"
            SELECT 
              cl.nume AS NumeClient,
              cl.prenume AS PrenumeClient,
              SUM(dc.cantitate * dc.pret_unitar) AS TotalVanzari
            FROM DetaliiComenzi dc
            JOIN Comenzi co ON dc.id_comanda = co.id_comanda
            JOIN Clienti cl ON co.id_client  = cl.id_client
            WHERE co.data_comanda BETWEEN @start AND @end
            GROUP BY cl.id_client, cl.nume, cl.prenume
            ORDER BY TotalVanzari DESC";
            }

            DataTable reportTable = new DataTable();
            using(var conn = Database.GetConnection())
            using(var cmd = new MySqlCommand(sql, conn)) {
                cmd.Parameters.AddWithValue("@start", start);
                cmd.Parameters.AddWithValue("@end", end);
                using(var adapter = new MySqlDataAdapter(cmd)) {
                    adapter.Fill(reportTable);
                }
            }

            // 2) Deschide noul formular cu datele
            using(var rpt = new ReportForm(reportTable, $"Raport vânzări pe {(by == "Categorie" ? "categorii" : "clienți")}")) {
                rpt.Show(this);
            }
        }

        private void btnShowCharts_Click(object sender, EventArgs e) {
            var start = dtpStart.Value.Date;
            var end = dtpEnd.Value.Date;
            using(var f = new ChartPanelForm(start, end))
                f.Show(this);
        }


        private void btnLogout_Click(object sender, EventArgs e) {
            this.Hide();

            var login = new LoginForm();
            login.Show();

            this.Close();
        }

        private void btnAddToCart_Click(object sender, EventArgs e) {
            var id = GetSelectedPiesaId();
            if(id == null) {
                MessageBox.Show("Selectează mai întâi o piesă.");
                return;
            }

            // preluăm stocul din grilă
            int stock = Convert.ToInt32(dgvPieseAuto.CurrentRow.Cells["stoc"].Value);
            int currentQty = _cart.ContainsKey(id.Value) ? _cart[id.Value] : 0;

            if(currentQty >= stock) {
                MessageBox.Show("Nu poți adăuga mai multe decât stocul disponibil.");
                return;
            }
            string productName = dgvPieseAuto.CurrentRow.Cells["denumire"].Value.ToString();

            _cart[id.Value] = currentQty + 1;
            MessageBox.Show($"\"{productName}\" adăugat în coș. Cantitate în coș: {_cart[id.Value]}");
        }

        private void btnViewCart_Click(object sender, EventArgs e) {
            if(_cart.Count == 0) {
                MessageBox.Show("Coșul este gol.");
                return;
            }

            using(var cartForm = new CartForm(_cart, _userId)) {
                if(cartForm.ShowDialog(this) == DialogResult.OK) {
                    // după cumpărare, golim coșul și reîncărcăm lista
                    _cart.Clear();
                    LoadPiese();  // opțional poţi filtra piese cu stoc>0
                }
            }
        }

        private void btnExportProducts_Click(object sender, EventArgs e) {
            if(dgvPieseAuto.Rows.Count == 0) {
                MessageBox.Show("Nu există produse de exportat.", "Export PDF",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using(var sfd = new SaveFileDialog()) {
                sfd.Filter = "PDF files (*.pdf)|*.pdf";
                sfd.FileName = "Catalog_Piese.pdf";
                if(sfd.ShowDialog() != DialogResult.OK)
                    return;

                using(var fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write))
                using(var doc = new Document(PageSize.A4.Rotate(), 40, 40, 40, 40))
                using(var writer = PdfWriter.GetInstance(doc, fs)) {
                    doc.Open();
                    // Titlu
                    var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 14);
                    doc.Add(new Paragraph("Catalog Piese Auto", titleFont));
                    doc.Add(new Paragraph($"Data: {DateTime.Now:dd.MM.yyyy HH:mm}"));
                    doc.Add(Chunk.NEWLINE);

                    // Construire tabel cu headerele din coloane vizibile
                    var visibleCols = dgvPieseAuto.Columns
                                          .Cast<DataGridViewColumn>()
                                          .Where(c => c.Visible)
                                          .ToList();
                    var table = new PdfPTable(visibleCols.Count) { WidthPercentage = 100 };

                    // Header
                    foreach(var col in visibleCols) {
                        var cell = new PdfPCell(new Phrase(col.HeaderText,
                                          FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))) {
                            BackgroundColor = BaseColor.LIGHT_GRAY,
                            HorizontalAlignment = Element.ALIGN_CENTER
                        };
                        table.AddCell(cell);
                    }

                    // Rânduri
                    foreach(DataGridViewRow row in dgvPieseAuto.Rows) {
                        foreach(var col in visibleCols) {
                            var val = row.Cells[col.Index].Value?.ToString() ?? "";
                            var cell = new PdfPCell(new Phrase(val,
                                              FontFactory.GetFont(FontFactory.HELVETICA, 10))) {
                                HorizontalAlignment = Element.ALIGN_LEFT
                            };
                            table.AddCell(cell);
                        }
                    }

                    doc.Add(table);
                    doc.Close();
                }

                MessageBox.Show("PDF creat cu succes!", "Export PDF",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExportXls_Click(object sender, EventArgs e) {
            if(dgvPieseAuto.Rows.Count == 0) {
                MessageBox.Show("Nu există produse de exportat.",
                                "Export XLS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using(var sfd = new SaveFileDialog()) {
                sfd.Filter = "Excel files (*.xlsx)|*.xlsx";
                sfd.FileName = "Catalog_Piese.xlsx";
                if(sfd.ShowDialog() != DialogResult.OK)
                    return;

                // setare licență EPPlus
                ExcelPackage.License.SetNonCommercialPersonal("ProiectPAOO");


                using(var package = new ExcelPackage()) {
                    var ws = package.Workbook.Worksheets.Add("PieseAuto");

                    var visibleCols = dgvPieseAuto.Columns
                                          .Cast<DataGridViewColumn>()
                                          .Where(c => c.Visible)
                                          .ToList();

                    // Header
                    for(int colIndex = 0; colIndex < visibleCols.Count; colIndex++) {
                        ws.Cells[1, colIndex + 1].Value = visibleCols[colIndex].HeaderText;
                        ws.Cells[1, colIndex + 1].Style.Font.Bold = true;
                        ws.Cells[1, colIndex + 1].Style.Fill.PatternType = ExcelFillStyle.Solid;
                        ws.Cells[1, colIndex + 1].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.LightGray);
                    }

                    // Date
                    for(int rowIndex = 0; rowIndex < dgvPieseAuto.Rows.Count; rowIndex++) {
                        var gridRow = dgvPieseAuto.Rows[rowIndex];
                        for(int colIndex = 0; colIndex < visibleCols.Count; colIndex++) {
                            var cell = gridRow.Cells[visibleCols[colIndex].Index];
                            ws.Cells[rowIndex + 2, colIndex + 1].Value = cell.Value;
                        }
                    }

                    ws.Cells[ws.Dimension.Address].AutoFitColumns();

                    var fi = new FileInfo(sfd.FileName);
                    package.SaveAs(fi);
                }

                MessageBox.Show("Excel creat cu succes!", "Export XLS",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnImportXls_Click(object sender, EventArgs e) {
            var ofd = new OpenFileDialog {
                Filter = "Excel files (*.xlsx;*.xls)|*.xlsx;*.xls"
            };
            if(ofd.ShowDialog() != DialogResult.OK)
                return;

            // EPPlus licență
            ExcelPackage.License.SetNonCommercialPersonal("MagazinPieseAuto Import");

            var package = new ExcelPackage(new FileInfo(ofd.FileName));
            var ws = package.Workbook.Worksheets.FirstOrDefault();
            if(ws == null) {
                MessageBox.Show("Fișierul nu conține niciun sheet.", "Import XLS",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Construim dicționarul headerelor (coloană → index)
            var headers = Enumerable.Range(ws.Dimension.Start.Column, ws.Dimension.End.Column)
                .ToDictionary(
                    c => ws.Cells[1, c].Text.Trim().ToLower(),
                    c => c,
                    StringComparer.OrdinalIgnoreCase
                );

            // Verificăm coloanele obligatorii
            foreach(var req in new[] { "denumire", "producator", "stoc", "pret", "nume_categorie", "nume_producator" })
                if(!headers.ContainsKey(req)) {
                    MessageBox.Show($"Lipsește coloana obligatorie “{req}”.",
                                    "Import XLS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            // Încarcăm în dicționare categoriile și producătorii existenți
            var catMap = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            var prodMap = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            using(var conn = Database.GetConnection()) {
                using(var cmd = new MySqlCommand("SELECT id_categorie, nume_categorie FROM CategoriiPiese", conn))
                using(var rdr = cmd.ExecuteReader()) {
                    while(rdr.Read())
                        catMap[rdr.GetString("nume_categorie")] = rdr.GetInt32("id_categorie");
                    rdr.Close();
                }

                using(var cmd = new MySqlCommand("SELECT id_producator, nume_producator FROM Producatori", conn))
                using(var rdr2 = cmd.ExecuteReader())
                    while(rdr2.Read())
                        prodMap[rdr2.GetString("nume_producator")] = rdr2.GetInt32("id_producator");
            }

            int startRow = ws.Dimension.Start.Row + 1;
            int endRow = ws.Dimension.End.Row;
            int processed = 0, errors = 0;

            using(var conn = Database.GetConnection()) {
                for(int r = startRow; r <= endRow; r++) {
                    try {
                        // Citim valorile din fișier
                        string den = ws.Cells[r, headers["denumire"]].Text.Trim();
                        string prodText = ws.Cells[r, headers["producator"]].Text.Trim();
                        int stoc = int.Parse(ws.Cells[r, headers["stoc"]].Text.Trim());
                        double pret = double.Parse(ws.Cells[r, headers["pret"]].Text.Trim());
                        string catName = ws.Cells[r, headers["nume_categorie"]].Text.Trim();
                        string prodName = ws.Cells[r, headers["nume_producator"]].Text.Trim();

                        // Obținem sau inserăm categoria
                        if(!catMap.TryGetValue(catName, out var catId)) {
                            var insCat = new MySqlCommand(
                                "INSERT INTO CategoriiPiese(nume_categorie) VALUES(@name)", conn);
                            insCat.Parameters.AddWithValue("@name", catName);
                            insCat.ExecuteNonQuery();
                            catId = (int)insCat.LastInsertedId;
                            catMap[catName] = catId;
                        }

                        // Obținem sau inserăm producătorul
                        if(!prodMap.TryGetValue(prodName, out var prodId)) {
                            var insProd = new MySqlCommand(
                                "INSERT INTO Producatori(nume_producator) VALUES(@name)", conn);
                            insProd.Parameters.AddWithValue("@name", prodName);
                            insProd.ExecuteNonQuery();
                            prodId = (int)insProd.LastInsertedId;
                            prodMap[prodName] = prodId;
                        }

                        // Upsert pe baza denumirii
                        var upd = new MySqlCommand(
                          @"UPDATE PieseAuto
                    SET producator    = @prodText,
                        stoc          = @stoc,
                        pret          = @pret,
                        id_categorie  = @catId,
                        id_producator = @prodId
                    WHERE denumire = @den", conn);
                        upd.Parameters.AddWithValue("@prodText", prodText);
                        upd.Parameters.AddWithValue("@stoc", stoc);
                        upd.Parameters.AddWithValue("@pret", pret);
                        upd.Parameters.AddWithValue("@catId", catId);
                        upd.Parameters.AddWithValue("@prodId", prodId);
                        upd.Parameters.AddWithValue("@den", den);

                        int affected = upd.ExecuteNonQuery();
                        LogService.LogAction(
    LoginForm.userId,
    "Import piesă din XLS (update)",
    upd.CommandText);
                        if(affected == 0) {
                            // Nu exista, inseram rând nou
                            var ins = new MySqlCommand(
                              @"INSERT INTO PieseAuto
                        (denumire, producator, stoc, pret, id_categorie, id_producator)
                        VALUES (@den, @prodText, @stoc, @pret, @catId, @prodId)", conn);
                            ins.Parameters.AddWithValue("@den", den);
                            ins.Parameters.AddWithValue("@prodText", prodText);
                            ins.Parameters.AddWithValue("@stoc", stoc);
                            ins.Parameters.AddWithValue("@pret", pret);
                            ins.Parameters.AddWithValue("@catId", catId);
                            ins.Parameters.AddWithValue("@prodId", prodId);
                            ins.ExecuteNonQuery();
                            LogService.LogAction(
    LoginForm.userId,
    "Import piesă din XLS (update)",
    upd.CommandText);
                        }

                        processed++;
                    } catch {
                        errors++;
                    }
                }
            }

            // Reîncărcăm grila și afișăm raport
            LoadPiese();
            MessageBox.Show(
                $"Import finalizat: {processed} produse procesate, {errors} erori.",
                "Import XLS", MessageBoxButtons.OK, MessageBoxIcon.Information
            );
        }

        private void btnViewLog_Click(object sender, EventArgs e) {
            var logForm = new LogForm();
            logForm.Show(this);
        }

    }
}
