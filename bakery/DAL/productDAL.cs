using bakery.BLL;
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace bakery.DAL
{
    class productDAL
    {
        //craeting static string mthd
        static string myconstrng = ConfigurationManager.ConnectionStrings["constrng"].ConnectionString;
        #region select data from db
        public DataTable select()
        {
            //create con
            SqlConnection con = new SqlConnection(myconstrng);
            //create dt to hold the data from db
            DataTable dt = new DataTable();

            try
            {
                string sql = "select * from nmc_products";
                SqlCommand cmd = new SqlCommand(sql, con);

                //adapter to hold the data temp
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
        #region insert data method
        public bool insert(productBLL p)
        {
            //creating bool var set default var to false
            bool success = false;
            //create con
            SqlConnection con = new SqlConnection(myconstrng);
            try
            {
                //insert query
                string sql = "insert into nmc_products (name, category, description, rate, qty, added_date, added_by) values (@name, @category, @description, @rate, @qty, @added_date, @added_by)";

                //craeting sql cmd to pass values
                SqlCommand cmd = new SqlCommand(sql, con);

                //pssing valus using parametrs
                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);

                //open con
                con.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    //qyery exe succeessfully
                    success = true;
                }
                else
                {
                    //query exe failed
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
        #region update data method
        public bool update(productBLL p)
        {
            //craete bool var and set its default to false
            bool success = false;
            //creat con for db
            SqlConnection con = new SqlConnection(myconstrng);

            try
            {
                string sql = "update nmc_products set name=@name, category=@category, description=@description, rate=@rate, qty=@qty, added_date=@added_date, added_by=@added_by where ID=@ID";

                //craete sql command
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@name", p.name);
                cmd.Parameters.AddWithValue("@category", p.category);
                cmd.Parameters.AddWithValue("@description", p.description);
                cmd.Parameters.AddWithValue("@rate", p.rate);
                cmd.Parameters.AddWithValue("@qty", p.qty);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);
                cmd.Parameters.AddWithValue("@ID", p.ID);

                con.Open();
                //craete int to check if its exe
                int rows = cmd.ExecuteNonQuery();

                //exe=>0 failed <0
                if (rows > 0)
                {
                    //success
                    success = true;
                }
                else
                {
                    //failed
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
        public bool delete(productBLL p)
        {
            //create bool var and set default to false
            bool success = false;
            //create sql con
            SqlConnection con = new SqlConnection(myconstrng);

            try
            {
                string sql = "delete from nmc_products where ID=@ID";

                //create sql cmd to pass data
                SqlCommand cmd = new SqlCommand(sql, con);

                cmd.Parameters.AddWithValue("@ID", p.ID);

                con.Open();

                int rows = cmd.ExecuteNonQuery();
                //if exe value is >0
                if (rows > 0)
                {
                    //success
                    success = true;
                }
                else
                {
                    //failure
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
            //create con
            SqlConnection con = new SqlConnection(myconstrng);
            //create dt to hold the data from db
            DataTable dt = new DataTable();

            try
            {
                string sql = "select * from nmc_products where ID like '%" + keywords + "%' or name like '%" + keywords + "%' or category like '%" + keywords + "%' or description like '%" + keywords + "%' or rate like '%" + keywords + "%'";
                SqlCommand cmd = new SqlCommand(sql, con);

                //adapter to hold the data temp
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
        #region search for prd
        public productBLL getproductforsales(string keyword)
        {
            productBLL p = new productBLL();
            SqlConnection con = new SqlConnection(myconstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql="select name, rate from nmc_products where category like  '%" + keyword + "%'";
                //crete adapter to exe qry
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

                con.Open();
                //pass data
                adapter.Fill(dt);

                //if we have any values in dt then set the values i prdbll
                if (dt.Rows.Count > 0)
                {

                    
                    p.name = dt.Rows[0]["name"].ToString();
                    p.rate = decimal.Parse(dt.Rows[1]["rate"].ToString());

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
            return p;

        }
        #endregion
    }
}
