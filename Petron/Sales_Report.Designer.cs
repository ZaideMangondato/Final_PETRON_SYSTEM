namespace Petron
{
    partial class Sales_Report
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
            this.txtdate = new System.Windows.Forms.TextBox();
            this.dbpetron2DataSet1 = new Petron.dbpetron2DataSet1();
            this.view_salesreportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_salesreportTableAdapter = new Petron.dbpetron2DataSet1TableAdapters.view_salesreportTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbpetron2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_salesreportBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.view_salesreportBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Petron.Report6.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(889, 554);
            this.reportViewer1.TabIndex = 0;
            // 
            // txtdate
            // 
            this.txtdate.Location = new System.Drawing.Point(307, 45);
            this.txtdate.Name = "txtdate";
            this.txtdate.Size = new System.Drawing.Size(100, 22);
            this.txtdate.TabIndex = 1;
            this.txtdate.TextChanged += new System.EventHandler(this.txtdate_TextChanged);
            // 
            // dbpetron2DataSet1
            // 
            this.dbpetron2DataSet1.DataSetName = "dbpetron2DataSet1";
            this.dbpetron2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_salesreportBindingSource
            // 
            this.view_salesreportBindingSource.DataMember = "view_salesreport";
            this.view_salesreportBindingSource.DataSource = this.dbpetron2DataSet1;
            // 
            // view_salesreportTableAdapter
            // 
            this.view_salesreportTableAdapter.ClearBeforeFill = true;
            // 
            // Sales_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 554);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.txtdate);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Sales_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales_Report";
            this.Load += new System.EventHandler(this.Sales_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbpetron2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_salesreportBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.TextBox txtdate;
        private System.Windows.Forms.BindingSource view_salesreportBindingSource;
        private dbpetron2DataSet1 dbpetron2DataSet1;
        private dbpetron2DataSet1TableAdapters.view_salesreportTableAdapter view_salesreportTableAdapter;
    }
}