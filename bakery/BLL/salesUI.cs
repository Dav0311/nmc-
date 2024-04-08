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
using System.Data.SqlClient;
using System.Configuration;

namespace bakery.ui
{
    public partial class salesUI : Form
    {
        /// <summary>
        /// This method is for  the sales UI.
        /// </summary>
        public salesUI()
        {
            InitializeComponent();
        }
        //contsrng (hard code)
        //SqlConnection conn = new SqlConnection("Data source=.; initial catalog=nmc; Integrated security=true");
        static string myconstrng = ConfigurationManager.ConnectionStrings["constrng"].ConnectionString;
        //
        categoryBLL c = new categoryBLL();
        categoryDAL cdal = new categoryDAL();
        productBLL p = new productBLL();
        productDAL pdal = new productDAL();
        saledetailsBLL s = new saledetailsBLL();
        saledetailsDAL sdal = new saledetailsDAL();
        userBLL u = new userBLL();
        userDAL udal = new userDAL();
        

        //dgv wont be set in add click event cos it wont show both prds
        //create global dt
        DataTable salesDT = new DataTable();

        /* private void txtsearch_TextChanged(object sender, EventArgs e)
         {
             //get values
             string keyword = txtsearch.Text;

             if (keyword == "")
             {
                 txtprdname.Text = "";
                 txtrate.Text = "";


                 return;
             }
             //search the product and display in txtbx
             productBLL p = pdal.getproductforsales(keyword);

             //set values into textbx
             txtprdname.Text = p.name;
             txtrate.Text = p.rate.ToString();
         }*/

        private void btnadd_Click(object sender, EventArgs e)
        {
            //get prd name, rate and qty
            string prdname = cmbproduct.Text;
            decimal rate = decimal.Parse(cmbrate.Text);
            decimal qty = decimal.Parse(txtqty.Text);

            //calc for total
            decimal total = rate * qty;
            //display subtotal in txt
            //get the total value from dgv
            decimal subtotal = decimal.Parse(txtsubtotal.Text);
            subtotal = subtotal + total;

            //customer name
            string customer = txtcustcontact.Text;

            //check whether the prd is selected
            if (prdname == "")
            {
                //display error mssg
                MessageBox.Show("select product first and try again");
            }
            else
            {

                //add prd to dgv
                salesDT.Rows.Add(prdname, rate, qty, total);
                //display in dgv
                dgvsales.DataSource = salesDT;
                //display the subtotal in txt
                txtsubtotal.Text = subtotal.ToString();

               

            }
        }

        private void salesUI_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myconstrng);

            SqlDataAdapter da = new SqlDataAdapter("select distinct nmc_category.title from nmc_category", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbcategory.DataSource = dt;
            cmbcategory.DisplayMember = "title";
            cmbcategory.ValueMember = "title";
            cmbcategory.Text = "select category";

            //display category in cmbcat
            /* categoryDAL cdal = new categoryDAL();
             DataTable catdt = cdal.select();
             cmbcategory.DataSource = catdt;
             cmbcategory.DisplayMember = "title";
             cmbcategory.ValueMember = "title";
             */



            //display username
            lbluser.Text = loginUI.loggedin;


            //specifying column for salesdt
            salesDT.Columns.Add("Product name");
            salesDT.Columns.Add("Rate");
            salesDT.Columns.Add("Qty");
            salesDT.Columns.Add("Total");
            //salesDT.Columns.Add("customer name");

            //crystal report load

        }

        /* private void txtdiscount_TextChanged(object sender, EventArgs e)
         {
             //get the value from  discount txtbx
             string value = txtdiscount.Text;

             if (value == "")
             {
                 //display error msgg
                 MessageBox.Show("verify if commission was added.");

             }
             else
             {
                 //get the discount in decimal value
                 decimal subtotal = decimal.Parse(txtsubtotal.Text);
                 decimal discount = decimal.Parse(txtdiscount.Text);

                 //calc the grandtotal
                 decimal grandtotal = ((100 - discount) / 100)*subtotal;
                 //display grandtotal in txtbx
                 txtgrndtotal.Text = grandtotal.ToString();
             }
         }*/

