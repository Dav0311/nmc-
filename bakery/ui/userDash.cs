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
    public partial class userDash : Form
    {
        public userDash()
        {
            InitializeComponent();
        }


        private void userDash_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginUI login = new loginUI();
            login.Show();
            this.Hide();
        }

        private void userDash_Load(object sender, EventArgs e)
        {
            lbluser.Text = loginUI.loggedin;
        }

        private void cUSTOMERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerUI cust = new customerUI();
            cust.Show();
            this.Hide();
        }

        private void sALESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salesUI sales = new salesUI();
            sales.Show();
            this.Hide();
        }

        private void pRODUCTSToolStripMenuItem_Click(object sender, EventArgs e)
        { 

            productUI prd = new productUI();
            prd.Show();
            this.Hide();
        }

        private void pRODUCTCATEGORYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            categoryUI cat = new categoryUI();
            cat.Show();
            this.Hide();
        }

        private void lbluser_Click(object sender, EventArgs e)
        {

        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            loginUI logout = new loginUI();
            logout.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            salesUI sales = new salesUI();
            sales.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            patientsUI cust = new patientsUI();
            cust.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            expenseUI exp = new expenseUI();
            exp.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //returning user to user dashboard
            salesMade salesView = new salesMade();
            this.Close();
            salesView.Show();
        }
    }
}
