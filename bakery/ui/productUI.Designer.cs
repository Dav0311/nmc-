namespace bakery.ui
{
    partial class productUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productUI));
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.dgvproduct = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.lbldescription = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.txtproductid = new System.Windows.Forms.TextBox();
            this.lblprdID = new System.Windows.Forms.Label();
            this.lblcat = new System.Windows.Forms.Label();
            this.cmbcat = new System.Windows.Forms.ComboBox();
            this.txtrate = new System.Windows.Forms.TextBox();
            this.lblrate = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.lblqty = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(455, 132);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(464, 29);
            this.txtsearch.TabIndex = 23;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Location = new System.Drawing.Point(375, 137);
            this.lblsearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(55, 21);
            this.lblsearch.TabIndex = 22;
            this.lblsearch.Text = "search";
            // 
            // dgvproduct
            // 
            this.dgvproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduct.Location = new System.Drawing.Point(376, 170);
            this.dgvproduct.Name = "dgvproduct";
            this.dgvproduct.Size = new System.Drawing.Size(543, 258);
            this.dgvproduct.TabIndex = 21;
            this.dgvproduct.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvproduct_RowHeaderMouseClick);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btndelete.Location = new System.Drawing.Point(811, 447);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 40);
            this.btndelete.TabIndex = 20;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnupdate.Location = new System.Drawing.Point(623, 447);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(75, 40);
            this.btnupdate.TabIndex = 19;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnadd.Location = new System.Drawing.Point(436, 447);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 40);
            this.btnadd.TabIndex = 18;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(127, 291);
            this.txtdescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(205, 91);
            this.txtdescription.TabIndex = 17;
            // 
            // lbldescription
            // 
            this.lbldescription.AutoSize = true;
            this.lbldescription.Location = new System.Drawing.Point(32, 294);
            this.lbldescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbldescription.Name = "lbldescription";
            this.lbldescription.Size = new System.Drawing.Size(87, 21);
            this.lbldescription.TabIndex = 16;
            this.lbldescription.Text = "description";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(130, 179);
            this.txtname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(205, 29);
            this.txtname.TabIndex = 15;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(32, 184);
            this.lblname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(49, 21);
            this.lblname.TabIndex = 14;
            this.lblname.Text = "name";
            // 
            // txtproductid
            // 
            this.txtproductid.Location = new System.Drawing.Point(130, 121);
            this.txtproductid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.ReadOnly = true;
            this.txtproductid.Size = new System.Drawing.Size(205, 29);
            this.txtproductid.TabIndex = 13;
            // 
            // lblprdID
            // 
            this.lblprdID.AutoSize = true;
            this.lblprdID.Location = new System.Drawing.Point(32, 129);
            this.lblprdID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblprdID.Name = "lblprdID";
            this.lblprdID.Size = new System.Drawing.Size(83, 21);
            this.lblprdID.TabIndex = 12;
            this.lblprdID.Text = "product ID";
            // 
            // lblcat
            // 
            this.lblcat.AutoSize = true;
            this.lblcat.Location = new System.Drawing.Point(32, 236);
            this.lblcat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcat.Name = "lblcat";
            this.lblcat.Size = new System.Drawing.Size(70, 21);
            this.lblcat.TabIndex = 24;
            this.lblcat.Text = "category";
            // 
            // cmbcat
            // 
            this.cmbcat.FormattingEnabled = true;
            this.cmbcat.Location = new System.Drawing.Point(127, 236);
            this.cmbcat.Name = "cmbcat";
            this.cmbcat.Size = new System.Drawing.Size(208, 29);
            this.cmbcat.TabIndex = 26;
            // 
            // txtrate
            // 
            this.txtrate.Location = new System.Drawing.Point(127, 405);
            this.txtrate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtrate.Name = "txtrate";
            this.txtrate.Size = new System.Drawing.Size(205, 29);
            this.txtrate.TabIndex = 28;
            // 
            // lblrate
            // 
            this.lblrate.AutoSize = true;
            this.lblrate.Location = new System.Drawing.Point(29, 410);
            this.lblrate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrate.Name = "lblrate";
            this.lblrate.Size = new System.Drawing.Size(37, 21);
            this.lblrate.TabIndex = 27;
            this.lblrate.Text = "rate";
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(127, 447);
            this.txtqty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(205, 29);
            this.txtqty.TabIndex = 30;
            // 
            // lblqty
            // 
            this.lblqty.AutoSize = true;
            this.lblqty.Location = new System.Drawing.Point(29, 452);
            this.lblqty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(67, 21);
            this.lblqty.TabIndex = 29;
            this.lblqty.Text = "quantity";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(937, 76);
            this.panel3.TabIndex = 31;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(871, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(399, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Products";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.DarkRed;
            this.lbluser.Location = new System.Drawing.Point(704, 104);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(48, 21);
            this.lbluser.TabIndex = 33;
            this.lbluser.Text = "USER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(542, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 30);
            this.label4.TabIndex = 32;
            this.label4.Text = "logged in user:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 498);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(937, 76);
            this.panel2.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "nmc billing system";
            // 
            // productUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 574);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.lblqty);
            this.Controls.Add(this.txtrate);
            this.Controls.Add(this.lblrate);
            this.Controls.Add(this.cmbcat);
            this.Controls.Add(this.lblcat);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.dgvproduct);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.lbldescription);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtproductid);
            this.Controls.Add(this.lblprdID);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "productUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "productUI";
            this.Load += new System.EventHandler(this.productUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.DataGridView dgvproduct;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label lbldescription;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtproductid;
        private System.Windows.Forms.Label lblprdID;
        private System.Windows.Forms.Label lblcat;
        private System.Windows.Forms.ComboBox cmbcat;
        private System.Windows.Forms.TextBox txtrate;
        private System.Windows.Forms.Label lblrate;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label lblqty;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}