        private void txtpaidamount_TextChanged(object sender, EventArgs e)
        {
            string value = txtpaidamount.Text;
            if (value == "")
            {
                // MessageBox.Show("please insert paid amount.");
            }
            else
            {
                //getting paid amount with grandtotal
                // decimal grandtotal = Math.Round(decimal.Parse(txtgrndtotal.Text.ToString()),2);
                decimal subtotal = decimal.Parse(txtsubtotal.Text);
                decimal paidamount = decimal.Parse(txtpaidamount.Text.ToString());

                //calc return amount
                decimal returnamount = paidamount - subtotal;
                //display in txt
                txtreturnamount.Text = returnamount.ToString();

                //display id
                //p.ID = Convert.ToInt32(txtID.Text);
                /*int id;
                if (int.TryParse(txtID.Text, out id))
                {
                    p.ID = id;
                }
                else
                {
                    // Conversion failed
                    MessageBox.Show("int conversion failed...");
                }*/
            }

        }

        private void btnsale_Click(object sender, EventArgs e)
        {


            //getting data frm txt
            s.customerNumber = txtcustcontact.Text;
            s.productName = cmbproduct.Text;
            s.rate = decimal.Parse(cmbrate.Text);
            s.qty = decimal.Parse(txtqty.Text);
            s.grandTotal = decimal.Parse(txtsubtotal.Text);
            s.added_date = DateTime.Now;
            s.balance = decimal.Parse(txtreturnamount.Text);

            //getting added by
            s.added_by = lbluser.Text;

            //inserting into db
            DateTime now = DateTime.Now;
            


            bool success = sdal.insert(s);
            //if data in inserted
             if (success == true)
             {
              // string query = "select customernumber, productName, rate, qty, grandTotal, added_date, balance, added_by   from nmc_salesDetails where ID='" + txtID.Text + "'";
                string query = "SELECT * FROM nmc_salesDetails WHERE added_date >= '" + now.ToString("yyyy-MM-dd HH:mm:ss") + "'";
                SqlDataAdapter da = new SqlDataAdapter(query, myconstrng);
            DataSet report = new DataSet();
            da.Fill(report, "nmc_salesDetails");

            receipt rpt = new receipt();
            rpt.SetDataSource(report);
            salesReportView.ReportSource = rpt;

             }
             else
             {
                 //failed to insert
                 MessageBox.Show("failed to insert new sale.");

             }

        }

        /// <summary>
        /// This method clears the sales UI.
        /// </summary>
        public void Clearing()
        {
            cmbcategory.Text = "";
            txtcustcontact.Text = "";

            cmbrate.Text = "0.00";
            txtqty.Text = "0.00";

            txtpaidamount.Text = "";
            txtreturnamount.Text = "";
            txtsubtotal.Text = "";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
            userDash user = new userDash();
            user.Show();
        }

        /* private void cmbcategory_SelectedIndexChanged(object sender, EventArgs e)
         {
             productDAL pdal = new productDAL();
             //get values
             string keyword = cmbcategory.Text;

             if (keyword == "")
             {
                 cmbproduct.Text = "";
                 txtrate.Text = "";


                 return;
             }
             //search the product and display in txtbx
             productBLL p = pdal.getproductforsales(keyword);

             //set values into textbx

             cmbproduct.Text = p.name;
             txtrate.Text = p.rate.ToString();
         }
         */


      

        private void button1_Click(object sender, EventArgs e)
        {
            int rowindex = dgvsales.CurrentCell.RowIndex;
            dgvsales.Rows.RemoveAt(rowindex);
        }

        private void cmbcategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(myconstrng);

