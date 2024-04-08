using bakery.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bakery.DAL
{
    class loginDAL
    {
        //constrng
        static string myconstrng = ConfigurationManager.ConnectionStrings["constrng"].ConnectionString;

        public bool logincheck(loginBLL l)
        {
            bool success = false;
            //con to db
            SqlConnection con = new SqlConnection(myconstrng);

            try
            {
                string sql = "select * from nmc_users where username=@username and password=@password and usertype=@usertype";

                //create cmd
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@username", l.username);
                cmd.Parameters.AddWithValue("@password", l.password);
                cmd.Parameters.AddWithValue("@usertype", l.usertype);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                //checking rows in dt
                if (dt.Rows.Count > 0)
                {
                    //login successful
                    success = true;
                }
                else
                {
                    //login failed
                    success = false;
                }
                    

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return success;
        }
    }
}
