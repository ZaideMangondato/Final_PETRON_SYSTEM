namespace Petron
{
    partial class Print_Customer_Transactions
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbpetron2CustomerTransactionsDataSet = new Petron.dbpetron2CustomerTransactionsDataSet();
            this.view_selectedcustomertransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_selectedcustomertransactionsTableAdapter = new Petron.dbpetron2CustomerTransactionsDataSetTableAdapters.view_selectedcustomertransactionsTableAdapter();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.pct_comppos = new System.Windows.Forms.TextBox();
            this.pct_compaff = new System.Windows.Forms.TextBox();
            this.pct_num = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.pct_addr = new System.Windows.Forms.TextBox();
            this.pct_custname = new System.Windows.Forms.TextBox();
            this.pct_custid = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbpetron2CustomerTransactionsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_selectedcustomertransactionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.view_selectedcustomertransactionsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Petron.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(890, 623);
            this.reportViewer1.TabIndex = 0;
            // 
            // dbpetron2CustomerTransactionsDataSet
            // 
            this.dbpetron2CustomerTransactionsDataSet.DataSetName = "dbpetron2CustomerTransactionsDataSet";
            this.dbpetron2CustomerTransactionsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_selectedcustomertransactionsBindingSource
            // 
            this.view_selectedcustomertransactionsBindingSource.DataMember = "view_selectedcustomertransactions";
            this.view_selectedcustomertransactionsBindingSource.DataSource = this.dbpetron2CustomerTransactionsDataSet;
            // 
            // view_selectedcustomertransactionsTableAdapter
            // 
            this.view_selectedcustomertransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(0, 216);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(91, 13);
            this.label25.TabIndex = 53;
            this.label25.Text = "Company Position";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.Color.Black;
            this.label26.Location = new System.Drawing.Point(0, 192);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(96, 13);
            this.label26.TabIndex = 52;
            this.label26.Text = "Company Affiliation";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.Color.Black;
            this.label27.Location = new System.Drawing.Point(0, 161);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(84, 13);
            this.label27.TabIndex = 51;
            this.label27.Text = "Contact Number";
            // 
            // pct_comppos
            // 
            this.pct_comppos.Location = new System.Drawing.Point(141, 213);
            this.pct_comppos.Name = "pct_comppos";
            this.pct_comppos.ReadOnly = true;
            this.pct_comppos.Size = new System.Drawing.Size(150, 20);
            this.pct_comppos.TabIndex = 50;
            this.pct_comppos.TextChanged += new System.EventHandler(this.pct_comppos_TextChanged);
            // 
            // pct_compaff
            // 
            this.pct_compaff.Location = new System.Drawing.Point(141, 186);
            this.pct_compaff.Name = "pct_compaff";
            this.pct_compaff.ReadOnly = true;
            this.pct_compaff.Size = new System.Drawing.Size(150, 20);
            this.pct_compaff.TabIndex = 49;
            this.pct_compaff.TextChanged += new System.EventHandler(this.pct_compaff_TextChanged);
            // 
            // pct_num
            // 
            this.pct_num.Location = new System.Drawing.Point(141, 158);
            this.pct_num.Name = "pct_num";
            this.pct_num.ReadOnly = true;
            this.pct_num.Size = new System.Drawing.Size(150, 20);
            this.pct_num.TabIndex = 48;
            this.pct_num.TextChanged += new System.EventHandler(this.pct_num_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(22, 115);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 13);
            this.label17.TabIndex = 47;
            this.label17.Text = "Address";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(17, 75);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 13);
            this.label21.TabIndex = 46;
            this.label21.Text = "Customer Name";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(17, 48);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 13);
            this.label22.TabIndex = 45;
            this.label22.Text = "Customer ID";
            // 
            // pct_addr
            // 
            this.pct_addr.Location = new System.Drawing.Point(141, 99);
            this.pct_addr.Multiline = true;
            this.pct_addr.Name = "pct_addr";
            this.pct_addr.ReadOnly = true;
            this.pct_addr.Size = new System.Drawing.Size(186, 51);
            this.pct_addr.TabIndex = 44;
            this.pct_addr.TextChanged += new System.EventHandler(this.pct_addr_TextChanged);
            // 
            // pct_custname
            // 
            this.pct_custname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pct_custname.Location = new System.Drawing.Point(141, 72);
            this.pct_custname.Name = "pct_custname";
            this.pct_custname.ReadOnly = true;
            this.pct_custname.Size = new System.Drawing.Size(186, 24);
            this.pct_custname.TabIndex = 43;
            this.pct_custname.TextChanged += new System.EventHandler(this.pct_custname_TextChanged);
            // 
            // pct_custid
            // 
            this.pct_custid.Location = new System.Drawing.Point(141, 45);
            this.pct_custid.Name = "pct_custid";
            this.pct_custid.ReadOnly = true;
            this.pct_custid.Size = new System.Drawing.Size(154, 20);
            this.pct_custid.TabIndex = 42;
            this.pct_custid.TextChanged += new System.EventHandler(this.pct_custid_TextChanged);
            // 
            // Print_Customer_Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 623);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.pct_comppos);
            this.Controls.Add(this.pct_compaff);
            this.Controls.Add(this.pct_num);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.pct_addr);
            this.Controls.Add(this.pct_custname);
            this.Controls.Add(this.pct_custid);
            this.Name = "Print_Customer_Transactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print_Customer_Transactions";
            this.Load += new System.EventHandler(this.Print_Customer_Transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbpetron2CustomerTransactionsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_selectedcustomertransactionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource view_selectedcustomertransactionsBindingSource;
        private dbpetron2CustomerTransactionsDataSet dbpetron2CustomerTransactionsDataSet;
        private dbpetron2CustomerTransactionsDataSetTableAdapters.view_selectedcustomertransactionsTableAdapter view_selectedcustomertransactionsTableAdapter;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        public System.Windows.Forms.TextBox pct_comppos;
        public System.Windows.Forms.TextBox pct_compaff;
        public System.Windows.Forms.TextBox pct_num;
        public System.Windows.Forms.TextBox pct_addr;
        public System.Windows.Forms.TextBox pct_custname;
        public System.Windows.Forms.TextBox pct_custid;
    }
}