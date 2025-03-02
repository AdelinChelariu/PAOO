namespace P4 {
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
            this.etichetaC = new System.Windows.Forms.LinkLabel();
            this.etichetaI = new System.Windows.Forms.LinkLabel();
            this.etichetaN = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // etichetaC
            // 
            this.etichetaC.AutoSize = true;
            this.etichetaC.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etichetaC.LinkArea = new System.Windows.Forms.LinkArea(23, 3);
            this.etichetaC.Location = new System.Drawing.Point(53, 91);
            this.etichetaC.Name = "etichetaC";
            this.etichetaC.Size = new System.Drawing.Size(202, 28);
            this.etichetaC.TabIndex = 0;
            this.etichetaC.TabStop = true;
            this.etichetaC.Text = "Click pentru a explora C:\\";
            this.etichetaC.UseCompatibleTextRendering = true;
            this.etichetaC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.etichetaC_LinkClicked);
            // 
            // etichetaI
            // 
            this.etichetaI.AutoSize = true;
            this.etichetaI.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etichetaI.LinkArea = new System.Windows.Forms.LinkArea(22, 25);
            this.etichetaI.Location = new System.Drawing.Point(53, 119);
            this.etichetaI.Name = "etichetaI";
            this.etichetaI.Size = new System.Drawing.Size(383, 28);
            this.etichetaI.TabIndex = 1;
            this.etichetaI.TabStop = true;
            this.etichetaI.Text = "Click pentru a naviga www.microsoft.com/romania";
            this.etichetaI.UseCompatibleTextRendering = true;
            this.etichetaI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.etichetaI_LinkClicked);
            // 
            // etichetaN
            // 
            this.etichetaN.AutoSize = true;
            this.etichetaN.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.etichetaN.LinkArea = new System.Windows.Forms.LinkArea(20, 7);
            this.etichetaN.Location = new System.Drawing.Point(53, 147);
            this.etichetaN.Name = "etichetaN";
            this.etichetaN.Size = new System.Drawing.Size(212, 28);
            this.etichetaN.TabIndex = 2;
            this.etichetaN.TabStop = true;
            this.etichetaN.Text = "Click pentru a rula notepad";
            this.etichetaN.UseCompatibleTextRendering = true;
            this.etichetaN.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.etichetaN_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.etichetaN);
            this.Controls.Add(this.etichetaI);
            this.Controls.Add(this.etichetaC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel etichetaC;
        private System.Windows.Forms.LinkLabel etichetaI;
        private System.Windows.Forms.LinkLabel etichetaN;
    }
}

