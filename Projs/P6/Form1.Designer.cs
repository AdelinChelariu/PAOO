namespace P6 {
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
            this.components = new System.ComponentModel.Container();
            this.desene_animate = new System.Windows.Forms.ImageList(this.components);
            this.construieste_lista = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // desene_animate
            // 
            this.desene_animate.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.desene_animate.ImageSize = new System.Drawing.Size(16, 16);
            this.desene_animate.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // construieste_lista
            // 
            this.construieste_lista.Location = new System.Drawing.Point(47, 332);
            this.construieste_lista.Name = "construieste_lista";
            this.construieste_lista.Size = new System.Drawing.Size(116, 63);
            this.construieste_lista.TabIndex = 0;
            this.construieste_lista.Text = "Desene";
            this.construieste_lista.UseVisualStyleBackColor = true;
            this.construieste_lista.Click += new System.EventHandler(this.contruieste_lista_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 328);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "Animate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(677, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 184);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 445);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.construieste_lista);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList desene_animate;
        private System.Windows.Forms.Button construieste_lista;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

