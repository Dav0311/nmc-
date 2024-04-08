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
    class categoryDAL
    {
        //static string for db
        static string myconstrng = ConfigurationManager.ConnectionStrings["constrng"].ConnectionString;

       #region select method
        public DataTable select()
        {
            //con to db
            SqlConnection con = new SqlConnection(myconstrng);

            DataTable dt = new DataTable();

            try
            {
                //sql query
                string sql = "select * from nmc_category";
                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);                  con.Open();
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
        public bool insert (categoryBLL c)
        {
            //craetin bool and setting default value to false
            bool success=false;
            SqlConnection con = new SqlConnection(myconstrng);

            try
            {
                string sql = "insert into nmc_category (title, description, added_date, added_by) values (@title, @description, @added_date, @added_by) ";

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@title", c.title);
                
                cmd.Parameters.AddWithValue("@description", c.description);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);

                con.Open();
                int rows = cmd.ExecuteNonQuery();

                //if query is successful bool value changes
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
        public bool update(categoryBLL c)
        {
            //create bool and set value to false
            bool success = false;
            //create sql con
            SqlConnection con = new SqlConnection(myconstrng);
            try
            {
                string sql = "update nmc_category set title=@title, description=@description, added_date=@added_date, added_by=@added_by where ID=@ID";

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@title", c.title);
               
                cmd.Parameters.AddWithValue("@description", c.description);
                cmd.Parameters.AddWithValue("@added_date", c.added_date);
                cmd.Parameters.AddWithValue("@added_by", c.added_by);
                cmd.Parameters.AddWithValue("@ID", c.ID);
                con.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    //exe successfully
                    success = true;
                }
                //exe failed
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
        #region delete data method
        public bool delete(categoryBLL c)
        {
           
                bool success = false;
                SqlConnection con = new SqlConnection(myconstrng);

                try
                {
                    string sql = "delete from nmc_category where ID=@ID";
            
                    SqlCommand cmd = new SqlCommand(sql, con);

                    cmd.Parameters.AddWithValue("@ID", c.ID);
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
                catch (Exception ex)
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
            //con to db
            SqlConnection con = new SqlConnection(myconstrng);

            DataTable dt = new DataTable();

            try
            {
                //sql query
                string sql = "select * from nmc_category where ID like '%"+keywords+ "%' or title like '%" + keywords + "%' or description like '%" + keywords + "%'";

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
    }
}
