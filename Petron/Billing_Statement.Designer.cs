namespace Petron
{
    partial class Billing_Statement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bstxttransid = new System.Windows.Forms.TextBox();
            this.bstxtcustid = new System.Windows.Forms.TextBox();
            this.bstxtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bstxtaddress = new System.Windows.Forms.TextBox();
            this.bstxttotalamount = new System.Windows.Forms.TextBox();
            this.bstxtamountpaid = new System.Windows.Forms.TextBox();
            this.bstxtbalance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bstxtdatetrans = new System.Windows.Forms.TextBox();
            this.bstxtbillingdate = new System.Windows.Forms.DateTimePicker();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.bstxtbillingdate);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.bstxtdatetrans);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.bstxtbalance);
            this.panel1.Controls.Add(this.bstxtamountpaid);
            this.panel1.Controls.Add(this.bstxttotalamount);
            this.panel1.Controls.Add(this.bstxtaddress);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bstxtname);
            this.panel1.Controls.Add(this.bstxtcustid);
            this.panel1.Controls.Add(this.bstxttransid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 386);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Billing Statement";
            // 
            // bstxttransid
            // 
            this.bstxttransid.Location = new System.Drawing.Point(131, 48);
            this.bstxttransid.Name = "bstxttransid";
            this.bstxttransid.ReadOnly = true;
            this.bstxttransid.Size = new System.Drawing.Size(195, 24);
            this.bstxttransid.TabIndex = 2;
            this.bstxttransid.TextChanged += new System.EventHandler(this.bstxttransid_TextChanged);
            // 
            // bstxtcustid
            // 
            this.bstxtcustid.Location = new System.Drawing.Point(131, 89);
            this.bstxtcustid.Name = "bstxtcustid";
            this.bstxtcustid.ReadOnly = true;
            this.bstxtcustid.Size = new System.Drawing.Size(221, 24);
            this.bstxtcustid.TabIndex = 2;
            this.bstxtcustid.TextChanged += new System.EventHandler(this.bstxtcustid_TextChanged);
            // 
            // bstxtname
            // 
            this.bstxtname.Location = new System.Drawing.Point(131, 119);
            this.bstxtname.Name = "bstxtname";
            this.bstxtname.ReadOnly = true;
            this.bstxtname.Size = new System.Drawing.Size(221, 24);
            this.bstxtname.TabIndex = 3;
            this.bstxtname.TextChanged += new System.EventHandler(this.bstxtname_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Billing Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Transaction ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Customer ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Address";
            // 
            // bstxtaddress
            // 
            this.bstxtaddress.Location = new System.Drawing.Point(131, 149);
            this.bstxtaddress.Multiline = true;
            this.bstxtaddress.Name = "bstxtaddress";
            this.bstxtaddress.ReadOnly = true;
            this.bstxtaddress.Size = new System.Drawing.Size(221, 54);
            this.bstxtaddress.TabIndex = 9;
            this.bstxtaddress.TextChanged += new System.EventHandler(this.bstxtaddress_TextChanged);
            // 
            // bstxttotalamount
            // 
            this.bstxttotalamount.Location = new System.Drawing.Point(449, 225);
            this.bstxttotalamount.Name = "bstxttotalamount";
            this.bstxttotalamount.ReadOnly = true;
            this.bstxttotalamount.Size = new System.Drawing.Size(161, 24);
            this.bstxttotalamount.TabIndex = 10;
            this.bstxttotalamount.TextChanged += new System.EventHandler(this.bstxttotalamount_TextChanged);
            // 
            // bstxtamountpaid
            // 
            this.bstxtamountpaid.Location = new System.Drawing.Point(449, 255);
            this.bstxtamountpaid.Name = "bstxtamountpaid";
            this.bstxtamountpaid.ReadOnly = true;
            this.bstxtamountpaid.Size = new System.Drawing.Size(161, 24);
            this.bstxtamountpaid.TabIndex = 11;
            this.bstxtamountpaid.TextChanged += new System.EventHandler(this.bstxtamountpaid_TextChanged);
            // 
            // bstxtbalance
            // 
            this.bstxtbalance.Location = new System.Drawing.Point(449, 285);
            this.bstxtbalance.Name = "bstxtbalance";
            this.bstxtbalance.ReadOnly = true;
            this.bstxtbalance.Size = new System.Drawing.Size(161, 24);
            this.bstxtbalance.TabIndex = 12;
            this.bstxtbalance.TextChanged += new System.EventHandler(this.bstxtbalance_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(288, 288);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Current Bill (Balance) :\r\n";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(351, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Amount Paid";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(347, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 18);
            this.label9.TabIndex = 13;
            this.label9.Text = "Total Amount";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(387, 92);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 18);
            this.label10.TabIndex = 17;
            this.label10.Text = "Date of Transaction";
            // 
            // bstxtdatetrans
            // 
            this.bstxtdatetrans.Location = new System.Drawing.Point(390, 119);
            this.bstxtdatetrans.Name = "bstxtdatetrans";
            this.bstxtdatetrans.ReadOnly = true;
            this.bstxtdatetrans.Size = new System.Drawing.Size(154, 24);
            this.bstxtdatetrans.TabIndex = 16;
            this.bstxtdatetrans.TextChanged += new System.EventHandler(this.bstxtdatetrans_TextChanged);
            // 
            // bstxtbillingdate
            // 
            this.bstxtbillingdate.CustomFormat = "yyyy-MM-dd";
            this.bstxtbillingdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bstxtbillingdate.Location = new System.Drawing.Point(478, 48);
            this.bstxtbillingdate.Name = "bstxtbillingdate";
            this.bstxtbillingdate.Size = new System.Drawing.Size(132, 24);
            this.bstxtbillingdate.TabIndex = 18;
            this.bstxtbillingdate.ValueChanged += new System.EventHandler(this.bstxtbillingdate_ValueChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Petron.billingstatementreceipt.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(824, 454);
            this.reportViewer1.TabIndex = 19;
            // 
            // Billing_Statement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 454);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Billing_Statement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing_Statement";
            this.Load += new System.EventHandler(this.Billing_Statement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox bstxtname;
        public System.Windows.Forms.TextBox bstxtcustid;
        public System.Windows.Forms.TextBox bstxttransid;
        public System.Windows.Forms.TextBox bstxttotalamount;
        public System.Windows.Forms.TextBox bstxtaddress;
        public System.Windows.Forms.TextBox bstxtbalance;
        public System.Windows.Forms.TextBox bstxtamountpaid;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox bstxtdatetrans;
        private System.Windows.Forms.DateTimePicker bstxtbillingdate;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}