namespace MagazinPieseAuto {
    partial class RegistrationForm {
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
            this.cbRegRole = new System.Windows.Forms.ComboBox();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.txtRegUsername = new System.Windows.Forms.TextBox();
            this.grpClient = new System.Windows.Forms.GroupBox();
            this.txtClientNume = new System.Windows.Forms.TextBox();
            this.txtClientPrenume = new System.Windows.Forms.TextBox();
            this.txtClientTelefon = new System.Windows.Forms.TextBox();
            this.txtClientEmail = new System.Windows.Forms.TextBox();
            this.grpEmployee = new System.Windows.Forms.GroupBox();
            this.cbEmpFunc = new System.Windows.Forms.ComboBox();
            this.cbEmpDept = new System.Windows.Forms.ComboBox();
            this.nudEmpSalary = new System.Windows.Forms.NumericUpDown();
            this.dtpEmpHire = new System.Windows.Forms.DateTimePicker();
            this.btnRegOK = new System.Windows.Forms.Button();
            this.btnRegCancel = new System.Windows.Forms.Button();
            this.grpClient.SuspendLayout();
            this.grpEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // cbRegRole
            // 
            this.cbRegRole.FormattingEnabled = true;
            this.cbRegRole.Location = new System.Drawing.Point(135, 37);
            this.cbRegRole.Name = "cbRegRole";
            this.cbRegRole.Size = new System.Drawing.Size(121, 21);
            this.cbRegRole.TabIndex = 0;
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.Location = new System.Drawing.Point(135, 134);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.Size = new System.Drawing.Size(122, 20);
            this.txtRegPassword.TabIndex = 3;
            // 
            // txtRegUsername
            // 
            this.txtRegUsername.Location = new System.Drawing.Point(135, 87);
            this.txtRegUsername.Name = "txtRegUsername";
            this.txtRegUsername.Size = new System.Drawing.Size(122, 20);
            this.txtRegUsername.TabIndex = 2;
            // 
            // grpClient
            // 
            this.grpClient.Controls.Add(this.txtClientEmail);
            this.grpClient.Controls.Add(this.txtClientTelefon);
            this.grpClient.Controls.Add(this.txtClientPrenume);
            this.grpClient.Controls.Add(this.txtClientNume);
            this.grpClient.Location = new System.Drawing.Point(341, 26);
            this.grpClient.Name = "grpClient";
            this.grpClient.Size = new System.Drawing.Size(184, 148);
            this.grpClient.TabIndex = 4;
            this.grpClient.TabStop = false;
            this.grpClient.Text = "Detalii Client";
            this.grpClient.Visible = false;
            // 
            // txtClientNume
            // 
            this.txtClientNume.Location = new System.Drawing.Point(78, 38);
            this.txtClientNume.Name = "txtClientNume";
            this.txtClientNume.Size = new System.Drawing.Size(100, 20);
            this.txtClientNume.TabIndex = 0;
            // 
            // txtClientPrenume
            // 
            this.txtClientPrenume.Location = new System.Drawing.Point(78, 64);
            this.txtClientPrenume.Name = "txtClientPrenume";
            this.txtClientPrenume.Size = new System.Drawing.Size(100, 20);
            this.txtClientPrenume.TabIndex = 1;
            // 
            // txtClientTelefon
            // 
            this.txtClientTelefon.Location = new System.Drawing.Point(78, 90);
            this.txtClientTelefon.Name = "txtClientTelefon";
            this.txtClientTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtClientTelefon.TabIndex = 2;
            // 
            // txtClientEmail
            // 
            this.txtClientEmail.Location = new System.Drawing.Point(78, 116);
            this.txtClientEmail.Name = "txtClientEmail";
            this.txtClientEmail.Size = new System.Drawing.Size(100, 20);
            this.txtClientEmail.TabIndex = 3;
            // 
            // grpEmployee
            // 
            this.grpEmployee.Controls.Add(this.nudEmpSalary);
            this.grpEmployee.Controls.Add(this.cbEmpFunc);
            this.grpEmployee.Controls.Add(this.dtpEmpHire);
            this.grpEmployee.Controls.Add(this.cbEmpDept);
            this.grpEmployee.Location = new System.Drawing.Point(341, 197);
            this.grpEmployee.Name = "grpEmployee";
            this.grpEmployee.Size = new System.Drawing.Size(184, 188);
            this.grpEmployee.TabIndex = 5;
            this.grpEmployee.TabStop = false;
            this.grpEmployee.Text = "Detalii Angajat";
            // 
            // cbEmpFunc
            // 
            this.cbEmpFunc.FormattingEnabled = true;
            this.cbEmpFunc.Location = new System.Drawing.Point(74, 57);
            this.cbEmpFunc.Name = "cbEmpFunc";
            this.cbEmpFunc.Size = new System.Drawing.Size(103, 21);
            this.cbEmpFunc.TabIndex = 6;
            // 
            // cbEmpDept
            // 
            this.cbEmpDept.FormattingEnabled = true;
            this.cbEmpDept.Location = new System.Drawing.Point(75, 19);
            this.cbEmpDept.Name = "cbEmpDept";
            this.cbEmpDept.Size = new System.Drawing.Size(103, 21);
            this.cbEmpDept.TabIndex = 5;
            // 
            // nudEmpSalary
            // 
            this.nudEmpSalary.Location = new System.Drawing.Point(101, 153);
            this.nudEmpSalary.Name = "nudEmpSalary";
            this.nudEmpSalary.Size = new System.Drawing.Size(76, 20);
            this.nudEmpSalary.TabIndex = 8;
            // 
            // dtpEmpHire
            // 
            this.dtpEmpHire.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmpHire.Location = new System.Drawing.Point(56, 102);
            this.dtpEmpHire.Name = "dtpEmpHire";
            this.dtpEmpHire.Size = new System.Drawing.Size(121, 20);
            this.dtpEmpHire.TabIndex = 7;
            // 
            // btnRegOK
            // 
            this.btnRegOK.Location = new System.Drawing.Point(90, 232);
            this.btnRegOK.Name = "btnRegOK";
            this.btnRegOK.Size = new System.Drawing.Size(75, 23);
            this.btnRegOK.TabIndex = 6;
            this.btnRegOK.Text = "OK";
            this.btnRegOK.UseVisualStyleBackColor = true;
            this.btnRegOK.Click += new System.EventHandler(this.btnRegOK_Click);
            // 
            // btnRegCancel
            // 
            this.btnRegCancel.Location = new System.Drawing.Point(213, 239);
            this.btnRegCancel.Name = "btnRegCancel";
            this.btnRegCancel.Size = new System.Drawing.Size(75, 23);
            this.btnRegCancel.TabIndex = 7;
            this.btnRegCancel.Text = "Cancel";
            this.btnRegCancel.UseVisualStyleBackColor = true;
            this.btnRegCancel.Click += new System.EventHandler(this.btnRegCancel_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegCancel);
            this.Controls.Add(this.btnRegOK);
            this.Controls.Add(this.grpEmployee);
            this.Controls.Add(this.grpClient);
            this.Controls.Add(this.txtRegPassword);
            this.Controls.Add(this.txtRegUsername);
            this.Controls.Add(this.cbRegRole);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.grpClient.ResumeLayout(false);
            this.grpClient.PerformLayout();
            this.grpEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRegRole;
        private System.Windows.Forms.TextBox txtRegPassword;
        private System.Windows.Forms.TextBox txtRegUsername;
        private System.Windows.Forms.GroupBox grpClient;
        private System.Windows.Forms.TextBox txtClientEmail;
        private System.Windows.Forms.TextBox txtClientTelefon;
        private System.Windows.Forms.TextBox txtClientPrenume;
        private System.Windows.Forms.TextBox txtClientNume;
        private System.Windows.Forms.GroupBox grpEmployee;
        private System.Windows.Forms.ComboBox cbEmpFunc;
        private System.Windows.Forms.ComboBox cbEmpDept;
        private System.Windows.Forms.NumericUpDown nudEmpSalary;
        private System.Windows.Forms.DateTimePicker dtpEmpHire;
        private System.Windows.Forms.Button btnRegOK;
        private System.Windows.Forms.Button btnRegCancel;
    }
}