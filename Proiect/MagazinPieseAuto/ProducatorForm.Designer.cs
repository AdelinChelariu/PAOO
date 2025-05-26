namespace MagazinPieseAuto {
    partial class ProducatorForm {
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
            this.lblNumeProducator = new System.Windows.Forms.Label();
            this.txtNumeProd = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeProducator
            // 
            this.lblNumeProducator.AutoSize = true;
            this.lblNumeProducator.Location = new System.Drawing.Point(43, 110);
            this.lblNumeProducator.Name = "lblNumeProducator";
            this.lblNumeProducator.Size = new System.Drawing.Size(179, 25);
            this.lblNumeProducator.TabIndex = 0;
            this.lblNumeProducator.Text = "Nume Producator";
            // 
            // txtNumeProd
            // 
            this.txtNumeProd.Location = new System.Drawing.Point(276, 110);
            this.txtNumeProd.Name = "txtNumeProd";
            this.txtNumeProd.Size = new System.Drawing.Size(362, 31);
            this.txtNumeProd.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(61, 204);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(109, 49);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(514, 204);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(109, 49);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ProducatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 380);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtNumeProd);
            this.Controls.Add(this.lblNumeProducator);
            this.Name = "ProducatorForm";
            this.Text = "Adaugare Producator Nou";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeProducator;
        private System.Windows.Forms.TextBox txtNumeProd;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}