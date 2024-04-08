using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using bakery.BLL;

namespace bakery.DAL
{
    class userDAL
    {
        static string myconstrng = ConfigurationManager.ConnectionStrings["constrng"].ConnectionString;

        #region select method
        public DataTable select()
        {
            SqlConnection con = new SqlConnection(myconstrng);

            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from nmc_users";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        #endregion
        #region insert method
        public bool insert(userBLL u)
        {
            bool success = false;
            SqlConnection con = new SqlConnection(myconstrng);
            try
            {
                string sql = "insert into nmc_users (firstName, lastName, email, username, password, contact, address, gender, role, usertype, added_date, added_by) values(@firstName, @lastName, @email, @username, @password, @contact, @address, @gender, @role, @usertype, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@firstName", u.firstName);
                cmd.Parameters.AddWithValue("@lastName", u.lastName);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@gender", u.gender);
                cmd.Parameters.AddWithValue("@role", u.role);
                cmd.Parameters.AddWithValue("@usertype", u.usertype);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);

                con.Open();
                int rows = cmd.ExecuteNonQuery();
                //if the query is executed succcessfully
                if (rows > 0)
                {
                    //query is successful
                    success = true;
                }
                else
                {
                    //query failed
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
        #endregion
        #region update data method
        public bool update(userBLL u)
        {
            bool success = false;
            SqlConnection con = new SqlConnection(myconstrng);

            try
            {
                string sql = "update nmc_users set firstName=@firstName, lastName=@lastName, email=@email, username=@username, password=@password, contact=@contact, address=@address, gender=@gender, role=@role, usertype=@usertype, added_date=@added_date, added_by=@added_by where ID=@ID";
                SqlCommand cmd = new SqlCommand(sql, con);


                cmd.Parameters.AddWithValue("@firstName", u.firstName);
                cmd.Parameters.AddWithValue("@lastName", u.lastName);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@contact", u.contact);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@gender", u.gender);
                cmd.Parameters.AddWithValue("@role", u.role);
                cmd.Parameters.AddWithValue("@usertype", u.usertype);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);
                cmd.Parameters.AddWithValue("@ID", u.ID);

                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    //query success
                    success = true;
                }
                else
                {
                    //query failure
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
        #endregion
        #region delete data method
        public bool delete(userBLL u)
        {
            bool success = false;
            SqlConnection con = new SqlConnection(myconstrng);

            try
            {
                string sql = "delete from nmc_users where ID=@ID";

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@ID", u.ID);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    //query success
                    success = true;
                }
                else
                {
                    //query failure
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
        #endregion
        #region search data method
        public DataTable search(string keywords)
        {
            SqlConnection con = new SqlConnection(myconstrng);

            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from nmc_users where ID like '%" + keywords + "%' or firstName like '%" + keywords + "%' or lastName like '%" + keywords + "%' or usertype like '%" + keywords + "%'";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return dt;
        }
        #endregion
        #region getting user id
        public userBLL getIDfromusername(string username)
        {
            userBLL u = new userBLL();
            SqlConnection con = new SqlConnection(myconstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "select username from nmc_user where username='" + username + "'";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                con.Open();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    //u.id = int.Parse(dt.Rows[0]["id"].ToString());
                    u.username = dt.Rows[0]["username"].ToString();
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
            return u;
        }
        #endregion
    }
}
