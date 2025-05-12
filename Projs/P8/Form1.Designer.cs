namespace P8 {
    partial class Form1 {
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
            this.lista_fisiere = new System.Windows.Forms.ListView();
            this.calea_curenta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lista_fisiere
            // 
            this.lista_fisiere.HideSelection = false;
            this.lista_fisiere.Location = new System.Drawing.Point(23, 51);
            this.lista_fisiere.Name = "lista_fisiere";
            this.lista_fisiere.Size = new System.Drawing.Size(594, 358);
            this.lista_fisiere.TabIndex = 0;
            this.lista_fisiere.UseCompatibleStateImageBehavior = false;
            this.lista_fisiere.View = System.Windows.Forms.View.List;
            // 
            // calea_curenta
            // 
            this.calea_curenta.AutoSize = true;
            this.calea_curenta.Location = new System.Drawing.Point(25, 21);
            this.calea_curenta.Name = "calea_curenta";
            this.calea_curenta.Size = new System.Drawing.Size(35, 13);
            this.calea_curenta.TabIndex = 1;
            this.calea_curenta.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calea_curenta);
            this.Controls.Add(this.lista_fisiere);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lista_fisiere;
        private System.Windows.Forms.Label calea_curenta;
    }
}

