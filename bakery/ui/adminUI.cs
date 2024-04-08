using bakery.ui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bakery
{
    public partial class adminUI : Form
    {
        public adminUI()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void adminUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginUI login = new loginUI();
            login.Show();
            this.Hide();
        }

        private void adminUI_Load(object sender, EventArgs e)
        {
            lbllogeduser.Text = loginUI.loggedin;
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            usersUI user = new usersUI();
            user.Show();
            this.Hide();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            categoryUI cat = new categoryUI();
                cat.Show();
            this.Hide();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productUI prd = new productUI();
            prd.Show();
            this.Hide();
        }

        private void customersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            customerUI cust = new customerUI();
            cust.Show();
            this.Hide();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salesDetailsUI sale = new salesDetailsUI();
            sale.Show();
            this.Hide();
        }

        private void pRODUCTCATEGORYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            categoryUI cat = new categoryUI();
            cat.Show();
            this.Hide();
        }

        private void pRODUCTSToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            productUI prd = new productUI();
            prd.Show();
            this.Hide();
        }

        private void lbllogeduser_Click(object sender, EventArgs e)
        {

        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            loginUI logout = new loginUI();
            logout.Show();
        }

        private void lblPB_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            usersUI user = new usersUI();
            user.Show();
            this.Hide();
        }

        private void pbSalesDetails_Click(object sender, EventArgs e)
        {
            salesDetailsUI sale = new salesDetailsUI();
            sale.Show();
            this.Hide();
        }

        private void pbprdCategory_Click(object sender, EventArgs e)
        {

            categoryUI cat = new categoryUI();
            cat.Show();
            this.Hide();
        }

        private void pbProducts_Click(object sender, EventArgs e)
        {

            productUI prd = new productUI();
            prd.Show();
            this.Hide();
        }

        private void lbllogeduser_Click_1(object sender, EventArgs e)
        {

        }
    }
}
