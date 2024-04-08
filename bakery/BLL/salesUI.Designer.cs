namespace bakery.ui
{
    partial class salesUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(salesUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbrate = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cmbproduct = new System.Windows.Forms.ComboBox();
            this.txtcustcontact = new System.Windows.Forms.TextBox();
            this.cmbcategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblcustname = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.lblqty = new System.Windows.Forms.Label();
            this.lblrate = new System.Windows.Forms.Label();
            this.lblprdname = new System.Windows.Forms.Label();
            this.lblsearchcust = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnsale = new System.Windows.Forms.Button();
            this.lblcalc = new System.Windows.Forms.Label();
            this.txtreturnamount = new System.Windows.Forms.TextBox();
            this.lblreturnamount = new System.Windows.Forms.Label();
            this.txtpaidamount = new System.Windows.Forms.TextBox();
            this.lblpaidamount = new System.Windows.Forms.Label();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.salesReportView = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lbluser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbldgv = new System.Windows.Forms.Label();
            this.dgvsales = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1238, 64);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1176, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(624, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sales";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.cmbrate);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.cmbproduct);
            this.panel2.Controls.Add(this.txtcustcontact);
            this.panel2.Controls.Add(this.cmbcategory);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblcustname);
            this.panel2.Controls.Add(this.btnadd);
            this.panel2.Controls.Add(this.txtqty);
            this.panel2.Controls.Add(this.lblqty);
            this.panel2.Controls.Add(this.lblrate);
            this.panel2.Controls.Add(this.lblprdname);
            this.panel2.Controls.Add(this.lblsearchcust);
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 273);
            this.panel2.TabIndex = 1;
            // 
            // cmbrate
            // 
            this.cmbrate.FormattingEnabled = true;
            this.cmbrate.Location = new System.Drawing.Point(89, 158);
            this.cmbrate.Name = "cmbrate";
            this.cmbrate.Size = new System.Drawing.Size(136, 28);
            this.cmbrate.TabIndex = 19;
            this.cmbrate.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(19, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 52);
            this.button1.TabIndex = 17;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbproduct
            // 
            this.cmbproduct.FormattingEnabled = true;
            this.cmbproduct.Location = new System.Drawing.Point(137, 86);
            this.cmbproduct.Name = "cmbproduct";
            this.cmbproduct.Size = new System.Drawing.Size(270, 28);
            this.cmbproduct.TabIndex = 16;
            this.cmbproduct.SelectionChangeCommitted += new System.EventHandler(this.cmbproduct_SelectionChangeCommitted);
            // 
            // txtcustcontact
            // 
            this.txtcustcontact.Location = new System.Drawing.Point(138, 120);
            this.txtcustcontact.Name = "txtcustcontact";
            this.txtcustcontact.Size = new System.Drawing.Size(269, 27);
            this.txtcustcontact.TabIndex = 15;
            // 
            // cmbcategory
            // 
            this.cmbcategory.FormattingEnabled = true;
            this.cmbcategory.Location = new System.Drawing.Point(137, 52);
            this.cmbcategory.Name = "cmbcategory";
            this.cmbcategory.Size = new System.Drawing.Size(270, 28);
            this.cmbcategory.TabIndex = 14;
            this.cmbcategory.SelectionChangeCommitted += new System.EventHandler(this.cmbcategory_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Product insert panel";
            // 
            // lblcustname
            // 
            this.lblcustname.AutoSize = true;
            this.lblcustname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcustname.Location = new System.Drawing.Point(10, 125);
            this.lblcustname.Name = "lblcustname";
            this.lblcustname.Size = new System.Drawing.Size(102, 17);
            this.lblcustname.TabIndex = 11;
            this.lblcustname.Text = " customer name";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(144, 202);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(270, 52);
            this.btnadd.TabIndex = 10;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // txtqty
            // 
            this.txtqty.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqty.Location = new System.Drawing.Point(272, 158);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(138, 27);
            this.txtqty.TabIndex = 9;
            // 
            // lblqty
            // 
            this.lblqty.AutoSize = true;
            this.lblqty.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqty.Location = new System.Drawing.Point(231, 163);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(32, 17);
            this.lblqty.TabIndex = 8;
            this.lblqty.Text = "QTY";
            // 
            // lblrate
            // 
            this.lblrate.AutoSize = true;
            this.lblrate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrate.Location = new System.Drawing.Point(45, 163);
            this.lblrate.Name = "lblrate";
            this.lblrate.Size = new System.Drawing.Size(38, 17);
            this.lblrate.TabIndex = 4;
            this.lblrate.Text = "RATE";
            // 
            // lblprdname
            // 
            this.lblprdname.AutoSize = true;
            this.lblprdname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprdname.Location = new System.Drawing.Point(16, 91);
            this.lblprdname.Name = "lblprdname";
            this.lblprdname.Size = new System.Drawing.Size(90, 17);
            this.lblprdname.TabIndex = 2;
            this.lblprdname.Text = "product name";
            // 
            // lblsearchcust
            // 
            this.lblsearchcust.AutoSize = true;
            this.lblsearchcust.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearchcust.Location = new System.Drawing.Point(16, 52);
            this.lblsearchcust.Name = "lblsearchcust";
            this.lblsearchcust.Size = new System.Drawing.Size(101, 17);
            this.lblsearchcust.TabIndex = 0;
            this.lblsearchcust.Text = "search category";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.btnsale);
            this.panel3.Controls.Add(this.lblcalc);
            this.panel3.Controls.Add(this.txtreturnamount);
            this.panel3.Controls.Add(this.lblreturnamount);
            this.panel3.Controls.Add(this.txtpaidamount);
            this.panel3.Controls.Add(this.lblpaidamount);
            this.panel3.Controls.Add(this.txtsubtotal);
            this.panel3.Controls.Add(this.lblsubtotal);
            this.panel3.Location = new System.Drawing.Point(0, 349);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(425, 266);
            this.panel3.TabIndex = 2;
            // 
            // btnsale
            // 
            this.btnsale.BackColor = System.Drawing.Color.SkyBlue;
            this.btnsale.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsale.Location = new System.Drawing.Point(19, 206);
            this.btnsale.Name = "btnsale";
            this.btnsale.Size = new System.Drawing.Size(388, 46);
            this.btnsale.TabIndex = 11;
            this.btnsale.Text = "COMPLETE SALE";
            this.btnsale.UseVisualStyleBackColor = false;
            this.btnsale.Click += new System.EventHandler(this.btnsale_Click);
            // 
            // lblcalc
            // 
            this.lblcalc.AutoSize = true;
            this.lblcalc.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalc.Location = new System.Drawing.Point(46, 14);
            this.lblcalc.Name = "lblcalc";
            this.lblcalc.Size = new System.Drawing.Size(149, 25);
            this.lblcalc.TabIndex = 2;
            this.lblcalc.Text = "calculation view";
            // 
            // txtreturnamount
            // 
            this.txtreturnamount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtreturnamount.Location = new System.Drawing.Point(162, 160);
            this.txtreturnamount.Name = "txtreturnamount";
            this.txtreturnamount.ReadOnly = true;
            this.txtreturnamount.Size = new System.Drawing.Size(248, 39);
            this.txtreturnamount.TabIndex = 22;
            // 
            // lblreturnamount
            // 
            this.lblreturnamount.AutoSize = true;
            this.lblreturnamount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblreturnamount.Location = new System.Drawing.Point(85, 172);
            this.lblreturnamount.Name = "lblreturnamount";
            this.lblreturnamount.Size = new System.Drawing.Size(66, 21);
            this.lblreturnamount.TabIndex = 21;
            this.lblreturnamount.Text = "Balance";
            // 
            // txtpaidamount
            // 
            this.txtpaidamount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpaidamount.Location = new System.Drawing.Point(166, 97);
            this.txtpaidamount.Name = "txtpaidamount";
            this.txtpaidamount.Size = new System.Drawing.Size(248, 35);
            this.txtpaidamount.TabIndex = 20;
            this.txtpaidamount.TextChanged += new System.EventHandler(this.txtpaidamount_TextChanged);
            // 
            // lblpaidamount
            // 
            this.lblpaidamount.AutoSize = true;
            this.lblpaidamount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpaidamount.Location = new System.Drawing.Point(59, 107);
            this.lblpaidamount.Name = "lblpaidamount";
            this.lblpaidamount.Size = new System.Drawing.Size(101, 21);
            this.lblpaidamount.TabIndex = 19;
            this.lblpaidamount.Text = "Paid amount";
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsubtotal.Location = new System.Drawing.Point(162, 42);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.ReadOnly = true;
            this.txtsubtotal.Size = new System.Drawing.Size(248, 27);
            this.txtsubtotal.TabIndex = 12;
            this.txtsubtotal.Text = "0";
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.AutoSize = true;
            this.lblsubtotal.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsubtotal.Location = new System.Drawing.Point(113, 46);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(43, 21);
            this.lblsubtotal.TabIndex = 11;
            this.lblsubtotal.Text = "Cost";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.txtID);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.button2);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.lbluser);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.lbldgv);
            this.panel4.Controls.Add(this.dgvsales);
            this.panel4.Location = new System.Drawing.Point(431, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(799, 545);
            this.panel4.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(613, 19);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(138, 27);
            this.txtID.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(572, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 38;
            this.label5.Text = "ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(676, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 37;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.salesReportView);
            this.panel5.Location = new System.Drawing.Point(413, 108);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(360, 394);
            this.panel5.TabIndex = 36;
            // 
            // salesReportView
            // 
            this.salesReportView.ActiveViewIndex = -1;
            this.salesReportView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.salesReportView.Cursor = System.Windows.Forms.Cursors.Default;
            this.salesReportView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.salesReportView.Location = new System.Drawing.Point(0, 0);
            this.salesReportView.Name = "salesReportView";
            this.salesReportView.Size = new System.Drawing.Size(360, 394);
            this.salesReportView.TabIndex = 0;
            this.salesReportView.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.DarkRed;
            this.lbluser.Location = new System.Drawing.Point(169, 21);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(48, 21);
            this.lbluser.TabIndex = 35;
            this.lbluser.Text = "USER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 30);
            this.label4.TabIndex = 34;
            this.label4.Text = "logged in user:";
            // 
            // lbldgv
            // 
            this.lbldgv.AutoSize = true;
            this.lbldgv.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldgv.Location = new System.Drawing.Point(358, 70);
            this.lbldgv.Name = "lbldgv";
            this.lbldgv.Size = new System.Drawing.Size(115, 25);
            this.lbldgv.TabIndex = 1;
            this.lbldgv.Text = "SALES VIEW";
            // 
            // dgvsales
            // 
            this.dgvsales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsales.Location = new System.Drawing.Point(12, 108);
            this.dgvsales.Name = "dgvsales";
            this.dgvsales.Size = new System.Drawing.Size(382, 423);
            this.dgvsales.TabIndex = 0;
            // 
            // salesUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1238, 620);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "salesUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "salesUI";
            this.Load += new System.EventHandler(this.salesUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvsales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgvsales;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label lblqty;
        private System.Windows.Forms.Label lblrate;
        private System.Windows.Forms.Label lblprdname;
        private System.Windows.Forms.Label lblsearchcust;
        private System.Windows.Forms.Label lblcalc;
        private System.Windows.Forms.TextBox txtreturnamount;
        private System.Windows.Forms.Label lblreturnamount;
        private System.Windows.Forms.TextBox txtpaidamount;
        private System.Windows.Forms.Label lblpaidamount;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label lblsubtotal;
        private System.Windows.Forms.Label lbldgv;
        private System.Windows.Forms.Button btnsale;
        private System.Windows.Forms.Label lblcustname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbcategory;
        private System.Windows.Forms.TextBox txtcustcontact;
        private System.Windows.Forms.ComboBox cmbproduct;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cmbrate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel5;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer salesReportView;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label5;
    }
}