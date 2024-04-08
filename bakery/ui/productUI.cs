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
    public partial class productUI : Form
    {
        public productUI()
        {
            InitializeComponent();
        }
        categoryDAL cdal = new categoryDAL();
        productDAL pdal = new productDAL();
        productBLL p = new productBLL();
        userDAL udal = new userDAL();
        private void productUI_Load(object sender, EventArgs e)
        {
            //create dt to hold cat data from db
            DataTable cdt = cdal.select();
            //specify datasoucre cmbcat
            cmbcat.DataSource = cdt;
            //specify dispaly and value member
            cmbcat.DisplayMember = "title";
            cmbcat.ValueMember = "title";

            //load prds in dgv
            DataTable dt = pdal.select();
            dgvproduct.DataSource = dt;

            //display username
            lbluser.Text = loginUI.loggedin;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            //get all the values from frm
            p.name = txtname.Text;
            p.category = cmbcat.Text;
            p.description = txtdescription.Text;
            p.rate =decimal.Parse( txtrate.Text);
            p.qty = 0;
            p.added_date = DateTime.Now;

            //getting added by
            p.added_by = lbluser.Text;

            //craete bool var to check if prd is added 
            bool success = pdal.insert(p);
            //if added succssfully var will be true hence false
            if (success == true)
            {
                MessageBox.Show("product added successfully");
                clear();
                //refreshing dgv
                DataTable dt = pdal.select();
                dgvproduct.DataSource = dt;
            }
            else
            {
                MessageBox.Show("failed to add new product.");
            }

        }
        public void clear()
        {
            txtproductid.Text = "";
            txtname.Text = "";
            txtdescription.Text = "";
            txtrate.Text = "";
            txtqty.Text = "";
            txtsearch.Text = "";
        }

        private void dgvproduct_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //craete int var to know which prd was clicked
            int rowindex = e.RowIndex;
            //diplay var in repective textbox
            txtproductid.Text = dgvproduct.Rows[rowindex].Cells[0].Value.ToString();
            txtname.Text = dgvproduct.Rows[rowindex].Cells[1].Value.ToString();
            cmbcat.Text = dgvproduct.Rows[rowindex].Cells[2].Value.ToString();
            txtdescription.Text = dgvproduct.Rows[rowindex].Cells[3].Value.ToString();
            txtrate.Text = dgvproduct.Rows[rowindex].Cells[4].Value.ToString();
            txtqty.Text = dgvproduct.Rows[rowindex].Cells[5].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //get the values from ui
            p.ID =int.Parse( txtproductid.Text);
            p.name = txtname.Text;
            p.category = cmbcat.Text;
            p.description = txtdescription.Text;
            p.rate =int.Parse( txtrate.Text);
            p.qty = int.Parse(txtqty.Text);
            p.added_date = DateTime.Now;
            //getting added by
            p.added_by = lbluser.Text;

            //create bool to check if product is updated
            bool success = pdal.update(p);
            //if the prd is updated succc\ess var will bebtrue hhence false
            if (success == true)
            {
                MessageBox.Show("product added successfully.");
                clear();
                //refreshing dgcv
                DataTable dt = pdal.select();
                dgvproduct.DataSource = dt;
            }
            else
            {
                MessageBox.Show("failed to update product.");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            //getting added by
            p.ID = int.Parse(txtproductid.Text);


            //create bool var to check data is deleted
            bool success = pdal.delete(p);
            //if prd is deleted success var will be true hence false
            if (success == true)
            {
                MessageBox.Show("product deleted successfully");
                clear();
                //refreshing dgcv
                DataTable dt = pdal.select();
                dgvproduct.DataSource = dt;
            }
            else
            {
                MessageBox.Show("failed to delete product, please try again.");
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //get keywords
            string keywords = txtsearch.Text;

            if (keywords != null)
            {
                //search prd
                DataTable dt = pdal.search(keywords);
                dgvproduct.DataSource = dt;
            }
            else
            {
                //display select
                DataTable dt = pdal.select();
                dgvproduct.DataSource = dt;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            adminUI admin = new adminUI();
            admin.Show();

        }
    }
}
