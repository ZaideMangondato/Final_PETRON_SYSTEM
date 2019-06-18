namespace Petron
{
    partial class All_Reports
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource9 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource10 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.view_collectionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbpetron2DataSet = new Petron.dbpetron2DataSet();
            this.view_collectiblesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbpetron2CollectiblesDataSet = new Petron.dbpetron2CollectiblesDataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.view_collectionsTableAdapter = new Petron.dbpetron2DataSetTableAdapters.view_collectionsTableAdapter();
            this.view_collectiblesTableAdapter = new Petron.dbpetron2CollectiblesDataSetTableAdapters.view_collectiblesTableAdapter();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btngo = new System.Windows.Forms.Button();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_sales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.view_collectionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbpetron2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_collectiblesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbpetron2CollectiblesDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales)).BeginInit();
            this.SuspendLayout();
            // 
            // view_collectionsBindingSource
            // 
            this.view_collectionsBindingSource.DataMember = "view_collections";
            this.view_collectionsBindingSource.DataSource = this.dbpetron2DataSet;
            // 
            // dbpetron2DataSet
            // 
            this.dbpetron2DataSet.DataSetName = "dbpetron2DataSet";
            this.dbpetron2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_collectiblesBindingSource
            // 
            this.view_collectiblesBindingSource.DataMember = "view_collectibles";
            this.view_collectiblesBindingSource.DataSource = this.dbpetron2CollectiblesDataSet;
            // 
            // dbpetron2CollectiblesDataSet
            // 
            this.dbpetron2CollectiblesDataSet.DataSetName = "dbpetron2CollectiblesDataSet";
            this.dbpetron2CollectiblesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1003, 531);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(995, 500);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Collections Report";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource9.Name = "DataSet1";
            reportDataSource9.Value = this.view_collectionsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource9);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Petron.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(989, 494);
            this.reportViewer1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(995, 500);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Collectibles Report";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer2
            // 
            this.reportViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource10.Name = "DataSet1";
            reportDataSource10.Value = this.view_collectiblesBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource10);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "Petron.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(3, 3);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(989, 494);
            this.reportViewer2.TabIndex = 0;
            // 
            // view_collectionsTableAdapter
            // 
            this.view_collectionsTableAdapter.ClearBeforeFill = true;
            // 
            // view_collectiblesTableAdapter
            // 
            this.view_collectiblesTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgv_sales);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(995, 500);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Sale Report";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.btngo);
            this.panel1.Controls.Add(this.dtp_date);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 51);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 449);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(989, 48);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(857, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Print Sales Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btngo
            // 
            this.btngo.Location = new System.Drawing.Point(274, 11);
            this.btngo.Name = "btngo";
            this.btngo.Size = new System.Drawing.Size(153, 29);
            this.btngo.TabIndex = 7;
            this.btngo.Text = "Go";
            this.btngo.UseVisualStyleBackColor = true;
            this.btngo.Click += new System.EventHandler(this.btngo_Click);
            // 
            // dtp_date
            // 
            this.dtp_date.CustomFormat = "yyyy-MM-dd";
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date.Location = new System.Drawing.Point(103, 14);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(153, 24);
            this.dtp_date.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sales Date:";
            // 
            // dgv_sales
            // 
            this.dgv_sales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_sales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_sales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_sales.Location = new System.Drawing.Point(3, 54);
            this.dgv_sales.Name = "dgv_sales";
            this.dgv_sales.Size = new System.Drawing.Size(989, 395);
            this.dgv_sales.TabIndex = 2;
            // 
            // All_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 531);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "All_Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All_Reports";
            this.Load += new System.EventHandler(this.All_Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.view_collectionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbpetron2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_collectiblesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbpetron2CollectiblesDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource view_collectionsBindingSource;
        private dbpetron2DataSet dbpetron2DataSet;
        private dbpetron2DataSetTableAdapters.view_collectionsTableAdapter view_collectionsTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource view_collectiblesBindingSource;
        private dbpetron2CollectiblesDataSet dbpetron2CollectiblesDataSet;
        private dbpetron2CollectiblesDataSetTableAdapters.view_collectiblesTableAdapter view_collectiblesTableAdapter;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btngo;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_sales;
    }
}