using bakery.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bakery.DAL
{
    class expenseDAL
    {
        //static string for db
        static string myconstrng = ConfigurationManager.ConnectionStrings["constrng"].ConnectionString;

        #region select data from db
        public DataTable select()
        {
            //con to db
            SqlConnection con = new SqlConnection(myconstrng);

            DataTable dt = new DataTable();

            try
            {
                //sql query
                string sql = "select * from nmc_expense";
                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd); con.Open();
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

        #region insert data
        public bool insert(expenseBLL e)
        {
            //craetin bool and setting default value to false
            bool success = false;
            SqlConnection con = new SqlConnection(myconstrng);

            try
            {
                string sql = "insert into nmc_expense (name, cost, qty, added_date, added_by) values (@name, @cost, @qty, @added_date, @added_by) ";

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@name", e.name);
                cmd.Parameters.AddWithValue("@cost", e.cost);
                cmd.Parameters.AddWithValue("@qty", e.qty);
                cmd.Parameters.AddWithValue("@added_date", e.added_date);
                cmd.Parameters.AddWithValue("@added_by", e.added_by);

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

        #region update data
        public bool update(expenseBLL e)
        {
            //create bool and set value to false
            bool success = false;
            //create sql con
            SqlConnection con = new SqlConnection(myconstrng);
            try
            {
                string sql = "update nmc_expense set name=@name, cost=@cost, qty=@qty, added_date=@added_date, added_by=@added_by where ID=@ID";

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@name", e.name);
                cmd.Parameters.AddWithValue("@cost", e.cost);
                cmd.Parameters.AddWithValue("@qty", e.qty);
                cmd.Parameters.AddWithValue("@added_date", e.added_date);
                cmd.Parameters.AddWithValue("@added_by", e.added_by);
                cmd.Parameters.AddWithValue("@ID", e.ID);
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
        
        #region delete data method
        public bool delete(expenseBLL e)
        {
            bool success = false;
            SqlConnection con = new SqlConnection(myconstrng);

            try
            {
                string sql = "delete from nmc_expense where ID=@ID";

                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@ID", e.ID);

                con.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                //exe successfully
                {
                    success = true;
                }
                //exe failed
                else
                {
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

        #region search data
        public DataTable search(string keywords)
        {
            //con to db
            SqlConnection con = new SqlConnection(myconstrng);

            DataTable dt = new DataTable();

            try
            {
                //sql query
                string sql = "select * from nmc_expense where ID like '%" + keywords + "%' or name like '%" + keywords + "%' or cost like '%" + keywords + "%'";

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
