namespace Petron
{
    partial class Pay_Balance
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvcustomerlist = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearchcustomer = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtshowcustname = new System.Windows.Forms.TextBox();
            this.txtshowtrans = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvunpaidtrans = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbldateordered = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtbalance = new System.Windows.Forms.TextBox();
            this.txttotalamountpaid = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txttotalamount = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lblremark = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtcustname = new System.Windows.Forms.TextBox();
            this.txttransid = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtcustid = new System.Windows.Forms.TextBox();
            this.dgvpayments = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnsavepayment = new System.Windows.Forms.Button();
            this.txtexpremark = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtexpbalance = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtorno = new System.Windows.Forms.DateTimePicker();
            this.txtamntpayment = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomerlist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvunpaidtrans)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpayments)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dgvcustomerlist);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtsearchcustomer);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 298);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Customer List";
            // 
            // dgvcustomerlist
            // 
            this.dgvcustomerlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvcustomerlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcustomerlist.Location = new System.Drawing.Point(6, 66);
            this.dgvcustomerlist.Name = "dgvcustomerlist";
            this.dgvcustomerlist.Size = new System.Drawing.Size(334, 221);
            this.dgvcustomerlist.TabIndex = 1;
            this.dgvcustomerlist.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcustomerlist_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search";
            // 
            // txtsearchcustomer
            // 
            this.txtsearchcustomer.Location = new System.Drawing.Point(81, 36);
            this.txtsearchcustomer.Name = "txtsearchcustomer";
            this.txtsearchcustomer.Size = new System.Drawing.Size(259, 26);
            this.txtsearchcustomer.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1048, 28);
            this.panel1.TabIndex = 6;
            // 
            // txtshowcustname
            // 
            this.txtshowcustname.Location = new System.Drawing.Point(849, 70);
            this.txtshowcustname.Name = "txtshowcustname";
            this.txtshowcustname.ReadOnly = true;
            this.txtshowcustname.Size = new System.Drawing.Size(187, 26);
            this.txtshowcustname.TabIndex = 13;
            // 
            // txtshowtrans
            // 
            this.txtshowtrans.Location = new System.Drawing.Point(591, 70);
            this.txtshowtrans.Name = "txtshowtrans";
            this.txtshowtrans.Size = new System.Drawing.Size(166, 26);
            this.txtshowtrans.TabIndex = 12;
            this.txtshowtrans.Visible = false;
            this.txtshowtrans.TextChanged += new System.EventHandler(this.txtshowtrans_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(367, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Transactions";
            // 
            // dgvunpaidtrans
            // 
            this.dgvunpaidtrans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvunpaidtrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvunpaidtrans.Location = new System.Drawing.Point(370, 100);
            this.dgvunpaidtrans.Name = "dgvunpaidtrans";
            this.dgvunpaidtrans.Size = new System.Drawing.Size(666, 232);
            this.dgvunpaidtrans.TabIndex = 11;
            this.dgvunpaidtrans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvunpaidtrans_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.lbldateordered);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.txtbalance);
            this.panel2.Controls.Add(this.txttotalamountpaid);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.txttotalamount);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.lblremark);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtcustname);
            this.panel2.Controls.Add(this.txttransid);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.txtcustid);
            this.panel2.Controls.Add(this.dgvpayments);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 325);
            this.panel2.TabIndex = 14;
            // 
            // lbldateordered
            // 
            this.lbldateordered.AutoSize = true;
            this.lbldateordered.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldateordered.Location = new System.Drawing.Point(168, 295);
            this.lbldateordered.Name = "lbldateordered";
            this.lbldateordered.Size = new System.Drawing.Size(52, 24);
            this.lbldateordered.TabIndex = 95;
            this.lbldateordered.Text = ". . . .";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(31, 295);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 20);
            this.label11.TabIndex = 94;
            this.label11.Text = "Date Ordered:";
            // 
            // txtbalance
            // 
            this.txtbalance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txtbalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbalance.ForeColor = System.Drawing.Color.Silver;
            this.txtbalance.Location = new System.Drawing.Point(506, 292);
            this.txtbalance.Name = "txtbalance";
            this.txtbalance.ReadOnly = true;
            this.txtbalance.Size = new System.Drawing.Size(109, 26);
            this.txtbalance.TabIndex = 93;
            this.txtbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtbalance.TextChanged += new System.EventHandler(this.txtbalance_TextChanged);
            // 
            // txttotalamountpaid
            // 
            this.txttotalamountpaid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.txttotalamountpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalamountpaid.ForeColor = System.Drawing.Color.Silver;
            this.txttotalamountpaid.Location = new System.Drawing.Point(506, 260);
            this.txttotalamountpaid.Name = "txttotalamountpaid";
            this.txttotalamountpaid.ReadOnly = true;
            this.txttotalamountpaid.Size = new System.Drawing.Size(109, 26);
            this.txttotalamountpaid.TabIndex = 92;
            this.txttotalamountpaid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(15, 263);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 20);
            this.label18.TabIndex = 90;
            this.label18.Text = "Total Amt.";
            // 
            // txttotalamount
            // 
            this.txttotalamount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txttotalamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotalamount.ForeColor = System.Drawing.Color.Silver;
            this.txttotalamount.Location = new System.Drawing.Point(144, 260);
            this.txttotalamount.Name = "txttotalamount";
            this.txttotalamount.ReadOnly = true;
            this.txttotalamount.Size = new System.Drawing.Size(109, 26);
            this.txttotalamount.TabIndex = 89;
            this.txttotalamount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(100, 264);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 20);
            this.label20.TabIndex = 91;
            this.label20.Text = "Php.";
            // 
            // lblremark
            // 
            this.lblremark.AutoSize = true;
            this.lblremark.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblremark.Location = new System.Drawing.Point(259, 261);
            this.lblremark.Name = "lblremark";
            this.lblremark.Size = new System.Drawing.Size(52, 24);
            this.lblremark.TabIndex = 88;
            this.lblremark.Text = ". . . .";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(400, 296);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 20);
            this.label16.TabIndex = 87;
            this.label16.Text = "Balance Php.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(332, 264);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(175, 20);
            this.label15.TabIndex = 86;
            this.label15.Text = "Total Amount Paid Php.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(355, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 20);
            this.label14.TabIndex = 85;
            this.label14.Text = "Customer Name :";
            // 
            // txtcustname
            // 
            this.txtcustname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcustname.Location = new System.Drawing.Point(359, 52);
            this.txtcustname.Name = "txtcustname";
            this.txtcustname.ReadOnly = true;
            this.txtcustname.Size = new System.Drawing.Size(256, 24);
            this.txtcustname.TabIndex = 84;
            // 
            // txttransid
            // 
            this.txttransid.Location = new System.Drawing.Point(134, 19);
            this.txttransid.Name = "txttransid";
            this.txttransid.ReadOnly = true;
            this.txttransid.Size = new System.Drawing.Size(215, 26);
            this.txttransid.TabIndex = 83;
            this.txttransid.TextChanged += new System.EventHandler(this.txttransid_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(13, 52);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 20);
            this.label12.TabIndex = 82;
            this.label12.Text = "Customer ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(13, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(113, 20);
            this.label13.TabIndex = 81;
            this.label13.Text = "Transaction ID";
            // 
            // txtcustid
            // 
            this.txtcustid.Location = new System.Drawing.Point(134, 49);
            this.txtcustid.Name = "txtcustid";
            this.txtcustid.ReadOnly = true;
            this.txtcustid.Size = new System.Drawing.Size(215, 26);
            this.txtcustid.TabIndex = 80;
            // 
            // dgvpayments
            // 
            this.dgvpayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvpayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpayments.Location = new System.Drawing.Point(16, 85);
            this.dgvpayments.Name = "dgvpayments";
            this.dgvpayments.Size = new System.Drawing.Size(599, 169);
            this.dgvpayments.TabIndex = 79;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.btnsavepayment);
            this.panel3.Controls.Add(this.txtexpremark);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtexpbalance);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtorno);
            this.panel3.Controls.Add(this.txtamntpayment);
            this.panel3.Location = new System.Drawing.Point(633, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 316);
            this.panel3.TabIndex = 78;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(13, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 20);
            this.label8.TabIndex = 104;
            this.label8.Text = "Expected Remark";
            // 
            // btnsavepayment
            // 
            this.btnsavepayment.Location = new System.Drawing.Point(3, 278);
            this.btnsavepayment.Name = "btnsavepayment";
            this.btnsavepayment.Size = new System.Drawing.Size(378, 30);
            this.btnsavepayment.TabIndex = 103;
            this.btnsavepayment.Text = "Save Payment";
            this.btnsavepayment.UseVisualStyleBackColor = true;
            this.btnsavepayment.Click += new System.EventHandler(this.btnsavepayment_Click);
            // 
            // txtexpremark
            // 
            this.txtexpremark.Location = new System.Drawing.Point(192, 183);
            this.txtexpremark.Name = "txtexpremark";
            this.txtexpremark.ReadOnly = true;
            this.txtexpremark.Size = new System.Drawing.Size(100, 26);
            this.txtexpremark.TabIndex = 102;
            this.txtexpremark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtexpremark.TextChanged += new System.EventHandler(this.txtexpremark_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(13, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 20);
            this.label7.TabIndex = 101;
            this.label7.Text = "Expected Balance Php.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 20);
            this.label6.TabIndex = 100;
            this.label6.Text = "Amount Payment Php.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(13, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 20);
            this.label5.TabIndex = 99;
            this.label5.Text = "PAYMENT TRANSACTION";
            // 
            // txtexpbalance
            // 
            this.txtexpbalance.Location = new System.Drawing.Point(192, 151);
            this.txtexpbalance.Name = "txtexpbalance";
            this.txtexpbalance.ReadOnly = true;
            this.txtexpbalance.Size = new System.Drawing.Size(139, 26);
            this.txtexpbalance.TabIndex = 97;
            this.txtexpbalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtexpbalance.TextChanged += new System.EventHandler(this.txtexpbalance_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 96;
            this.label3.Text = "OR No.";
            // 
            // txtorno
            // 
            this.txtorno.CustomFormat = "mmssyyhhddMM";
            this.txtorno.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtorno.Location = new System.Drawing.Point(192, 44);
            this.txtorno.Name = "txtorno";
            this.txtorno.Size = new System.Drawing.Size(179, 26);
            this.txtorno.TabIndex = 3;
            // 
            // txtamntpayment
            // 
            this.txtamntpayment.Location = new System.Drawing.Point(192, 94);
            this.txtamntpayment.Name = "txtamntpayment";
            this.txtamntpayment.Size = new System.Drawing.Size(139, 26);
            this.txtamntpayment.TabIndex = 0;
            this.txtamntpayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtamntpayment.TextChanged += new System.EventHandler(this.txtamntpayment_TextChanged);
            // 
            // Pay_Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1048, 675);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtshowcustname);
            this.Controls.Add(this.txtshowtrans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvunpaidtrans);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Pay_Balance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pay_Balance";
            this.Load += new System.EventHandler(this.Pay_Balance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcustomerlist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvunpaidtrans)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpayments)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvcustomerlist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearchcustomer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtshowcustname;
        private System.Windows.Forms.TextBox txtshowtrans;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvunpaidtrans;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtbalance;
        private System.Windows.Forms.TextBox txttotalamountpaid;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txttotalamount;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblremark;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtcustname;
        private System.Windows.Forms.TextBox txttransid;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtcustid;
        private System.Windows.Forms.DataGridView dgvpayments;
        private System.Windows.Forms.Label lbldateordered;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtamntpayment;
        private System.Windows.Forms.DateTimePicker txtorno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnsavepayment;
        private System.Windows.Forms.TextBox txtexpremark;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtexpbalance;
        private System.Windows.Forms.Label label3;
    }
}