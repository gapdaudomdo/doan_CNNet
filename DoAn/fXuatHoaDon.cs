using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn
{
    public partial class fXuatHoaDon : Form
    {
        public fXuatHoaDon()
        {
            InitializeComponent();
        }

        private void fXuatHoaDon_Load(object sender, EventArgs e)
        {
            MyReport rpt = new MyReport();
            rpt.SetDatabaseLogon("sa", "123", "PANDA-PC\\SQLEXPRESS2012", "SQLQUANLYKHACHSAN");
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.Refresh();
        }
    }
}
