using bakery.BLL;
using bakery.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bakery.ui
{
    public partial class customerUI : Form
    {
        public customerUI()
        {
            InitializeComponent();
        }
        patientBLL p = new patientBLL();
        patientDAL pdal = new patientDAL();
       
        //
        userDAL udal = new userDAL();
        //
     
     
        private void customerUI_Load(object sender, EventArgs e)
        {
            //refreshing dgv
            DataTable dt = pdal.select();
            dgvcustomer.DataSource = dt;

            //display username
            lbluser.Text = loginUI.loggedin;
        }


      


        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //getting keywords from txt
            string keywords = txtsearch.Text;

            if (keywords != null)
            {
                //search customer
                DataTable dt = pdal.search(keywords);
                dgvcustomer.DataSource = dt;
            }
            else
            {
                //select methd
                DataTable dt = pdal.select();
                dgvcustomer.DataSource = dt;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            patientsUI patient = new patientsUI();
            patient.Show();
  
        }

       
    }
}
