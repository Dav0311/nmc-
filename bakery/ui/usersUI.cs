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
    public partial class usersUI : Form
    {
        public usersUI()
        {
            InitializeComponent();
        }
        userBLL u = new userBLL();
        userDAL dal = new userDAL();

        loginBLL l = new loginBLL();
        loginDAL lgdal = new loginDAL();
        public static string loggedin;

        private void btnadd_Click(object sender, EventArgs e)
        {
           

            //getting data frm txt
            u.firstName = txtfirstname.Text;
            u.lastName = txtlastname.Text;
            u.email = txtemail.Text;
            u.username = txtusername.Text;
            u.password = txtpassword.Text;
            u.contact = txtcontact.Text;
            u.address = txtaddress.Text;
            u.role = txtrole.Text;
            u.gender = cmbgender.Text;
            u.usertype = cmbusertype.Text;
            u.added_date = DateTime.Now;

            //getting added by
            u.added_by = lbluser.Text;

            //inserting into db
            bool success = dal.insert(u);
            //if data in inserted
            if (success == true)
            {
                //successfully inserted
                MessageBox.Show("user has been added successfuly.");
            }
            else
            {
                //failed to insert
                MessageBox.Show("failed to insert new user.");

            }
            //refreshing dgv
            DataTable dt = dal.select();
            dgvusers.DataSource = dt;

            //clear txtbx
            clear();
        }

        private void usersUI_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.select();
            dgvusers.DataSource = dt;

            //display username
            lbluser.Text = loginUI.loggedin;
        }
        public void clear()
        {
            txtuserid.Text = "";
            txtaddress.Text = "";
            txtfirstname.Text = "";
            txtcontact.Text = "";
            txtemail.Text = "";
            txtrole.Text = "";
            txtlastname.Text = "";
            txtpassword.Text = "";
            txtsearch.Text = "";
            txtusername.Text = "";
        }

        private void dgvusers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //getting index in the dgv
            int rowindex = e.RowIndex;
            txtuserid.Text = dgvusers.Rows[rowindex].Cells[0].Value.ToString();
            txtfirstname.Text = dgvusers.Rows[rowindex].Cells[1].Value.ToString();
            txtlastname.Text = dgvusers.Rows[rowindex].Cells[2].Value.ToString();
            txtemail.Text = dgvusers.Rows[rowindex].Cells[3].Value.ToString();
            txtusername.Text = dgvusers.Rows[rowindex].Cells[4].Value.ToString();
            txtpassword.Text = dgvusers.Rows[rowindex].Cells[5].Value.ToString();
            txtcontact.Text = dgvusers.Rows[rowindex].Cells[6].Value.ToString();
            txtaddress.Text = dgvusers.Rows[rowindex].Cells[7].Value.ToString();
            txtrole.Text = dgvusers.Rows[rowindex].Cells[8].Value.ToString();
            cmbgender.Text = dgvusers.Rows[rowindex].Cells[9].Value.ToString();
            cmbusertype.Text = dgvusers.Rows[rowindex].Cells[10].Value.ToString();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            //get the the values from txt in ui
            u.ID = Convert.ToInt32(txtuserid.Text);
            u.firstName = txtfirstname.Text;
            u.lastName = txtlastname.Text;
            u.email = txtemail.Text;
            u.username = txtusername.Text;
            u.password = txtpassword.Text;
            u.contact = txtcontact.Text;
            u.address = txtaddress.Text;
            u.role = txtrole.Text;
            u.gender = cmbgender.Text;
            u.usertype = cmbusertype.Text;
            u.added_date = DateTime.Now;


            //getting added by
            u.added_by = lbluser.Text;


            //updating data in db
            bool success = dal.update(u);
            //if data is updated value will be true hence false
            if (success == true)
            {
                //data updated
                MessageBox.Show("user updated successfully.");
                clear();
            }
            else
            {
                //failed to update data
                MessageBox.Show("failed to update user please try again.");
                
            }
            //refreshing dgv
            DataTable dt = dal.select();
            dgvusers.DataSource = dt;
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            //getting added by
            u.ID = int.Parse(txtuserid.Text);

            bool success = dal.delete(u);
            //if the data is deleted the value is true then otherwise
            if (success == true)
            {
                //deleted successfully
                MessageBox.Show("user has been deleted successfully.");
            }
            else
            {
                //failed to delete data
                MessageBox.Show("failed to delete user, please try again.");
            }
            //refreshing dgv
            DataTable dt = dal.select();
            dgvusers.DataSource = dt;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //get keywords from textbox
            string keywords = txtsearch.Text;

            //check if textbx has values
            if (keywords != null)
            {
                //show the user based o search
                DataTable dt = dal.search(keywords);
                dgvusers.DataSource = dt;
            }
            else
            {
                //show data in db
                DataTable dt = dal.select();
                dgvusers.DataSource = dt;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            adminUI admin = new adminUI();
            admin.Show();
        }

        private void dgvusers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
