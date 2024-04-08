using bakery.BLL;
using bakery.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace bakery.ui
{
    public partial class salesDetailsUI : Form
    {
        public salesDetailsUI()
        {
            InitializeComponent();
        }
        saledetailsDAL dal = new saledetailsDAL();
        saledetailsBLL s = new saledetailsBLL();
        expenseBLL ex = new expenseBLL();
        expenseDAL edal = new expenseDAL();
        //db con
        static string myconstrng = ConfigurationManager.ConnectionStrings["constrng"].ConnectionString;
        //
        

        private void btnshow_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constrng"].ConnectionString);

            SqlCommand cmd = new SqlCommand("twodates", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@date1", dtpFrom.Text);
            cmd.Parameters.AddWithValue("@date2", dtpTo.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmd.ExecuteNonQuery();
            dgvsalesDetails.DataSource = dt;
            con.Close();

            //refresh dgv
            DataTable sdt = dal.select();
            dgvsalesDetails.DataSource = sdt;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            adminUI admin = new adminUI();
            admin.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //code to complete print
            /*  DGVPrinter printer = new DGVPrinter();

              printer.Title = "\r\n\r\n NALUGALA MEDICAL CENTER. \r\n\r\n";
            printer.SubTitle = "Medical reciept. \r\n\r\n";
            printer.SubTitle = "nalugala, kalabya stage Entebbe \r\n tele: 0700700825 or 0773772248 \r\n\r\n" + "Making communities healthier.";
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
              printer.PageNumbers = true;
              printer.PageNumberInHeader = false;
              printer.PorportionalColumns = true;
              printer.HeaderCellAlignment = StringAlignment.Near;
              printer.Footer =  "Making communities healthier.";
              printer.FooterSpacing = 15;
              printer.PrintDataGridView(dgvsalesDetails);

           

            //successfully inserted
            MessageBox.Show("Sales details have been printed successfully.");
            */

            SqlConnection con = new SqlConnection(myconstrng);
            string query = "select * from nmc_salesDetails where added_date between @dtpFrom and @dtpTo";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            da.SelectCommand.Parameters.AddWithValue("@dtpFrom", DateTime.Parse(dtpFrom.Text));
            da.SelectCommand.Parameters.AddWithValue("@dtpTo", DateTime.Parse(dtpTo.Text));
            DataSet reprt = new DataSet();
            da.Fill(reprt, "nmc_salesDetails");

            DetailsReport rpt = new DetailsReport();
            rpt.SetDataSource(reprt);
            detailReportViewer1.ReportSource = rpt;
        }

        private void salesDetailsUI_Load(object sender, EventArgs e)
        {
            //displaying added cat in dgv
            DataTable dt = dal.select();
            dgvsalesDetails.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constrng"].ConnectionString);

            SqlCommand cmd = new SqlCommand("twodates_expense", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@date1", dtpFrom.Text);
            cmd.Parameters.AddWithValue("@date2", dtpTo.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmd.ExecuteNonQuery();
            dgvsalesDetails.DataSource = dt;
            con.Close();

            //refreshing dgv
            
            DataTable exdt = edal.select();
            dgvsalesDetails.DataSource = exdt;
        }

        private void button3_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constrng"].ConnectionString);

            SqlCommand cmd = new SqlCommand("TwoDateReport", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@date1", dtpFrom.Text);
            cmd.Parameters.AddWithValue("@date2", dtpTo.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmd.ExecuteNonQuery();
            dgvsalesDetails.DataSource = dt;
            con.Close();

            //refreshing dgv

            DataTable rptdt = dal.select();
            dgvsalesDetails.DataSource = rptdt;
        }

        private void btnexpReport_Click(object sender, EventArgs e)
        {



            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constrng"].ConnectionString);

            SqlCommand cmd = new SqlCommand("twoDayExpReport", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@date1", dtpFrom.Text);
            cmd.Parameters.AddWithValue("@date2", dtpTo.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmd.ExecuteNonQuery();
            dgvsalesDetails.DataSource = dt;
            con.Close();

            //refreshing dgv
           // DataTable exRpt = edal.select();
            //dgvsalesDetails.DataSource = exRpt;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
          
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constrng"].ConnectionString);

            SqlCommand cmd = new SqlCommand("twodates", con);
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@date1", dtpFrom.Text);
            cmd.Parameters.AddWithValue("@date2", dtpTo.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            cmd.ExecuteNonQuery();
            dgvsalesDetails.DataSource = dt;
            con.Close();

            //refresh dgv
            DataTable sdt = dal.selectcredit();
            dgvsalesDetails.DataSource = sdt;

        }
    }
}
