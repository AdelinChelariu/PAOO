using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace MagazinPieseAuto {
    public partial class CartForm : Form {
        private Dictionary<int, int> _cart;
        private readonly int _userId;

        public CartForm(Dictionary<int, int> cart, int userId) {
            InitializeComponent();
            // clonăm dictionarul, ca să nu-l modificăm direct
            _cart = new Dictionary<int, int>(cart);
            _userId = userId;
            LoadCartItems();
        }

        private void LoadCartItems() {
            var table = new DataTable();
            table.Columns.Add("id_piesa", typeof(int));
            table.Columns.Add("Denumire", typeof(string));
            table.Columns.Add("Cantitate", typeof(int));
            table.Columns.Add("Preț unitar", typeof(double));
            table.Columns.Add("Subtotal", typeof(double));

            foreach(var kv in _cart) {
                int id = kv.Key;
                int qty = kv.Value;
                var conn = Database.GetConnection();
                var cmd = new MySqlCommand(
                    "SELECT denumire, pret FROM PieseAuto WHERE id_piesa=@id", conn);
                cmd.Parameters.AddWithValue("@id", id);
                var reader = cmd.ExecuteReader();
                if(reader.Read()) {
                    var den = reader.GetString("denumire");
                    var pret = reader.GetDouble("pret");
                    table.Rows.Add(id, den, qty, pret, qty * pret);
                }
            }

            dgvCart.DataSource = table;
            dgvCart.Columns["id_piesa"].Visible = false;
            UpdateTotalLabel();
        }

        private void UpdateTotalLabel() {
            double total = 0;
            foreach(DataGridViewRow row in dgvCart.Rows) {
                total += Convert.ToDouble(row.Cells["Subtotal"].Value);
            }
            lblTotal.Text = $"Total: {total:N2}";
        }


        private void btnCheckout_Click(object sender, EventArgs e) {
            // 1) La fel ca înainte: creezi Comenzi și DetaliiComenzi, actualizezi stocul...
            int newOrderId = CreateOrderAndDetails();

            // 2) După comanda reușită, generează PDF-ul
            GenerateInvoicePdf(newOrderId);

            MessageBox.Show("Cumpărare realizată cu succes!\nFactură salvată ca PDF.",
                            "Comandă finalizată", MessageBoxButtons.OK, MessageBoxIcon.Information);

            DialogResult = DialogResult.OK;
        }

        private int CreateOrderAndDetails() {
            double total = 0;
            foreach(DataGridViewRow row in dgvCart.Rows)
                total += Convert.ToDouble(row.Cells["Subtotal"].Value);

            int newOrderId;
            using(var conn = Database.GetConnection())
            using(var cmd = new MySqlCommand(
                "INSERT INTO Comenzi (id_client, data_comanda, valoare_totala) " +
                "VALUES (@cid, @date, @tot)", conn)) {
                cmd.Parameters.AddWithValue("@cid", _userId);
                cmd.Parameters.AddWithValue("@date", DateTime.Today);
                cmd.Parameters.AddWithValue("@tot", total);
                cmd.ExecuteNonQuery();
                newOrderId = (int)cmd.LastInsertedId;
                LogService.LogAction(
    _userId,
    "Creare comandă",
    cmd.CommandText);
            }

            foreach(DataGridViewRow row in dgvCart.Rows) {
                int id = Convert.ToInt32(row.Cells["id_piesa"].Value);
                int qty = Convert.ToInt32(row.Cells["Cantitate"].Value);
                double pret = Convert.ToDouble(row.Cells["Preț unitar"].Value);

                using(var conn = Database.GetConnection()) {
                    // Detaliu
                    using(var cmd = new MySqlCommand(
                        "INSERT INTO DetaliiComenzi (id_comanda, id_piesa, cantitate, pret_unitar) " +
                        "VALUES (@oid, @pid, @qty, @unit)", conn)) {
                        cmd.Parameters.AddWithValue("@oid", newOrderId);
                        cmd.Parameters.AddWithValue("@pid", id);
                        cmd.Parameters.AddWithValue("@qty", qty);
                        cmd.Parameters.AddWithValue("@unit", pret);
                        cmd.ExecuteNonQuery();
                        

                        // *** log pentru detaliu comandă ***
                        LogService.LogAction(
                            _userId,
                            "Adăugare detaliu comandă",
                            cmd.CommandText);

                    }
                    // Actualizare stoc
                    using(var cmd = new MySqlCommand(
                        "UPDATE PieseAuto SET stoc = stoc - @q WHERE id_piesa = @pid", conn)) {
                        cmd.Parameters.AddWithValue("@q", qty);
                        cmd.Parameters.AddWithValue("@pid", id);
                        cmd.ExecuteNonQuery();
                        LogService.LogAction(
    _userId,
    "Actualizare stoc după comandă",
    cmd.CommandText);
                    }
                }
            }

            return newOrderId;
        }

        private void GenerateInvoicePdf(int orderId) {
            // 1. Alege locația și numele fișierului
            using(var sfd = new SaveFileDialog()) {
                sfd.Filter = "PDF files (*.pdf)|*.pdf";
                sfd.FileName = $"Factura_{orderId}.pdf";
                if(sfd.ShowDialog() != DialogResult.OK)
                    return;

                // 2. Colectează datele comenzii și ale clientului
                string clientName = "";
                DateTime date;
                double total;

                // Client
                using(var conn = Database.GetConnection())
                using(var cmd = new MySqlCommand(
                    @"SELECT cl.nume, cl.prenume, co.data_comanda, co.valoare_totala 
              FROM Comenzi co
              JOIN Clienti cl ON co.id_client = cl.id_client
              WHERE co.id_comanda = @oid", conn)) {
                    cmd.Parameters.AddWithValue("@oid", orderId);
                    using(var reader = cmd.ExecuteReader()) {
                        reader.Read();
                        clientName = $"{reader.GetString("nume")} {reader.GetString("prenume")}";
                        date = reader.GetDateTime("data_comanda");
                        total = reader.GetDouble("valoare_totala");
                    }
                }

                // Detalii comenzi
                var items = new List<(string Denumire, int Cant, double Pret, double Sub)>();
                using(var conn = Database.GetConnection())
                using(var cmd = new MySqlCommand(
                    @"SELECT p.denumire, dc.cantitate, dc.pret_unitar
              FROM DetaliiComenzi dc
              JOIN PieseAuto p ON dc.id_piesa = p.id_piesa
              WHERE dc.id_comanda = @oid", conn)) {
                    cmd.Parameters.AddWithValue("@oid", orderId);
                    using(var reader = cmd.ExecuteReader())
                        while(reader.Read()) {
                            string den = reader.GetString("denumire");
                            int qty = reader.GetInt32("cantitate");
                            double pr = reader.GetDouble("pret_unitar");
                            items.Add((den, qty, pr, qty * pr));
                        }
                }

                // 3. Creează PDF cu iTextSharp
                using(var fs = new FileStream(sfd.FileName, FileMode.Create, FileAccess.Write))
                using(var doc = new Document(PageSize.A4, 40, 40, 40, 40))
                using(var writer = PdfWriter.GetInstance(doc, fs)) {
                    doc.Open();
                    // Titlu
                    var titleFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16);
                    doc.Add(new Paragraph($"Factura #{orderId}", titleFont));
                    doc.Add(new Paragraph($"Data: {date:dd.MM.yyyy}"));
                    doc.Add(new Paragraph($"Client: {clientName}"));
                    doc.Add(Chunk.NEWLINE);

                    // Tabel detalii
                    var table = new PdfPTable(4) { WidthPercentage = 100 };
                    table.SetWidths(new float[] { 50, 15, 15, 20 });
                    // Header
                    foreach(var hdr in new[] { "Produs", "Cantitate", "Preț Unitar", "Subtotal" }) {
                        var cell = new PdfPCell(new Phrase(hdr, FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))) {
                            HorizontalAlignment = Element.ALIGN_CENTER,
                            BackgroundColor = BaseColor.LIGHT_GRAY
                        };
                        table.AddCell(cell);
                    }
                    // Rânduri
                    foreach(var it in items) {
                        table.AddCell(new PdfPCell(new Phrase(it.Denumire)));
                        table.AddCell(new PdfPCell(new Phrase(it.Cant.ToString())) { HorizontalAlignment = Element.ALIGN_RIGHT });
                        table.AddCell(new PdfPCell(new Phrase(it.Pret.ToString("N2"))) { HorizontalAlignment = Element.ALIGN_RIGHT });
                        table.AddCell(new PdfPCell(new Phrase(it.Sub.ToString("N2"))) { HorizontalAlignment = Element.ALIGN_RIGHT });
                    }
                    // Total
                    var totCell = new PdfPCell(new Phrase("Total", FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))) {
                        Colspan = 3,
                        HorizontalAlignment = Element.ALIGN_RIGHT
                    };
                    table.AddCell(totCell);
                    table.AddCell(new PdfPCell(new Phrase(total.ToString("N2"), FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12))) {
                        HorizontalAlignment = Element.ALIGN_RIGHT
                    });

                    doc.Add(table);
                    doc.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void btnRemoveItem_Click(object sender, EventArgs e) {
            if(dgvCart.CurrentRow == null) {
                MessageBox.Show("Selectează mai întâi un produs din coș.",
                                "Eliminare", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(dgvCart.CurrentRow.Cells["id_piesa"].Value);

            // eliminăm complet produsul din dicționar
            if(_cart.ContainsKey(id))
                _cart.Remove(id);

            // reîncărcăm lista și totalul
            LoadCartItems();
        }

    }
}
