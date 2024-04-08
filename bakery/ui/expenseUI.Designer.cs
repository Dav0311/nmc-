namespace bakery.ui
{
    partial class expenseUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(expenseUI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblqty = new System.Windows.Forms.Label();
            this.txtqty = new System.Windows.Forms.TextBox();
            this.lblcost = new System.Windows.Forms.Label();
            this.txtcost = new System.Windows.Forms.TextBox();
            this.lblname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.lblexpenseID = new System.Windows.Forms.Label();
            this.txtexpID = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.lblsearch = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.dgvexpense = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvexpense)).BeginInit();
            this.panel2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(971, 76);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(901, 12);
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
            this.label2.Location = new System.Drawing.Point(412, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Expenditure";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.DarkRed;
            this.lbluser.Location = new System.Drawing.Point(186, 112);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(48, 21);
            this.lbluser.TabIndex = 42;
            this.lbluser.Text = "USER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 30);
            this.label4.TabIndex = 41;
            this.label4.Text = "logged in user:";
            // 
            // lblqty
            // 
            this.lblqty.AutoSize = true;
            this.lblqty.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblqty.Location = new System.Drawing.Point(26, 350);
            this.lblqty.Name = "lblqty";
            this.lblqty.Size = new System.Drawing.Size(56, 17);
            this.lblqty.TabIndex = 38;
            this.lblqty.Text = "Quantity";
            // 
            // txtqty
            // 
            this.txtqty.Location = new System.Drawing.Point(154, 344);
            this.txtqty.Name = "txtqty";
            this.txtqty.Size = new System.Drawing.Size(176, 20);
            this.txtqty.TabIndex = 37;
            // 
            // lblcost
            // 
            this.lblcost.AutoSize = true;
            this.lblcost.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcost.Location = new System.Drawing.Point(26, 294);
            this.lblcost.Name = "lblcost";
            this.lblcost.Size = new System.Drawing.Size(34, 17);
            this.lblcost.TabIndex = 36;
            this.lblcost.Text = "Cost";
            // 
            // txtcost
            // 
            this.txtcost.Location = new System.Drawing.Point(154, 288);
            this.txtcost.Name = "txtcost";
            this.txtcost.Size = new System.Drawing.Size(176, 20);
            this.txtcost.TabIndex = 35;
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(26, 236);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(43, 17);
            this.lblname.TabIndex = 34;
            this.lblname.Text = "Name";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(154, 230);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(176, 20);
            this.txtname.TabIndex = 33;
            // 
            // lblexpenseID
            // 
            this.lblexpenseID.AutoSize = true;
            this.lblexpenseID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblexpenseID.Location = new System.Drawing.Point(26, 182);
            this.lblexpenseID.Name = "lblexpenseID";
            this.lblexpenseID.Size = new System.Drawing.Size(72, 17);
            this.lblexpenseID.TabIndex = 32;
            this.lblexpenseID.Text = "Expense ID";
            // 
            // txtexpID
            // 
            this.txtexpID.Location = new System.Drawing.Point(154, 179);
            this.txtexpID.Name = "txtexpID";
            this.txtexpID.ReadOnly = true;
            this.txtexpID.Size = new System.Drawing.Size(176, 20);
            this.txtexpID.TabIndex = 31;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.SkyBlue;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(842, 437);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 39);
            this.btndelete.TabIndex = 48;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.SkyBlue;
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(636, 437);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(91, 39);
            this.btnupdate.TabIndex = 47;
            this.btnupdate.Text = "UPDATE";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.SkyBlue;
            this.btnadd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(439, 437);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 39);
            this.btnadd.TabIndex = 46;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.Location = new System.Drawing.Point(416, 118);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(46, 17);
            this.lblsearch.TabIndex = 45;
            this.lblsearch.Text = "search";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(538, 111);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(406, 20);
            this.txtsearch.TabIndex = 44;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // dgvexpense
            // 
            this.dgvexpense.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvexpense.Location = new System.Drawing.Point(406, 166);
            this.dgvexpense.Name = "dgvexpense";
            this.dgvexpense.Size = new System.Drawing.Size(540, 252);
            this.dgvexpense.TabIndex = 43;
            this.dgvexpense.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvexpense_RowHeaderMouseClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 494);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 76);
            this.panel2.TabIndex = 49;
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
            // expenseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 570);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dgvexpense);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblqty);
            this.Controls.Add(this.txtqty);
            this.Controls.Add(this.lblcost);
            this.Controls.Add(this.txtcost);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblexpenseID);
            this.Controls.Add(this.txtexpID);
            this.Controls.Add(this.panel1);
            this.Name = "expenseUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "expenseUI";
            this.Load += new System.EventHandler(this.expenseUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvexpense)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblqty;
        private System.Windows.Forms.TextBox txtqty;
        private System.Windows.Forms.Label lblcost;
        private System.Windows.Forms.TextBox txtcost;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label lblexpenseID;
        private System.Windows.Forms.TextBox txtexpID;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.DataGridView dgvexpense;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}