            SqlDataAdapter da = new SqlDataAdapter("select distinct nmc_products.name from nmc_products where category like  '%" + cmbcategory.SelectedValue.ToString() + "%'", con);

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbproduct.DataSource = dt;
            cmbproduct.DisplayMember = "name";
            cmbproduct.ValueMember = "name";

        }



        private void cmbproduct_SelectionChangeCommitted(object sender, EventArgs e)
        {

            //get values
            //string keyword = cmbproduct.Text;

            /* SqlConnection con = new SqlConnection(myconstrng);

             // SqlDataAdapter da = new SqlDataAdapter("select distinct nmc_category.title from nmc_category", con);
             SqlDataAdapter da = new SqlDataAdapter("select distinct nmc_products.rate from nmc_products where category like  '%" + cmbproduct.SelectedValue.ToString() + "%'", con);

             DataTable dt = new DataTable();
             da.Fill(dt);
             comboBox1.DataSource = dt;
             comboBox1.DisplayMember = "rate";
             comboBox1.ValueMember = "rate";
            // cmbcategory.Text = "select category";*/
            /* if (cmbproduct.Text == "")
             {
                 txtrate.Text = "00.0";

                 return;
             }
             //search the product and display in txtbx
             productBLL p = pdal.getproductforsales(keyword);

             //set values into textbx


             txtrate.Text = p.rate.ToString();

            SqlConnection con = new SqlConnection(myconstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "select distinct nmc_products.rate from nmc_products where category like '%" + cmbproduct.SelectedValue.ToString() + "%'";
                // SqlDataAdapter da = new SqlDataAdapter("select distinct nmc_products.rate from nmc_products where category like  '%" + cmbproduct.SelectedValue.ToString() + "%'", con);

                //crete adapter to exe qry
                SqlDataAdapter adapter = new SqlDataAdapter(sql, con);

                con.Open();
                //pass data
                adapter.Fill(dt);

                //if we have any values in dt then set the values i prdbll
                if (dt.Rows.Count > 0)
                {


                    //p.name = dt.Rows[0]["name"].ToString();
                    p.rate = decimal.Parse(dt.Rows[0]["rate"].ToString());

                    txtrate.Text = p.rate.ToString();

                }
            }
            finally
            {
                con.Close();
            }*/

            SqlConnection con = new SqlConnection(myconstrng);

            //SqlDataAdapter da = new SqlDataAdapter("select distinct nmc_category.title from nmc_category", con);
            SqlDataAdapter da = new SqlDataAdapter("select rate from nmc_products where name like  '%" + cmbproduct.SelectedValue.ToString() + "%'", con);

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbrate.DataSource = dt;
            cmbrate.DisplayMember = "rate";
            cmbrate.ValueMember = "rate";
            // cmbcategory.Text = "select category";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          /*  SqlConnection con = new SqlConnection(myconstrng);
            if(cmbproduct.Text == "")
            {
                cmbrate.Text = "00.00";
            }
            else
            {
                
                //SqlDataAdapter da = new SqlDataAdapter("select distinct nmc_category.title from nmc_category", con);
                SqlDataAdapter da = new SqlDataAdapter("select distinct nmc_products.rate from nmc_products where name like  '%" + cmbproduct.SelectedValue.ToString() + "%'", con);

                DataTable dt = new DataTable();
                da.Fill(dt);
                cmbrate.DataSource = dt;
                cmbrate.DisplayMember = "rate";
                cmbrate.ValueMember = "rate";

                // cmbcategory.Text = "select category";
            }
            */
        }

        private void txtdiscount_TextChanged(object sender, EventArgs e)
        {

           /* string value = txtdiscount.Text;
            if (value == "")
            {
                // MessageBox.Show("please insert paid amount.");
            }
            else
            {
                //getting paid amount with grandtotal
                // decimal grandtotal = Math.Round(decimal.Parse(txtgrndtotal.Text.ToString()),2);
                decimal subtotal = decimal.Parse(txtsubtotal.Text);
                decimal discount = decimal.Parse(txtdiscount.Text);

                //calc return amount
                decimal amountdiscounted =  subtotal- discount;
                //display in txt
                txtpaidamount.Text = amountdiscounted.ToString();
            }
            */
        }

    }
}
    
   
    

