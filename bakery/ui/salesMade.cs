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
using System.Windows.Forms;

namespace bakery.ui
{
    public partial class salesMade : Form
    {
        public salesMade()
        {
            InitializeComponent();
          
        }
        saledetailsDAL dal = new saledetailsDAL();
        saledetailsBLL s = new saledetailsBLL();

        private void salesMade_Load(object sender, EventArgs e)
        {
            //displaying added transactions in salesui in dgv
            DataTable dt = dal.select();
            dataGridView1.DataSource = dt;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            userDash dash = new userDash();
            this.Close();
            dash.Show();
        }

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
            dataGridView1.DataSource = dt;
            con.Close();

            //refresh dgv
            DataTable sdt = dal.select();
            dataGridView1.DataSource = sdt;
        }
    }
}
