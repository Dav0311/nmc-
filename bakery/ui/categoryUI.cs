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
    public partial class categoryUI : Form
    {
        public categoryUI()
        {
            InitializeComponent();
        }
        categoryBLL c = new categoryBLL();
        categoryDAL dal = new categoryDAL();
        userDAL udal = new userDAL();

        private void btnadd_Click(object sender, EventArgs e)
        {
            //getting values 
            c.title = txttitle.Text;
   
            c.description = txtdescription.Text;
            c.added_date = DateTime.Now;

            //getting added by
            c.added_by = lbluser.Text;

            //bool to insert data into db
            bool success = dal.insert(c);

            //if cat is inserted success
            if (success == true)
            {
                MessageBox.Show("new category inserted successfully");
                clear();

                //refreshing dgv
                DataTable dt = dal.select();
                dgvcat.DataSource = dt;
            }
            else
            {
                MessageBox.Show("failed to insert new category, please try again");
            }

        }
        public void clear()
        {
            txtcategoryid.Text = "";
            txttitle.Text = "";
            txtdescription.Text = "";
            txtsearch.Text = "";
        }

        private void categoryUI_Load(object sender, EventArgs e)
        {
            //displaying added cat in dgv
            DataTable dt = dal.select();
            dgvcat.DataSource = dt;

            //display username
            lbluser.Text = loginUI.loggedin;
        }

        private void dgvcat_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            //getting index in the dgv
            int rowindex = e.RowIndex;
            txtcategoryid.Text = dgvcat.Rows[rowindex].Cells[0].Value.ToString();

            txttitle.Text = dgvcat.Rows[rowindex].Cells[2].Value.ToString();
            txtdescription.Text = dgvcat.Rows[rowindex].Cells[3].Value.ToString();
           
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //get values from frm
            c.ID =int.Parse( txtcategoryid.Text);
            c.title = txttitle.Text;
   
            c.description = txtdescription.Text;
            c.added_date = DateTime.Now;

            //getting added by
            c.added_by = lbluser.Text;


            bool success = dal.update(c);
            if (success == true)
            {
                MessageBox.Show("updated successfully.");
                clear();
                //refreshing dt
                DataTable dt = dal.select();
                dgvcat.DataSource = dt;
            }
            else
            {
                MessageBox.Show("failed to update, category.");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            //getting added by
            c.ID = int.Parse(txtcategoryid.Text);

            bool success = dal.delete(c);
            //if the data is deleted the value is true then otherwise
            if (success == true)
            {
                //deleted successfully
                MessageBox.Show("category has been deleted successfully.");
            }
            else
            {
                //failed to delete data
                MessageBox.Show("failed to delete category, please try again.");
            }
            //refreshing dgv
            DataTable dt = dal.select();
            dgvcat.DataSource = dt;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //get the keywords first
            string keywords = txtsearch.Text;
            //filter cat based on keywords
            if (keywords != null)
            {
                //display cat using seacrh methd
                DataTable dt = dal.search(keywords);
                dgvcat.DataSource = dt;
            }
            else
            {
                //use select method
                DataTable dt = dal.select();
                dgvcat.DataSource = dt;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            adminUI admin = new adminUI();
            admin.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
