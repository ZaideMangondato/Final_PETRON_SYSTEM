namespace Petron
{
    partial class Print_Collections
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
            this.dbpetron2PrintCollectionsDataSet = new Petron.dbpetron2PrintCollectionsDataSet();
            this.view_collections_daterangeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_collections_daterangeTableAdapter = new Petron.dbpetron2PrintCollectionsDataSetTableAdapters.view_collections_daterangeTableAdapter();
            this.pc_from = new System.Windows.Forms.TextBox();
            this.pc_to = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbpetron2PrintCollectionsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_collections_daterangeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.view_collections_daterangeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Petron.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(790, 492);
            this.reportViewer1.TabIndex = 0;
            // 
            // dbpetron2PrintCollectionsDataSet
            // 
            this.dbpetron2PrintCollectionsDataSet.DataSetName = "dbpetron2PrintCollectionsDataSet";
            this.dbpetron2PrintCollectionsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_collections_daterangeBindingSource
            // 
            this.view_collections_daterangeBindingSource.DataMember = "view_collections_daterange";
            this.view_collections_daterangeBindingSource.DataSource = this.dbpetron2PrintCollectionsDataSet;
            // 
            // view_collections_daterangeTableAdapter
            // 
            this.view_collections_daterangeTableAdapter.ClearBeforeFill = true;
            // 
            // pc_from
            // 
            this.pc_from.Location = new System.Drawing.Point(169, 43);
            this.pc_from.Name = "pc_from";
            this.pc_from.Size = new System.Drawing.Size(100, 20);
            this.pc_from.TabIndex = 1;
            this.pc_from.TextChanged += new System.EventHandler(this.pc_from_TextChanged);
            // 
            // pc_to
            // 
            this.pc_to.Location = new System.Drawing.Point(275, 43);
            this.pc_to.Name = "pc_to";
            this.pc_to.Size = new System.Drawing.Size(100, 20);
            this.pc_to.TabIndex = 2;
            this.pc_to.TextChanged += new System.EventHandler(this.pc_to_TextChanged);
            // 
            // Print_Collections
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 492);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.pc_to);
            this.Controls.Add(this.pc_from);
            this.Name = "Print_Collections";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print_Collections";
            this.Load += new System.EventHandler(this.Print_Collections_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbpetron2PrintCollectionsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_collections_daterangeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource view_collections_daterangeBindingSource;
        private dbpetron2PrintCollectionsDataSet dbpetron2PrintCollectionsDataSet;
        private dbpetron2PrintCollectionsDataSetTableAdapters.view_collections_daterangeTableAdapter view_collections_daterangeTableAdapter;
        public System.Windows.Forms.TextBox pc_from;
        public System.Windows.Forms.TextBox pc_to;
    }
}