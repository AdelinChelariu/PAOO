namespace MagazinPieseAuto {
    partial class AdminPanelForm {
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
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tabReports = new System.Windows.Forms.TabPage();
            this.dgvRpt = new System.Windows.Forms.DataGridView();
            this.btnRptGenerate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbRptBy = new System.Windows.Forms.ComboBox();
            this.dtpRptEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpRptStart = new System.Windows.Forms.DateTimePicker();
            this.tabCharts = new System.Windows.Forms.TabPage();
            this.btnGfxShow = new System.Windows.Forms.Button();
            this.dtpGfxEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpGfxStart = new System.Windows.Forms.DateTimePicker();
            this.tabEmployees = new System.Windows.Forms.TabPage();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.btnEmpAdd = new System.Windows.Forms.Button();
            this.nudEmpSalary = new System.Windows.Forms.NumericUpDown();
            this.dtpEmpHire = new System.Windows.Forms.DateTimePicker();
            this.cbEmpFunc = new System.Windows.Forms.ComboBox();
            this.cbEmpDept = new System.Windows.Forms.ComboBox();
            this.cbEmpRole = new System.Windows.Forms.ComboBox();
            this.txtEmpPassword = new System.Windows.Forms.TextBox();
            this.txtEmpUsername = new System.Windows.Forms.TextBox();
            this.tcAdmin.SuspendLayout();
            this.tabReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRpt)).BeginInit();
            this.tabCharts.SuspendLayout();
            this.tabEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tabReports);
            this.tcAdmin.Controls.Add(this.tabCharts);
            this.tcAdmin.Controls.Add(this.tabEmployees);
            this.tcAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcAdmin.Location = new System.Drawing.Point(0, 0);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(800, 450);
            this.tcAdmin.TabIndex = 0;
            // 
            // tabReports
            // 
            this.tabReports.Controls.Add(this.dgvRpt);
            this.tabReports.Controls.Add(this.btnRptGenerate);
            this.tabReports.Controls.Add(this.label2);
            this.tabReports.Controls.Add(this.cbRptBy);
            this.tabReports.Controls.Add(this.dtpRptEnd);
            this.tabReports.Controls.Add(this.dtpRptStart);
            this.tabReports.Location = new System.Drawing.Point(4, 22);
            this.tabReports.Name = "tabReports";
            this.tabReports.Padding = new System.Windows.Forms.Padding(3);
            this.tabReports.Size = new System.Drawing.Size(792, 424);
            this.tabReports.TabIndex = 0;
            this.tabReports.Text = "Rapoarte";
            this.tabReports.UseVisualStyleBackColor = true;
            // 
            // dgvRpt
            // 
            this.dgvRpt.AllowUserToAddRows = false;
            this.dgvRpt.AllowUserToDeleteRows = false;
            this.dgvRpt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRpt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRpt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRpt.Location = new System.Drawing.Point(290, 87);
            this.dgvRpt.Name = "dgvRpt";
            this.dgvRpt.ReadOnly = true;
            this.dgvRpt.RowHeadersVisible = false;
            this.dgvRpt.Size = new System.Drawing.Size(309, 230);
            this.dgvRpt.TabIndex = 16;
            // 
            // btnRptGenerate
            // 
            this.btnRptGenerate.Location = new System.Drawing.Point(136, 152);
            this.btnRptGenerate.Margin = new System.Windows.Forms.Padding(2);
            this.btnRptGenerate.Name = "btnRptGenerate";
            this.btnRptGenerate.Size = new System.Drawing.Size(100, 22);
            this.btnRptGenerate.TabIndex = 15;
            this.btnRptGenerate.Text = "Genereaza raport";
            this.btnRptGenerate.UseVisualStyleBackColor = true;
            this.btnRptGenerate.Click += new System.EventHandler(this.btnRptGenerate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Raport dupa:";
            // 
            // cbRptBy
            // 
            this.cbRptBy.FormattingEnabled = true;
            this.cbRptBy.Items.AddRange(new object[] {
            "Categorie",
            "Client"});
            this.cbRptBy.Location = new System.Drawing.Point(162, 123);
            this.cbRptBy.Name = "cbRptBy";
            this.cbRptBy.Size = new System.Drawing.Size(122, 21);
            this.cbRptBy.TabIndex = 13;
            this.cbRptBy.Text = "Categorie";
            // 
            // dtpRptEnd
            // 
            this.dtpRptEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRptEnd.Location = new System.Drawing.Point(204, 87);
            this.dtpRptEnd.Name = "dtpRptEnd";
            this.dtpRptEnd.Size = new System.Drawing.Size(80, 20);
            this.dtpRptEnd.TabIndex = 12;
            // 
            // dtpRptStart
            // 
            this.dtpRptStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpRptStart.Location = new System.Drawing.Point(84, 87);
            this.dtpRptStart.Name = "dtpRptStart";
            this.dtpRptStart.Size = new System.Drawing.Size(80, 20);
            this.dtpRptStart.TabIndex = 11;
            // 
            // tabCharts
            // 
            this.tabCharts.Controls.Add(this.btnGfxShow);
            this.tabCharts.Controls.Add(this.dtpGfxEnd);
            this.tabCharts.Controls.Add(this.dtpGfxStart);
            this.tabCharts.Location = new System.Drawing.Point(4, 22);
            this.tabCharts.Name = "tabCharts";
            this.tabCharts.Padding = new System.Windows.Forms.Padding(3);
            this.tabCharts.Size = new System.Drawing.Size(792, 424);
            this.tabCharts.TabIndex = 1;
            this.tabCharts.Text = "Grafice";
            this.tabCharts.UseVisualStyleBackColor = true;
            // 
            // btnGfxShow
            // 
            this.btnGfxShow.Location = new System.Drawing.Point(86, 148);
            this.btnGfxShow.Name = "btnGfxShow";
            this.btnGfxShow.Size = new System.Drawing.Size(143, 26);
            this.btnGfxShow.TabIndex = 2;
            this.btnGfxShow.Text = "Afiseaza grafice";
            this.btnGfxShow.UseVisualStyleBackColor = true;
            this.btnGfxShow.Click += new System.EventHandler(this.btnGfxShow_Click);
            // 
            // dtpGfxEnd
            // 
            this.dtpGfxEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGfxEnd.Location = new System.Drawing.Point(163, 94);
            this.dtpGfxEnd.Name = "dtpGfxEnd";
            this.dtpGfxEnd.Size = new System.Drawing.Size(111, 20);
            this.dtpGfxEnd.TabIndex = 1;
            // 
            // dtpGfxStart
            // 
            this.dtpGfxStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpGfxStart.Location = new System.Drawing.Point(35, 94);
            this.dtpGfxStart.Name = "dtpGfxStart";
            this.dtpGfxStart.Size = new System.Drawing.Size(111, 20);
            this.dtpGfxStart.TabIndex = 0;
            // 
            // tabEmployees
            // 
            this.tabEmployees.Controls.Add(this.dgvEmployees);
            this.tabEmployees.Controls.Add(this.btnEmpAdd);
            this.tabEmployees.Controls.Add(this.nudEmpSalary);
            this.tabEmployees.Controls.Add(this.dtpEmpHire);
            this.tabEmployees.Controls.Add(this.cbEmpFunc);
            this.tabEmployees.Controls.Add(this.cbEmpDept);
            this.tabEmployees.Controls.Add(this.cbEmpRole);
            this.tabEmployees.Controls.Add(this.txtEmpPassword);
            this.tabEmployees.Controls.Add(this.txtEmpUsername);
            this.tabEmployees.Location = new System.Drawing.Point(4, 22);
            this.tabEmployees.Name = "tabEmployees";
            this.tabEmployees.Size = new System.Drawing.Size(792, 424);
            this.tabEmployees.TabIndex = 2;
            this.tabEmployees.Text = "Angajati";
            this.tabEmployees.UseVisualStyleBackColor = true;
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(326, 54);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.Size = new System.Drawing.Size(302, 278);
            this.dgvEmployees.TabIndex = 8;
            // 
            // btnEmpAdd
            // 
            this.btnEmpAdd.Location = new System.Drawing.Point(70, 332);
            this.btnEmpAdd.Name = "btnEmpAdd";
            this.btnEmpAdd.Size = new System.Drawing.Size(122, 26);
            this.btnEmpAdd.TabIndex = 7;
            this.btnEmpAdd.Text = "Adaugare";
            this.btnEmpAdd.UseVisualStyleBackColor = true;
            this.btnEmpAdd.Click += new System.EventHandler(this.btnEmpAdd_Click);
            // 
            // nudEmpSalary
            // 
            this.nudEmpSalary.Location = new System.Drawing.Point(115, 290);
            this.nudEmpSalary.Name = "nudEmpSalary";
            this.nudEmpSalary.Size = new System.Drawing.Size(76, 20);
            this.nudEmpSalary.TabIndex = 6;
            // 
            // dtpEmpHire
            // 
            this.dtpEmpHire.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEmpHire.Location = new System.Drawing.Point(70, 239);
            this.dtpEmpHire.Name = "dtpEmpHire";
            this.dtpEmpHire.Size = new System.Drawing.Size(121, 20);
            this.dtpEmpHire.TabIndex = 5;
            // 
            // cbEmpFunc
            // 
            this.cbEmpFunc.FormattingEnabled = true;
            this.cbEmpFunc.Location = new System.Drawing.Point(88, 191);
            this.cbEmpFunc.Name = "cbEmpFunc";
            this.cbEmpFunc.Size = new System.Drawing.Size(103, 21);
            this.cbEmpFunc.TabIndex = 4;
            // 
            // cbEmpDept
            // 
            this.cbEmpDept.FormattingEnabled = true;
            this.cbEmpDept.Location = new System.Drawing.Point(89, 153);
            this.cbEmpDept.Name = "cbEmpDept";
            this.cbEmpDept.Size = new System.Drawing.Size(103, 21);
            this.cbEmpDept.TabIndex = 3;
            // 
            // cbEmpRole
            // 
            this.cbEmpRole.FormattingEnabled = true;
            this.cbEmpRole.Location = new System.Drawing.Point(88, 117);
            this.cbEmpRole.Name = "cbEmpRole";
            this.cbEmpRole.Size = new System.Drawing.Size(103, 21);
            this.cbEmpRole.TabIndex = 2;
            // 
            // txtEmpPassword
            // 
            this.txtEmpPassword.Location = new System.Drawing.Point(70, 84);
            this.txtEmpPassword.Name = "txtEmpPassword";
            this.txtEmpPassword.Size = new System.Drawing.Size(122, 20);
            this.txtEmpPassword.TabIndex = 1;
            // 
            // txtEmpUsername
            // 
            this.txtEmpUsername.Location = new System.Drawing.Point(70, 37);
            this.txtEmpUsername.Name = "txtEmpUsername";
            this.txtEmpUsername.Size = new System.Drawing.Size(122, 20);
            this.txtEmpUsername.TabIndex = 0;
            // 
            // AdminPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tcAdmin);
            this.Name = "AdminPanelForm";
            this.Text = "AdminPanelForm";
            this.tcAdmin.ResumeLayout(false);
            this.tabReports.ResumeLayout(false);
            this.tabReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRpt)).EndInit();
            this.tabCharts.ResumeLayout(false);
            this.tabEmployees.ResumeLayout(false);
            this.tabEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpSalary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tabReports;
        private System.Windows.Forms.TabPage tabCharts;
        private System.Windows.Forms.TabPage tabEmployees;
        private System.Windows.Forms.Button btnRptGenerate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbRptBy;
        private System.Windows.Forms.DateTimePicker dtpRptEnd;
        private System.Windows.Forms.DateTimePicker dtpRptStart;
        private System.Windows.Forms.DataGridView dgvRpt;
        private System.Windows.Forms.DateTimePicker dtpGfxStart;
        private System.Windows.Forms.Button btnGfxShow;
        private System.Windows.Forms.DateTimePicker dtpGfxEnd;
        private System.Windows.Forms.ComboBox cbEmpFunc;
        private System.Windows.Forms.ComboBox cbEmpDept;
        private System.Windows.Forms.ComboBox cbEmpRole;
        private System.Windows.Forms.TextBox txtEmpPassword;
        private System.Windows.Forms.TextBox txtEmpUsername;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.Button btnEmpAdd;
        private System.Windows.Forms.NumericUpDown nudEmpSalary;
        private System.Windows.Forms.DateTimePicker dtpEmpHire;
    }
}