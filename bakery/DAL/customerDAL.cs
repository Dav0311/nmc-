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
    class customerDAL
    {
        //strng mthd for db con
        static string myconstrng = ConfigurationManager.ConnectionStrings["constrng"].ConnectionString;

        #region select data method
        public DataTable select()
        {
            //sql con
            SqlConnection con = new SqlConnection(myconstrng);
            //create dt and return it
            DataTable dt = new DataTable();

            try
            {
                //sql query to select data
                string sql = "select * from nmc_customers";

                //create sql cmd
                SqlCommand cmd = new SqlCommand(sql, con);
                //create data adpter to staore data temp
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
        #region insert data method
        public bool insert(customerBLL c)
        {
            //sql con
            SqlConnection con = new SqlConnection(myconstrng);

            //craete bool var and set its default to false
            bool success = false;

            try
            {
                //sql query
                string sql = "insert into nmc_customers (name, last_name, email, contact, address, added_date, added_by) values(@name, @last_name, @email, @contact, @address, @added_date, @added_by)";

                //sql cmd 
                SqlCommand cmd = new SqlCommand(sql, con);
                //passing values using parametters
                cmd.Parameters.AddWithValue("@name", c.name);
                cmd.Parameters.AddWithValue("@last_name", c.last_name);
                cmd.Parameters.AddWithValue("@email", c.email);
                cmd.Parameters.AddWithValue("@contact", c.contact);
                cmd.Parameters.AddWithValue("@address", c.address);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);

                con.Open();
                //craete int var to exe qry
                int rows = cmd.ExecuteNonQuery();

                //if to confrim exe
                if (rows > 0)
                {
                    success = true;
                }
                else
                {
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
            //sql con
            SqlConnection con = new SqlConnection(myconstrng);
            //create dt and return it
            DataTable dt = new DataTable();

            try
            {
                //sql query to select data
                string sql = "select * from nmc_customers where ID like '%"+keywords+ "%' or name like '%" + keywords + "%' or last_name like '%" + keywords + "%' or address  like '%" + keywords + "%'";

                //create sql cmd
                SqlCommand cmd = new SqlCommand(sql, con);
                //create data adpter to staore data temp
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
        #region delete data method
        public bool delete(customerBLL c)
        {
            //sql con
            SqlConnection con = new SqlConnection(myconstrng);
            //create bool var and set default to false
            bool success = false;
            try
            {
                //sql qry to delete
                string sql = "delete from nmc_customers where ID=@ID";

                //sql cmd
                SqlCommand cmd = new SqlCommand(sql, con);
                //passing data using para
                cmd.Parameters.AddWithValue("@ID", c.ID);

                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    success = true;
                }
                else
                {
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
        public bool update(customerBLL c)
        {
            //sql con
            SqlConnection con = new SqlConnection(myconstrng);
            //craete bool var and set default to false
            bool success = false;
            try
            {
                //sql qry
                string sql = "update nmc_customers set name=@name, last_name=@last_name, email=@email, contact=@contact, address=@address, added_date=@added_date, added_by=@added_by where ID=@ID";

                //create sql cmd to pass the values
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@name", c.name);
                cmd.Parameters.AddWithValue("@last_name", c.last_name);
                cmd.Parameters.AddWithValue("@email", c.email);
                cmd.Parameters.AddWithValue("@contact", c.contact);
                cmd.Parameters.AddWithValue("@address", c.address);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);
                cmd.Parameters.AddWithValue("@ID", c.ID);

                //open con
                con.Open();
                //use int to exe
                int rows = cmd.ExecuteNonQuery();
                //confirm exe
                if (rows > 0)
                {
                    success = true;
                }
                else
                {
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
        #region search fr patients 
        public customerBLL searchforcustomer(string keywords)
        {
            //create an obj for cust class
            customerBLL c = new customerBLL();

            //sql con
            SqlConnection con = new SqlConnection(myconstrng);
            //create dt to hold the data
            DataTable dt = new DataTable();

            try
            {
                //sql qry to search for customer based on keywords
                string sql = "select name from nmc_customers where name like  '%"+keywords+ "%'  or last_name like  '%" + keywords + "%'or ID like '%" + keywords+"%'";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);
                con.Open();
                adapter.Fill(dt);

                //if we have values n dt
                if (dt.Rows.Count > 0)
                {
                    c.name = dt.Rows[0]["name"].ToString();
                    c.last_name = dt.Rows[1]["last_name"].ToString();
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

            return c;
        }
        #endregion
    }
}
