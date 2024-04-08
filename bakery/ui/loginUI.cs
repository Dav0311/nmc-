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
    public partial class loginUI : Form
    {
        public loginUI()
        {
            InitializeComponent();
        }
        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();
        public static string loggedin;

        private void btnlogin_Click(object sender, EventArgs e)
        {
            l.username = txtusername.Text.Trim();
            l.password = txtpassword.Text.Trim();
            l.usertype = cmbusertype.Text.Trim();

            //checking the login credential
            bool success = dal.logincheck(l);
            if (success == true)
            {
                //login successfull
                MessageBox.Show("user logged in");

                //showing loggedin user
                loggedin = l.username;
                //openning dashboards
                switch (l.usertype)
                {
                    case "admin":
                        {
                            //display admin dash
                            adminUI admin = new adminUI();
                            admin.Show();
                            this.Hide();
                        }
                        break;
                    case "user":
                        {
                            //display user dash
                            userDash user = new userDash();
                            user.Show();
                            this.Hide();

                        }
                        break;
                    default:
                        {
                            //display error mb
                            MessageBox.Show("invalid user type");
                        }
                        break;
                }
            }
            else
            {
                //failed to login 
                MessageBox.Show("failed to login user, please try again.");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           // this.Close();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loginUI_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
