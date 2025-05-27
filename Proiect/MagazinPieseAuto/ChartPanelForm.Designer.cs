using System.Windows.Forms;

namespace MagazinPieseAuto {
    partial class ChartPanelForm {
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBar = new System.Windows.Forms.TabPage();
            this.tabPie = new System.Windows.Forms.TabPage();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.pieChart1 = new LiveCharts.WinForms.PieChart();
            this.tabControl1.SuspendLayout();
            this.tabBar.SuspendLayout();
            this.tabPie.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabBar);
            this.tabControl1.Controls.Add(this.tabPie);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 366);
            this.tabControl1.TabIndex = 0;
            // 
            // tabBar
            // 
            this.tabBar.Controls.Add(this.cartesianChart1);
            this.tabBar.Location = new System.Drawing.Point(4, 24);
            this.tabBar.Name = "tabBar";
            this.tabBar.Padding = new Padding(3);
            this.tabBar.Size = new System.Drawing.Size(792, 422);
            this.tabBar.Text = "Bar Chart";
            this.tabBar.UseVisualStyleBackColor = true;
            // 
            // tabPie
            // 
            this.tabPie.Controls.Add(this.pieChart1);
            this.tabPie.Location = new System.Drawing.Point(4, 24);
            this.tabPie.Name = "tabPie";
            this.tabPie.Padding = new Padding(3);
            this.tabPie.Size = new System.Drawing.Size(792, 422);
            this.tabPie.Text = "Pie Chart";
            this.tabPie.UseVisualStyleBackColor = true;
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart1.Location = new System.Drawing.Point(3, 3);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(586, 334);
            this.cartesianChart1.TabIndex = 0;
            this.cartesianChart1.Text = "cartesianChart1";
            // 
            // pieChart1
            // 
            this.pieChart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChart1.Location = new System.Drawing.Point(3, 3);
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Size = new System.Drawing.Size(586, 334);
            this.pieChart1.TabIndex = 0;
            this.pieChart1.Text = "pieChart1";
            // 
            // ChartPanelForm
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "ChartPanelForm";
            this.Text = "Grafice vânzări";
            this.tabControl1.ResumeLayout(false);
            this.tabBar.ResumeLayout(false);
            this.tabPie.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBar;
        private System.Windows.Forms.TabPage tabPie;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private LiveCharts.WinForms.PieChart pieChart1;
    }
}