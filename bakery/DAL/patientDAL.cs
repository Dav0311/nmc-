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
    class patientDAL

    {
        //strng mthd for db con
        static string myconstrng = ConfigurationManager.ConnectionStrings["constrng"].ConnectionString;

        #region insert patients
        public bool insert(patientBLL p)
        {
            //sql con
            SqlConnection con = new SqlConnection(myconstrng);

            //craete bool var and set its default to false
            bool success = false;

            try
            {
                //sql query
                string sql = "insert into nmc_patients (visitDate, patient_firstName, patient_lastName, occupation, residence, consultant, ms_history, lab_tests, diagnosis, added_by ) values(@visitDate, @patient_firstName, @patient_lastName, @occupation, @residence, @consultant, @ms_history, @lab_tests, @diagnosis, @added_by)";

                //sql cmd 
                SqlCommand cmd = new SqlCommand(sql, con);
                //passing values using parametters
                cmd.Parameters.AddWithValue("@visitDate", p.visitDate);
                cmd.Parameters.AddWithValue("@patient_firstName", p.patient_firstName);
                cmd.Parameters.AddWithValue("@patient_lastName", p.patient_lastName);
                cmd.Parameters.AddWithValue("@occupation", p.occupation);
                cmd.Parameters.AddWithValue("@residence", p.residence);
                cmd.Parameters.AddWithValue("@consultant", p.consultant);
                cmd.Parameters.AddWithValue("@ms_history", p.ms_history);
                cmd.Parameters.AddWithValue("@lab_tests", p.lab_tests);
                cmd.Parameters.AddWithValue("@diagnosis", p.diagnosis);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);

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

        internal patientBLL Search(object keywords)
        {
            throw new NotImplementedException();
        }
        #endregion
        #region search for patients for load form
        public DataTable search(string keywords)
        {
            SqlConnection con = new SqlConnection(myconstrng);

            DataTable dt = new DataTable();
            try
            {
                string sql = "select * from nmc_patients where ID like '%" + keywords + "%' or patient_firstName like '%" + keywords + "%' or patinet_lastName like '%" + keywords + "%' ";
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
        #region select patient forms
        public DataTable select()
        {
            //con to db
            SqlConnection con = new SqlConnection(myconstrng);

            DataTable dt = new DataTable();

            try
            {
                //sql query
                string sql = "select * from nmc_patients";
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
        #region search data method
        public DataTable Search(string keywords)
        {
            //sql con
            SqlConnection con = new SqlConnection(myconstrng);
            //create dt and return it
            DataTable dt = new DataTable();

            try
            {
                //sql query to select data
                string sql = "select * from nmc_patients where patient_firstName like '%" + keywords + "%' or patient_lastName like '%" + keywords + "%' ";

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
        #region search for patient info
        public patientBLL getpatientsdetails(string keyword)
        {
            patientBLL p = new patientBLL();
            SqlConnection con = new SqlConnection(myconstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "select ID, patient_firstName, patient_lastName, occupation, residence from nmc_patients where id like  '%" + keyword + "%' or patient_firstName like  '%" + keyword + "%' or patient_lastName like  '%" + keyword + "%'";
                //craete adapter to exe qry
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

                con.Open();
                //pass data
                adapter.Fill(dt);

                //if we have any values in dt then set the values i prdbll
                if (dt.Rows.Count > 0)
                {
                    
                    p.ID = int.Parse(dt.Rows[0]["ID"].ToString());
                    p.patient_firstName = dt.Rows[0]["patient_firstName"].ToString();
                   // p.visitDate = dt.Rows[0]["visitDate"];
                    p.patient_lastName = dt.Rows[0]["patient_lastName"].ToString();
                    p.occupation = dt.Rows[0]["occupation"].ToString();
                    p.residence = dt.Rows[0]["residence"].ToString();
                   
                    

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
            return p;

        }
#endregion
    }
}
