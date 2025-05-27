namespace MagazinPieseAuto {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.dgvPieseAuto = new System.Windows.Forms.DataGridView();
            this.btnAddPiesa = new System.Windows.Forms.Button();
            this.btnEditPiesa = new System.Windows.Forms.Button();
            this.btnDeletePiesa = new System.Windows.Forms.Button();
            this.btnAddProducator = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.filtre = new System.Windows.Forms.GroupBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.cbFilterProducer = new System.Windows.Forms.ComboBox();
            this.prodFilterLabel = new System.Windows.Forms.Label();
            this.nudStockMin = new System.Windows.Forms.NumericUpDown();
            this.stockFilterLabel = new System.Windows.Forms.Label();
            this.nudPriceMax = new System.Windows.Forms.NumericUpDown();
            this.pretMaxLabel = new System.Windows.Forms.Label();
            this.nudPriceMin = new System.Windows.Forms.NumericUpDown();
            this.pretMinLabel = new System.Windows.Forms.Label();
            this.btnClearSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnViewCart = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.gbRapoarte = new System.Windows.Forms.GroupBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbReportBy = new System.Windows.Forms.ComboBox();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnShowCharts = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnExportProducts = new System.Windows.Forms.Button();
            this.btnExportXls = new System.Windows.Forms.Button();
            this.btnImportXls = new System.Windows.Forms.Button();
            this.btnViewLog = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPieseAuto)).BeginInit();
            this.filtre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceMin)).BeginInit();
            this.gbRapoarte.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(23, 31);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(52, 13);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Bun venit";
            // 
            // dgvPieseAuto
            // 
            this.dgvPieseAuto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPieseAuto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPieseAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPieseAuto.Location = new System.Drawing.Point(280, 119);
            this.dgvPieseAuto.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPieseAuto.Name = "dgvPieseAuto";
            this.dgvPieseAuto.RowHeadersWidth = 82;
            this.dgvPieseAuto.RowTemplate.Height = 33;
            this.dgvPieseAuto.Size = new System.Drawing.Size(538, 352);
            this.dgvPieseAuto.TabIndex = 2;
            // 
            // btnAddPiesa
            // 
            this.btnAddPiesa.Location = new System.Drawing.Point(18, 396);
            this.btnAddPiesa.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPiesa.Name = "btnAddPiesa";
            this.btnAddPiesa.Size = new System.Drawing.Size(110, 23);
            this.btnAddPiesa.TabIndex = 3;
            this.btnAddPiesa.Text = "Adauga Produs";
            this.btnAddPiesa.UseVisualStyleBackColor = true;
            this.btnAddPiesa.Click += new System.EventHandler(this.btnAddPiesa_Click);
            // 
            // btnEditPiesa
            // 
            this.btnEditPiesa.Location = new System.Drawing.Point(18, 422);
            this.btnEditPiesa.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditPiesa.Name = "btnEditPiesa";
            this.btnEditPiesa.Size = new System.Drawing.Size(110, 23);
            this.btnEditPiesa.TabIndex = 4;
            this.btnEditPiesa.Text = "Editeaza Produs";
            this.btnEditPiesa.UseVisualStyleBackColor = true;
            this.btnEditPiesa.Click += new System.EventHandler(this.btnEditPiesa_Click);
            // 
            // btnDeletePiesa
            // 
            this.btnDeletePiesa.Location = new System.Drawing.Point(131, 422);
            this.btnDeletePiesa.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeletePiesa.Name = "btnDeletePiesa";
            this.btnDeletePiesa.Size = new System.Drawing.Size(110, 23);
            this.btnDeletePiesa.TabIndex = 5;
            this.btnDeletePiesa.Text = "Sterge Produs";
            this.btnDeletePiesa.UseVisualStyleBackColor = true;
            this.btnDeletePiesa.Click += new System.EventHandler(this.btnDeletePiesa_Click);
            // 
            // btnAddProducator
            // 
            this.btnAddProducator.Location = new System.Drawing.Point(131, 396);
            this.btnAddProducator.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProducator.Name = "btnAddProducator";
            this.btnAddProducator.Size = new System.Drawing.Size(110, 23);
            this.btnAddProducator.TabIndex = 6;
            this.btnAddProducator.Text = "Adauga Producator";
            this.btnAddProducator.UseVisualStyleBackColor = true;
            this.btnAddProducator.Click += new System.EventHandler(this.btnAddProducator_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(412, 88);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(160, 20);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Denumire / Producator";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(594, 86);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 23);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Cauta";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // filtre
            // 
            this.filtre.Controls.Add(this.btnClearFilter);
            this.filtre.Controls.Add(this.btnApplyFilter);
            this.filtre.Controls.Add(this.cbFilterProducer);
            this.filtre.Controls.Add(this.prodFilterLabel);
            this.filtre.Controls.Add(this.nudStockMin);
            this.filtre.Controls.Add(this.stockFilterLabel);
            this.filtre.Controls.Add(this.nudPriceMax);
            this.filtre.Controls.Add(this.pretMaxLabel);
            this.filtre.Controls.Add(this.nudPriceMin);
            this.filtre.Controls.Add(this.pretMinLabel);
            this.filtre.Location = new System.Drawing.Point(18, 89);
            this.filtre.Margin = new System.Windows.Forms.Padding(2);
            this.filtre.Name = "filtre";
            this.filtre.Padding = new System.Windows.Forms.Padding(2);
            this.filtre.Size = new System.Drawing.Size(223, 172);
            this.filtre.TabIndex = 10;
            this.filtre.TabStop = false;
            this.filtre.Text = "Filtrare";
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(130, 138);
            this.btnClearFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(80, 22);
            this.btnClearFilter.TabIndex = 9;
            this.btnClearFilter.Text = "Goleste filtre";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Location = new System.Drawing.Point(10, 138);
            this.btnApplyFilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(80, 22);
            this.btnApplyFilter.TabIndex = 8;
            this.btnApplyFilter.Text = "Aplica filtre";
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // cbFilterProducer
            // 
            this.cbFilterProducer.FormattingEnabled = true;
            this.cbFilterProducer.Location = new System.Drawing.Point(88, 98);
            this.cbFilterProducer.Margin = new System.Windows.Forms.Padding(2);
            this.cbFilterProducer.Name = "cbFilterProducer";
            this.cbFilterProducer.Size = new System.Drawing.Size(122, 21);
            this.cbFilterProducer.TabIndex = 7;
            // 
            // prodFilterLabel
            // 
            this.prodFilterLabel.AutoSize = true;
            this.prodFilterLabel.Location = new System.Drawing.Point(5, 99);
            this.prodFilterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.prodFilterLabel.Name = "prodFilterLabel";
            this.prodFilterLabel.Size = new System.Drawing.Size(59, 13);
            this.prodFilterLabel.TabIndex = 6;
            this.prodFilterLabel.Text = "Producator";
            // 
            // nudStockMin
            // 
            this.nudStockMin.Location = new System.Drawing.Point(88, 75);
            this.nudStockMin.Margin = new System.Windows.Forms.Padding(2);
            this.nudStockMin.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudStockMin.Name = "nudStockMin";
            this.nudStockMin.Size = new System.Drawing.Size(122, 20);
            this.nudStockMin.TabIndex = 5;
            // 
            // stockFilterLabel
            // 
            this.stockFilterLabel.AutoSize = true;
            this.stockFilterLabel.Location = new System.Drawing.Point(5, 76);
            this.stockFilterLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.stockFilterLabel.Name = "stockFilterLabel";
            this.stockFilterLabel.Size = new System.Drawing.Size(58, 13);
            this.stockFilterLabel.TabIndex = 4;
            this.stockFilterLabel.Text = "Stoc minim";
            // 
            // nudPriceMax
            // 
            this.nudPriceMax.DecimalPlaces = 2;
            this.nudPriceMax.Location = new System.Drawing.Point(88, 52);
            this.nudPriceMax.Margin = new System.Windows.Forms.Padding(2);
            this.nudPriceMax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPriceMax.Name = "nudPriceMax";
            this.nudPriceMax.Size = new System.Drawing.Size(122, 20);
            this.nudPriceMax.TabIndex = 3;
            this.nudPriceMax.ThousandsSeparator = true;
            // 
            // pretMaxLabel
            // 
            this.pretMaxLabel.AutoSize = true;
            this.pretMaxLabel.Location = new System.Drawing.Point(5, 53);
            this.pretMaxLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pretMaxLabel.Name = "pretMaxLabel";
            this.pretMaxLabel.Size = new System.Drawing.Size(58, 13);
            this.pretMaxLabel.TabIndex = 2;
            this.pretMaxLabel.Text = "Pret maxim";
            // 
            // nudPriceMin
            // 
            this.nudPriceMin.DecimalPlaces = 2;
            this.nudPriceMin.Location = new System.Drawing.Point(88, 30);
            this.nudPriceMin.Margin = new System.Windows.Forms.Padding(2);
            this.nudPriceMin.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPriceMin.Name = "nudPriceMin";
            this.nudPriceMin.Size = new System.Drawing.Size(122, 20);
            this.nudPriceMin.TabIndex = 1;
            this.nudPriceMin.ThousandsSeparator = true;
            // 
            // pretMinLabel
            // 
            this.pretMinLabel.AutoSize = true;
            this.pretMinLabel.Location = new System.Drawing.Point(5, 31);
            this.pretMinLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pretMinLabel.Name = "pretMinLabel";
            this.pretMinLabel.Size = new System.Drawing.Size(55, 13);
            this.pretMinLabel.TabIndex = 0;
            this.pretMinLabel.Text = "Pret minim";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearSearch.Location = new System.Drawing.Point(708, 86);
            this.btnClearSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(110, 23);
            this.btnClearSearch.TabIndex = 11;
            this.btnClearSearch.Text = "Goleste cautarea";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.brnClearSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(850, 293);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "   ";
            // 
            // btnViewCart
            // 
            this.btnViewCart.Location = new System.Drawing.Point(131, 448);
            this.btnViewCart.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewCart.Name = "btnViewCart";
            this.btnViewCart.Size = new System.Drawing.Size(110, 23);
            this.btnViewCart.TabIndex = 15;
            this.btnViewCart.Text = "Cos";
            this.btnViewCart.UseVisualStyleBackColor = true;
            this.btnViewCart.Click += new System.EventHandler(this.btnViewCart_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(18, 448);
            this.btnAddToCart.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(110, 23);
            this.btnAddToCart.TabIndex = 14;
            this.btnAddToCart.Text = "Adauga in Cos";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // gbRapoarte
            // 
            this.gbRapoarte.Controls.Add(this.btnShowCharts);
            this.gbRapoarte.Controls.Add(this.btnGenerateReport);
            this.gbRapoarte.Controls.Add(this.label2);
            this.gbRapoarte.Controls.Add(this.cbReportBy);
            this.gbRapoarte.Controls.Add(this.dtpEnd);
            this.gbRapoarte.Controls.Add(this.dtpStart);
            this.gbRapoarte.Location = new System.Drawing.Point(18, 266);
            this.gbRapoarte.Name = "gbRapoarte";
            this.gbRapoarte.Size = new System.Drawing.Size(223, 125);
            this.gbRapoarte.TabIndex = 16;
            this.gbRapoarte.TabStop = false;
            this.gbRapoarte.Text = "Rapoarte";
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(8, 92);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(2);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(100, 22);
            this.btnGenerateReport.TabIndex = 10;
            this.btnGenerateReport.Text = "Genereaza raport";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Raport dupa:";
            // 
            // cbReportBy
            // 
            this.cbReportBy.FormattingEnabled = true;
            this.cbReportBy.Items.AddRange(new object[] {
            "Categorie",
            "Client"});
            this.cbReportBy.Location = new System.Drawing.Point(88, 63);
            this.cbReportBy.Name = "cbReportBy";
            this.cbReportBy.Size = new System.Drawing.Size(122, 21);
            this.cbReportBy.TabIndex = 2;
            this.cbReportBy.Text = "Categorie";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(113, 27);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(97, 20);
            this.dtpEnd.TabIndex = 1;
            // 
            // dtpStart
            // 
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(10, 27);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(100, 20);
            this.dtpStart.TabIndex = 0;
            // 
            // btnShowCharts
            // 
            this.btnShowCharts.Location = new System.Drawing.Point(110, 92);
            this.btnShowCharts.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowCharts.Name = "btnShowCharts";
            this.btnShowCharts.Size = new System.Drawing.Size(100, 22);
            this.btnShowCharts.TabIndex = 11;
            this.btnShowCharts.Text = "Grafice";
            this.btnShowCharts.UseVisualStyleBackColor = true;
            this.btnShowCharts.Click += new System.EventHandler(this.btnShowCharts_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(707, 486);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(110, 23);
            this.btnLogout.TabIndex = 17;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnExportProducts
            // 
            this.btnExportProducts.Location = new System.Drawing.Point(281, 486);
            this.btnExportProducts.Name = "btnExportProducts";
            this.btnExportProducts.Size = new System.Drawing.Size(110, 23);
            this.btnExportProducts.TabIndex = 18;
            this.btnExportProducts.Text = "Export PDF";
            this.btnExportProducts.UseVisualStyleBackColor = true;
            this.btnExportProducts.Click += new System.EventHandler(this.btnExportProducts_Click);
            // 
            // btnExportXls
            // 
            this.btnExportXls.Location = new System.Drawing.Point(397, 486);
            this.btnExportXls.Name = "btnExportXls";
            this.btnExportXls.Size = new System.Drawing.Size(110, 23);
            this.btnExportXls.TabIndex = 19;
            this.btnExportXls.Text = "Export XLS";
            this.btnExportXls.UseVisualStyleBackColor = true;
            this.btnExportXls.Click += new System.EventHandler(this.btnExportXls_Click);
            // 
            // btnImportXls
            // 
            this.btnImportXls.Location = new System.Drawing.Point(513, 486);
            this.btnImportXls.Name = "btnImportXls";
            this.btnImportXls.Size = new System.Drawing.Size(110, 23);
            this.btnImportXls.TabIndex = 20;
            this.btnImportXls.Text = "Import XLS";
            this.btnImportXls.UseVisualStyleBackColor = true;
            this.btnImportXls.Click += new System.EventHandler(this.btnImportXls_Click);
            // 
            // btnViewLog
            // 
            this.btnViewLog.Location = new System.Drawing.Point(18, 486);
            this.btnViewLog.Name = "btnViewLog";
            this.btnViewLog.Size = new System.Drawing.Size(110, 23);
            this.btnViewLog.TabIndex = 21;
            this.btnViewLog.Text = "Vizualizare istoric";
            this.btnViewLog.UseVisualStyleBackColor = true;
            this.btnViewLog.Click += new System.EventHandler(this.btnViewLog_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(844, 525);
            this.Controls.Add(this.btnViewLog);
            this.Controls.Add(this.btnImportXls);
            this.Controls.Add(this.btnExportXls);
            this.Controls.Add(this.btnExportProducts);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.gbRapoarte);
            this.Controls.Add(this.btnViewCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClearSearch);
            this.Controls.Add(this.filtre);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddProducator);
            this.Controls.Add(this.btnDeletePiesa);
            this.Controls.Add(this.btnEditPiesa);
            this.Controls.Add(this.btnAddPiesa);
            this.Controls.Add(this.dgvPieseAuto);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(860, 564);
            this.MinimumSize = new System.Drawing.Size(860, 564);
            this.Name = "MainForm";
            this.Text = "Pagina Principala";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPieseAuto)).EndInit();
            this.filtre.ResumeLayout(false);
            this.filtre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceMin)).EndInit();
            this.gbRapoarte.ResumeLayout(false);
            this.gbRapoarte.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DataGridView dgvPieseAuto;
        private System.Windows.Forms.Button btnAddPiesa;
        private System.Windows.Forms.Button btnEditPiesa;
        private System.Windows.Forms.Button btnDeletePiesa;
        private System.Windows.Forms.Button btnAddProducator;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox filtre;
        private System.Windows.Forms.ComboBox cbFilterProducer;
        private System.Windows.Forms.Label prodFilterLabel;
        private System.Windows.Forms.NumericUpDown nudStockMin;
        private System.Windows.Forms.Label stockFilterLabel;
        private System.Windows.Forms.NumericUpDown nudPriceMax;
        private System.Windows.Forms.Label pretMaxLabel;
        private System.Windows.Forms.NumericUpDown nudPriceMin;
        private System.Windows.Forms.Label pretMinLabel;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnViewCart;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.GroupBox gbRapoarte;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbReportBy;
        private System.Windows.Forms.Button btnShowCharts;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnExportProducts;
        private System.Windows.Forms.Button btnExportXls;
        private System.Windows.Forms.Button btnImportXls;
        private System.Windows.Forms.Button btnViewLog;
    }
}