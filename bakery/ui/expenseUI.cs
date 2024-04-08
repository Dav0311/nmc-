
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
    public partial class expenseUI : Form
    {
        public expenseUI()
        {
            InitializeComponent();
        }
        expenseBLL ex = new expenseBLL();
        expenseDAL edal = new expenseDAL();
        userDAL udal = new userDAL();

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            userDash dash = new userDash();
            dash.Show();
        }
        public void clear()
        {
            txtcost.Text = "";
            txtname.Text = "";
            txtqty.Text = "";
            txtsearch.Text = "";
        }
        private void expenseUI_Load(object sender, EventArgs e)
        {
            //displaying added cat in dgv
            DataTable dt = edal.select();
            dgvexpense.DataSource = dt;

            //display username
            lbluser.Text = loginUI.loggedin;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //getting values 
            ex.name =txtname.Text;
            ex.cost = decimal.Parse(txtcost.Text);
            ex.qty = decimal.Parse(txtqty.Text);
            ex.added_date = DateTime.Now;

            //getting added by
            ex.added_by = lbluser.Text;

            //bool to insert data into db
            bool success = edal.insert(ex);

            //if cat is inserted success
            if (success == true)
            {
                MessageBox.Show("new expenxe has been inserted successfully");
                clear();

                //refreshing dgv
                DataTable dt = edal.select();
                dgvexpense.DataSource = dt;
            }
            else
            {
                MessageBox.Show("failed to insert new expense, please try again");
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {

            //get values from frm
            ex.ID = int.Parse(txtexpID.Text);
            ex.name = txtname.Text;
            ex.cost = decimal.Parse(txtcost.Text);
            ex.qty = decimal.Parse(txtqty.Text);
            ex.added_date = DateTime.Now;

            //getting added by
            ex.added_by = lbluser.Text;


            bool success = edal.update(ex);
            if (success == true)
            {
                MessageBox.Show("updated successfully.");
                clear();
                //refreshing dt
                DataTable dt = edal.select();
                dgvexpense.DataSource = dt;
            }
            else
            {
                MessageBox.Show("failed to update, category.");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            //getting added by
            ex.ID = int.Parse(txtexpID.Text);

            //creating bool var to delete the cat
            bool success = edal.delete(ex);
            //if cat i deleted succe
            if (success == true)
            {
                MessageBox.Show("expense has been  deleted successfully.");
                clear();
                //refresshing dgv
                DataTable dt = edal.select();
                dgvexpense.DataSource = dt;
            }
            else
            {
                MessageBox.Show("failed to deleted expense.");
            }
        }

        private void dgvexpense_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            //getting index in the dgv
            int rowindex = e.RowIndex;
            txtexpID.Text = dgvexpense.Rows[rowindex].Cells[0].Value.ToString();
            txtname.Text = dgvexpense.Rows[rowindex].Cells[1].Value.ToString();
            txtcost.Text = dgvexpense.Rows[rowindex].Cells[2].Value.ToString();
            txtqty.Text = dgvexpense.Rows[rowindex].Cells[3].Value.ToString();
        

        }

            private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //get the keywords first
            string keywords = txtsearch.Text;
            //filter cat based on keywords
            if (keywords != null)
            {
                //display cat using seacrh methd
                DataTable dt = edal.search(keywords);
                dgvexpense.DataSource = dt;
            }
            else
            {
                //use select method
                DataTable dt = edal.select();
                dgvexpense.DataSource = dt;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
