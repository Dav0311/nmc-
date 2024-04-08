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
    public partial class patientsUI : Form
    {
        public patientsUI()
        {
            InitializeComponent();
        }
        userBLL u = new userBLL();
        userDAL udal = new userDAL();
        customerBLL c = new customerBLL();
        customerDAL cdal = new customerDAL();
        patientBLL p = new patientBLL();
        patientDAL pdal = new patientDAL();
        salesBLL s = new salesBLL();
        salesDAL sdal = new salesDAL();

        //db con
        static string myconstrng = ConfigurationManager.ConnectionStrings["constrng"].ConnectionString;
        //

        private void patientUI_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myconstrng);

            SqlDataAdapter da = new SqlDataAdapter("select firstName  from nmc_users where role like '%doctor%'", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbclinician.DataSource = dt;
            cmbclinician.DisplayMember = "firstName";
            cmbclinician.ValueMember = "firstName";
            cmbclinician.Text = "select clinician on duty";

            lbllogeduser.Text = loginUI.loggedin;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            userDash usr = new userDash();
            usr.Show();
            this.Hide();
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {

            //get values from ui

            p.visitDate = DateTime.Now;
            p.patient_firstName = txtFname.Text;
            p.patient_lastName = txtLname.Text;
            p.occupation = txtoccupation.Text;
            p.residence = txtresidence.Text;
            p.consultant = cmbclinician.Text;
            p.diagnosis = txtdiagnosis.Text;
            p.lab_tests = txtlab.Text;
            p.ms_history = txtMShistory.Text;
          

            //getting added by
            p.added_by = lbllogeduser.Text;

            //craete bool var to check
            bool success = pdal.insert(p);

            if (success == true)
            {
                MessageBox.Show("patient form added successfully.");
                clear();


            }
            else
            {
                MessageBox.Show("failed to add patient form, please try again");
            }
        }

        public void clear()
        {
            txtvisitDate.Text = "";
            txtLname.Text = "";
            txtFname.Text = "";
            txtoccupation.Text = "";
            txtresidence.Text = "";
            txtMShistory.Text = "";
            txtlab.Text = "";
            txtdiagnosis.Text="";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customerUI cust = new customerUI();
            this.Hide();
            cust.Show();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=nmcs/sqlexpress;Initial Catalog=nmc;Integrated Security=True");

            con.Open();
            if (txtID.Text != "")
            {
                SqlCommand cmd = new SqlCommand(" select * from nmc_salesDetails where ID like '%" + txtID.Text + "%'  ");
                cmd.Parameters.AddWithValue("@ID", int.Parse(txtID.Text));
                // cmd.Parameters.AddWithValue("@patient_firstName", txtFname.Text);
                //cmd.Parameters.AddWithValue("@patient_lastName", txtLname.Text);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    txtID.Text = da.GetValue(0).ToString();
                    txtFname.Text = da.GetValue(1).ToString();

                }
                con.Close();
            }

        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //get values
            string keyword = txtsearch.Text;

            if (keyword == "")
            {
                txtFname.Text = "";
                txtLname.Text = "";
                txtID.Text = "";
                txtoccupation.Text = "";
                txtresidence.Text = "";
                txtvisitDate.Text = "";
                txtbalance.Text = "";

                return;
            }
            //search the product and display in txtbx
            patientBLL p = pdal.getpatientsdetails(keyword);

            //set values into textbx
            txtID.Text = p.ID.ToString();
            txtFname.Text = p.patient_firstName;
            txtLname.Text = p.patient_lastName;
            txtoccupation.Text = p.occupation;
            txtresidence.Text = p.residence;
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            


            string query = "select * from nmc_patients where ID='" + txtID.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(query, myconstrng);
            DataSet report = new DataSet();
            da.Fill(report, "nmc_patients");

            crysreport rpt = new crysreport();
            rpt.SetDataSource(report);
            crystalReportViewer1.ReportSource = rpt;
        }

        private void patientsUI_Load(object sender, EventArgs e)
        {

        }

        private void lblusername_Click(object sender, EventArgs e)
        {

        }
    }
}
