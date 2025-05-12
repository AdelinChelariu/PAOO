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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPieseAuto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(328, 571);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(0, 25);
            this.lblWelcome.TabIndex = 0;
            // 
            // btnAdminPanel
            // 
            this.btnAdminPanel.Location = new System.Drawing.Point(917, 885);
            this.btnAdminPanel.Name = "btnAdminPanel";
            this.btnAdminPanel.Size = new System.Drawing.Size(220, 49);
            this.btnAdminPanel.TabIndex = 1;
            this.btnAdminPanel.Text = "Admin Panel";
            this.btnAdminPanel.UseVisualStyleBackColor = true;
            // 
            // dgvPieseAuto
            // 
            this.dgvPieseAuto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPieseAuto.Location = new System.Drawing.Point(94, 78);
            this.dgvPieseAuto.Name = "dgvPieseAuto";
            this.dgvPieseAuto.RowHeadersWidth = 82;
            this.dgvPieseAuto.RowTemplate.Height = 33;
            this.dgvPieseAuto.Size = new System.Drawing.Size(761, 557);
            this.dgvPieseAuto.TabIndex = 2;
            // 
            // btnAddPiesa
            // 
            this.btnAddPiesa.Location = new System.Drawing.Point(94, 677);
            this.btnAddPiesa.Name = "btnAddPiesa";
            this.btnAddPiesa.Size = new System.Drawing.Size(123, 44);
            this.btnAddPiesa.TabIndex = 3;
            this.btnAddPiesa.Text = "Adauga";
            this.btnAddPiesa.UseVisualStyleBackColor = true;
            this.btnAddPiesa.Click += new System.EventHandler(this.btnAddPiesa_Click);
            // 
            // btnEditPiesa
            // 
            this.btnEditPiesa.Location = new System.Drawing.Point(94, 727);
            this.btnEditPiesa.Name = "btnEditPiesa";
            this.btnEditPiesa.Size = new System.Drawing.Size(123, 44);
            this.btnEditPiesa.TabIndex = 4;
            this.btnEditPiesa.Text = "Editeaza";
            this.btnEditPiesa.UseVisualStyleBackColor = true;
            this.btnEditPiesa.Click += new System.EventHandler(this.btnEditPiesa_Click);
            // 
            // btnDeletePiesa
            // 
            this.btnDeletePiesa.Location = new System.Drawing.Point(94, 777);
            this.btnDeletePiesa.Name = "btnDeletePiesa";
            this.btnDeletePiesa.Size = new System.Drawing.Size(123, 44);
            this.btnDeletePiesa.TabIndex = 5;
            this.btnDeletePiesa.Text = "Sterge";
            this.btnDeletePiesa.UseVisualStyleBackColor = true;
            this.btnDeletePiesa.Click += new System.EventHandler(this.btnDeletePiesa_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 946);
            this.Controls.Add(this.btnDeletePiesa);
            this.Controls.Add(this.btnEditPiesa);
            this.Controls.Add(this.btnAddPiesa);
            this.Controls.Add(this.dgvPieseAuto);
            this.Controls.Add(this.btnAdminPanel);
            this.Controls.Add(this.lblWelcome);
            this.Name = "MainForm";
            this.Text = "Pagina Principala";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPieseAuto)).EndInit();
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
    }
}