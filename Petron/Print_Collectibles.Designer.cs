namespace Petron
{
    partial class Print_Collectibles
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
            this.pc_from = new System.Windows.Forms.TextBox();
            this.pc_to = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dbpetron2CollectiblesDateRangeDataSet = new Petron.dbpetron2CollectiblesDateRangeDataSet();
            this.view_collectibles_daterangeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_collectibles_daterangeTableAdapter = new Petron.dbpetron2CollectiblesDateRangeDataSetTableAdapters.view_collectibles_daterangeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dbpetron2CollectiblesDateRangeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_collectibles_daterangeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pc_from
            // 
            this.pc_from.Location = new System.Drawing.Point(110, 35);
            this.pc_from.Name = "pc_from";
            this.pc_from.Size = new System.Drawing.Size(200, 20);
            this.pc_from.TabIndex = 0;
            this.pc_from.TextChanged += new System.EventHandler(this.pc_from_TextChanged);
            // 
            // pc_to
            // 
            this.pc_to.Location = new System.Drawing.Point(316, 35);
            this.pc_to.Name = "pc_to";
            this.pc_to.Size = new System.Drawing.Size(200, 20);
            this.pc_to.TabIndex = 1;
            this.pc_to.TextChanged += new System.EventHandler(this.pc_to_TextChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.view_collectibles_daterangeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Petron.Report5.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(857, 580);
            this.reportViewer1.TabIndex = 2;
            // 
            // dbpetron2CollectiblesDateRangeDataSet
            // 
            this.dbpetron2CollectiblesDateRangeDataSet.DataSetName = "dbpetron2CollectiblesDateRangeDataSet";
            this.dbpetron2CollectiblesDateRangeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_collectibles_daterangeBindingSource
            // 
            this.view_collectibles_daterangeBindingSource.DataMember = "view_collectibles_daterange";
            this.view_collectibles_daterangeBindingSource.DataSource = this.dbpetron2CollectiblesDateRangeDataSet;
            // 
            // view_collectibles_daterangeTableAdapter
            // 
            this.view_collectibles_daterangeTableAdapter.ClearBeforeFill = true;
            // 
            // Print_Collectibles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 580);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.pc_to);
            this.Controls.Add(this.pc_from);
            this.Name = "Print_Collectibles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print_Collectibles";
            this.Load += new System.EventHandler(this.Print_Collectibles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbpetron2CollectiblesDateRangeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_collectibles_daterangeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox pc_from;
        public System.Windows.Forms.TextBox pc_to;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource view_collectibles_daterangeBindingSource;
        private dbpetron2CollectiblesDateRangeDataSet dbpetron2CollectiblesDateRangeDataSet;
        private dbpetron2CollectiblesDateRangeDataSetTableAdapters.view_collectibles_daterangeTableAdapter view_collectibles_daterangeTableAdapter;

    }
}