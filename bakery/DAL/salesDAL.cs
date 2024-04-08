using bakery.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bakery.DAL
{
    class salesDAL
    {
        static string myconstrng = ConfigurationManager.ConnectionStrings["constrng"].ConnectionString;

        #region insertTransaction
        public bool insertSale(salesBLL s)
        {

            bool success = false;
            SqlConnection con = new SqlConnection(myconstrng);
            try
            {
                string sql = "insert into nmc_transactions (customerNumber, grandTotal, transactionDate, added_by, rate, qty, balance) values(@customerNumber, @grandTotal, @transactionDate, @added_by, @rate, @qty, @balance)";
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@customerNumber", s.customerNumber);
                cmd.Parameters.AddWithValue("@grandTotal", s.grandTotal);
                cmd.Parameters.AddWithValue("@transactionDate", s.transactionDate);
                
                cmd.Parameters.AddWithValue("@added_by", s.added_by);
                cmd.Parameters.AddWithValue("@rate", s.rate);
                cmd.Parameters.AddWithValue("@qty", s.qty);
                cmd.Parameters.AddWithValue("@balance", s.balance);



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
        
    }
}
