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
            this.btnAdminPanel = new System.Windows.Forms.Button();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbSortDirection = new System.Windows.Forms.ComboBox();
            this.cbSortColumn = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPieseAuto)).BeginInit();
            this.filtre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceMin)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(46, 59);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(102, 25);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Bun venit";
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.Location = new System.Drawing.Point(36, 920);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(220, 49);
            this.btnAdminPanel.TabIndex = 1;
            this.btnAdminPanel.Text = "Admin Panel";
            this.btnAdminPanel.UseVisualStyleBackColor = true;
            // 
            // dgvPieseAuto
            // 
            this.dgvPieseAuto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvPieseAuto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPieseAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPieseAuto.Location = new System.Drawing.Point(560, 229);
            this.dgvPieseAuto.Name = "dgvPieseAuto";
            this.dgvPieseAuto.RowHeadersWidth = 82;
            this.dgvPieseAuto.RowTemplate.Height = 33;
            this.dgvPieseAuto.Size = new System.Drawing.Size(1134, 621);
            this.dgvPieseAuto.TabIndex = 2;
            // 
            // btnAddPiesa
            // 
            this.btnAddPiesa.Location = new System.Drawing.Point(36, 756);
            this.btnAddPiesa.Name = "btnAddPiesa";
            this.btnAddPiesa.Size = new System.Drawing.Size(220, 44);
            this.btnAddPiesa.TabIndex = 3;
            this.btnAddPiesa.Text = "Adauga Produs";
            this.btnAddPiesa.UseVisualStyleBackColor = true;
            this.btnAddPiesa.Click += new System.EventHandler(this.btnAddPiesa_Click);
            // 
            // btnEditPiesa
            // 
            this.btnEditPiesa.Location = new System.Drawing.Point(36, 806);
            this.btnEditPiesa.Name = "btnEditPiesa";
            this.btnEditPiesa.Size = new System.Drawing.Size(220, 44);
            this.btnEditPiesa.TabIndex = 4;
            this.btnEditPiesa.Text = "Editeaza Produs";
            this.btnEditPiesa.UseVisualStyleBackColor = true;
            this.btnEditPiesa.Click += new System.EventHandler(this.btnEditPiesa_Click);
            // 
            // btnDeletePiesa
            // 
            this.btnDeletePiesa.Location = new System.Drawing.Point(262, 806);
            this.btnDeletePiesa.Name = "btnDeletePiesa";
            this.btnDeletePiesa.Size = new System.Drawing.Size(220, 44);
            this.btnDeletePiesa.TabIndex = 5;
            this.btnDeletePiesa.Text = "Sterge Produs";
            this.btnDeletePiesa.UseVisualStyleBackColor = true;
            this.btnDeletePiesa.Click += new System.EventHandler(this.btnDeletePiesa_Click);
            // 
            // btnAddProducator
            // 
            this.btnAddProducator.Location = new System.Drawing.Point(262, 756);
            this.btnAddProducator.Name = "btnAddProducator";
            this.btnAddProducator.Size = new System.Drawing.Size(220, 44);
            this.btnAddProducator.TabIndex = 6;
            this.btnAddProducator.Text = "Adauga Producator";
            this.btnAddProducator.UseVisualStyleBackColor = true;
            this.btnAddProducator.Click += new System.EventHandler(this.btnAddProducator_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(824, 169);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(347, 31);
            this.txtSearch.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Denumire / Producator";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1217, 162);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(220, 44);
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
            this.filtre.Location = new System.Drawing.Point(36, 172);
            this.filtre.Name = "filtre";
            this.filtre.Size = new System.Drawing.Size(446, 330);
            this.filtre.TabIndex = 10;
            this.filtre.TabStop = false;
            this.filtre.Text = "Filtrare";
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.Location = new System.Drawing.Point(260, 265);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(159, 43);
            this.btnClearFilter.TabIndex = 9;
            this.btnClearFilter.Text = "Goleste filtre";
            this.btnClearFilter.UseVisualStyleBackColor = true;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Location = new System.Drawing.Point(21, 265);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(159, 43);
            this.btnApplyFilter.TabIndex = 8;
            this.btnApplyFilter.Text = "Aplica filtre";
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // cbFilterProducer
            // 
            this.cbFilterProducer.FormattingEnabled = true;
            this.cbFilterProducer.Location = new System.Drawing.Point(176, 188);
            this.cbFilterProducer.Name = "cbFilterProducer";
            this.cbFilterProducer.Size = new System.Drawing.Size(243, 33);
            this.cbFilterProducer.TabIndex = 7;
            // 
            // prodFilterLabel
            // 
            this.prodFilterLabel.AutoSize = true;
            this.prodFilterLabel.Location = new System.Drawing.Point(10, 191);
            this.prodFilterLabel.Name = "prodFilterLabel";
            this.prodFilterLabel.Size = new System.Drawing.Size(117, 25);
            this.prodFilterLabel.TabIndex = 6;
            this.prodFilterLabel.Text = "Producator";
            // 
            // nudStockMin
            // 
            this.nudStockMin.Location = new System.Drawing.Point(176, 144);
            this.nudStockMin.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudStockMin.Name = "nudStockMin";
            this.nudStockMin.Size = new System.Drawing.Size(243, 31);
            this.nudStockMin.TabIndex = 5;
            // 
            // stockFilterLabel
            // 
            this.stockFilterLabel.AutoSize = true;
            this.stockFilterLabel.Location = new System.Drawing.Point(10, 146);
            this.stockFilterLabel.Name = "stockFilterLabel";
            this.stockFilterLabel.Size = new System.Drawing.Size(117, 25);
            this.stockFilterLabel.TabIndex = 4;
            this.stockFilterLabel.Text = "Stoc minim";
            // 
            // nudPriceMax
            // 
            this.nudPriceMax.DecimalPlaces = 2;
            this.nudPriceMax.Location = new System.Drawing.Point(176, 100);
            this.nudPriceMax.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPriceMax.Name = "nudPriceMax";
            this.nudPriceMax.Size = new System.Drawing.Size(243, 31);
            this.nudPriceMax.TabIndex = 3;
            this.nudPriceMax.ThousandsSeparator = true;
            // 
            // pretMaxLabel
            // 
            this.pretMaxLabel.AutoSize = true;
            this.pretMaxLabel.Location = new System.Drawing.Point(10, 102);
            this.pretMaxLabel.Name = "pretMaxLabel";
            this.pretMaxLabel.Size = new System.Drawing.Size(119, 25);
            this.pretMaxLabel.TabIndex = 2;
            this.pretMaxLabel.Text = "Pret maxim";
            // 
            // nudPriceMin
            // 
            this.nudPriceMin.DecimalPlaces = 2;
            this.nudPriceMin.Location = new System.Drawing.Point(176, 58);
            this.nudPriceMin.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudPriceMin.Name = "nudPriceMin";
            this.nudPriceMin.Size = new System.Drawing.Size(243, 31);
            this.nudPriceMin.TabIndex = 1;
            this.nudPriceMin.ThousandsSeparator = true;
            // 
            // pretMinLabel
            // 
            this.pretMinLabel.AutoSize = true;
            this.pretMinLabel.Location = new System.Drawing.Point(10, 60);
            this.pretMinLabel.Name = "pretMinLabel";
            this.pretMinLabel.Size = new System.Drawing.Size(113, 25);
            this.pretMinLabel.TabIndex = 0;
            this.pretMinLabel.Text = "Pret minim";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClearSearch.Location = new System.Drawing.Point(1474, 162);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Size = new System.Drawing.Size(220, 44);
            this.btnClearSearch.TabIndex = 11;
            this.btnClearSearch.Text = "Goleste cautarea";
            this.btnClearSearch.UseVisualStyleBackColor = true;
            this.btnClearSearch.Click += new System.EventHandler(this.brnClearSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbSortDirection);
            this.groupBox1.Controls.Add(this.cbSortColumn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(36, 543);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 172);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sortare";
            // 
            // cbSortDirection
            // 
            this.cbSortDirection.FormattingEnabled = true;
            this.cbSortDirection.Items.AddRange(new object[] {
            "Asc",
            "Desc"});
            this.cbSortDirection.Location = new System.Drawing.Point(176, 116);
            this.cbSortDirection.Name = "cbSortDirection";
            this.cbSortDirection.Size = new System.Drawing.Size(243, 33);
            this.cbSortDirection.TabIndex = 3;
            // 
            // cbSortColumn
            // 
            this.cbSortColumn.FormattingEnabled = true;
            this.cbSortColumn.Location = new System.Drawing.Point(176, 46);
            this.cbSortColumn.Name = "cbSortColumn";
            this.cbSortColumn.Size = new System.Drawing.Size(243, 33);
            this.cbSortColumn.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Directia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Coloana";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1700, 564);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "   ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1774, 1009);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
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
            this.Controls.Add(this.btnAdminPanel);
            this.Controls.Add(this.lblWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1800, 1080);
            this.Name = "MainForm";
            this.Text = "Pagina Principala";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPieseAuto)).EndInit();
            this.filtre.ResumeLayout(false);
            this.filtre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPriceMin)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnAdminPanel;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSortDirection;
        private System.Windows.Forms.ComboBox cbSortColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}