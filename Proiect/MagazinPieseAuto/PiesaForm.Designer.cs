namespace MagazinPieseAuto {
    partial class PiesaForm {
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
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.txtProducator = new System.Windows.Forms.TextBox();
            this.nudStoc = new System.Windows.Forms.NumericUpDown();
            this.nudPret = new System.Windows.Forms.NumericUpDown();
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.cbProducator = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudStoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPret)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(79, 107);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(360, 31);
            this.txtDenumire.TabIndex = 0;
            // 
            // txtProducator
            // 
            this.txtProducator.Location = new System.Drawing.Point(79, 151);
            this.txtProducator.Name = "txtProducator";
            this.txtProducator.Size = new System.Drawing.Size(360, 31);
            this.txtProducator.TabIndex = 1;
            // 
            // nudStoc
            // 
            this.nudStoc.Location = new System.Drawing.Point(79, 188);
            this.nudStoc.Name = "nudStoc";
            this.nudStoc.Size = new System.Drawing.Size(109, 31);
            this.nudStoc.TabIndex = 2;
            // 
            // nudPret
            // 
            this.nudPret.DecimalPlaces = 2;
            this.nudPret.Location = new System.Drawing.Point(79, 225);
            this.nudPret.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPret.Name = "nudPret";
            this.nudPret.Size = new System.Drawing.Size(109, 31);
            this.nudPret.TabIndex = 3;
            // 
            // cbCategorie
            // 
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Location = new System.Drawing.Point(79, 262);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(355, 33);
            this.cbCategorie.TabIndex = 4;
            // 
            // cbProducator
            // 
            this.cbProducator.FormattingEnabled = true;
            this.cbProducator.Location = new System.Drawing.Point(79, 301);
            this.cbProducator.Name = "cbProducator";
            this.cbProducator.Size = new System.Drawing.Size(355, 33);
            this.cbProducator.TabIndex = 5;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(79, 340);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(142, 37);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 340);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(142, 37);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PiesaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 1091);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cbProducator);
            this.Controls.Add(this.cbCategorie);
            this.Controls.Add(this.nudPret);
            this.Controls.Add(this.nudStoc);
            this.Controls.Add(this.txtProducator);
            this.Controls.Add(this.txtDenumire);
            this.Name = "PiesaForm";
            this.Text = "PiesaForm";
            ((System.ComponentModel.ISupportInitialize)(this.nudStoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPret)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.TextBox txtProducator;
        private System.Windows.Forms.NumericUpDown nudStoc;
        private System.Windows.Forms.NumericUpDown nudPret;
        private System.Windows.Forms.ComboBox cbCategorie;
        private System.Windows.Forms.ComboBox cbProducator;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}