using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using System.Configuration;
using bakery.BLL;
using bakery.DAL;

namespace bakery.ui
{
    public partial class report : Form
    {
         
        ReportDocument crys = new ReportDocument();
        static string myconstrng = ConfigurationManager.ConnectionStrings["constrng"].ConnectionString;

        public report()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
        }


        private void report_Load(object sender, EventArgs e)
        {

        }
    }
}
