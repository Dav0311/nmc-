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
    class saledetailsDAL
    {
        static string myconstrng = ConfigurationManager.ConnectionStrings["constrng"].ConnectionString;

        #region insert data method
        public bool insert(saledetailsBLL sd)
        {
            bool success = false;
            SqlConnection con = new SqlConnection(myconstrng);
            try
            {
                string sql = "insert into nmc_salesDetails (customerNumber, productName, rate, qty, grandTotal, balance, added_date, added_by) values(@customerName, @productName, @rate, @qty, @grandTotal, @balance, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@customerName", sd.customerNumber);
                cmd.Parameters.AddWithValue("@productName", sd.productName);
                cmd.Parameters.AddWithValue("@rate", sd.rate);
                cmd.Parameters.AddWithValue("@qty", sd.qty);
                cmd.Parameters.AddWithValue("@balance", sd.balance);
                cmd.Parameters.AddWithValue("@grandTotal", sd.grandTotal);
                cmd.Parameters.AddWithValue("@added_date", sd.added_date);
                cmd.Parameters.AddWithValue("@added_by", sd.added_by);
               

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
        #region select data method
        public DataTable select()
        {
            //con to db
            SqlConnection con = new SqlConnection(myconstrng);

            DataTable dt = new DataTable();

            try
            {
                //sql query
                string sql = "select * from nmc_salesDetails";
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

        #region creditors

        public DataTable selectcredit()
        {
            //con to db
            SqlConnection con = new SqlConnection(myconstrng);

            DataTable dt = new DataTable();

            try
            {
                //sql query
                string sql = "select * from nmc_salesDetails where balance < 0 ";
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

    }
}
