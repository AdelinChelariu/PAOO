using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazinPieseAuto
{
    public partial class ReportForm: Form
    {
        public ReportForm(DataTable reportData, string title = "Raport") {
            InitializeComponent();
            this.Text = title;
            dgvReport.DataSource = reportData;
        }
    }
}
