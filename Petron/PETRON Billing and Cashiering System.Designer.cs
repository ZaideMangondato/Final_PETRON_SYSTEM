namespace Petron
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viscosityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockMonitoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.billinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cashieringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payBillsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateRangingReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrationToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.billinToolStripMenuItem,
            this.cashieringToolStripMenuItem,
            this.reportsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(999, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrationToolStripMenuItem
            // 
            this.registrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productToolStripMenuItem,
            this.supplierToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.categoryToolStripMenuItem,
            this.typeToolStripMenuItem,
            this.viscosityToolStripMenuItem});
            this.registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            this.registrationToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.registrationToolStripMenuItem.Text = "Records";
            this.registrationToolStripMenuItem.Click += new System.EventHandler(this.registrationToolStripMenuItem_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.productToolStripMenuItem.Text = "Stock Registration";
            this.productToolStripMenuItem.Click += new System.EventHandler(this.productToolStripMenuItem_Click);
            // 
            // supplierToolStripMenuItem
            // 
            this.supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            this.supplierToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.supplierToolStripMenuItem.Text = "Supplier";
            this.supplierToolStripMenuItem.Click += new System.EventHandler(this.supplierToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.categoryToolStripMenuItem.Text = "Category";
            this.categoryToolStripMenuItem.Click += new System.EventHandler(this.categoryToolStripMenuItem_Click);
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.typeToolStripMenuItem.Text = "Type";
            this.typeToolStripMenuItem.Click += new System.EventHandler(this.typeToolStripMenuItem_Click);
            // 
            // viscosityToolStripMenuItem
            // 
            this.viscosityToolStripMenuItem.Name = "viscosityToolStripMenuItem";
            this.viscosityToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.viscosityToolStripMenuItem.Text = "Viscosity";
            this.viscosityToolStripMenuItem.Click += new System.EventHandler(this.viscosityToolStripMenuItem_Click);
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stockEntryToolStripMenuItem,
            this.stockMonitoringToolStripMenuItem});
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory Management";
            // 
            // stockEntryToolStripMenuItem
            // 
            this.stockEntryToolStripMenuItem.Name = "stockEntryToolStripMenuItem";
            this.stockEntryToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.stockEntryToolStripMenuItem.Text = "Stock Entry";
            this.stockEntryToolStripMenuItem.Click += new System.EventHandler(this.stockEntryToolStripMenuItem_Click_1);
            // 
            // stockMonitoringToolStripMenuItem
            // 
            this.stockMonitoringToolStripMenuItem.Name = "stockMonitoringToolStripMenuItem";
            this.stockMonitoringToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.stockMonitoringToolStripMenuItem.Text = "Stock Monitoring";
            this.stockMonitoringToolStripMenuItem.Click += new System.EventHandler(this.stockMonitoringToolStripMenuItem_Click);
            // 
            // billinToolStripMenuItem
            // 
            this.billinToolStripMenuItem.Name = "billinToolStripMenuItem";
            this.billinToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.billinToolStripMenuItem.Text = "Billing";
            this.billinToolStripMenuItem.Click += new System.EventHandler(this.billinToolStripMenuItem_Click);
            // 
            // cashieringToolStripMenuItem
            // 
            this.cashieringToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderEntryToolStripMenuItem,
            this.payBillsToolStripMenuItem});
            this.cashieringToolStripMenuItem.Name = "cashieringToolStripMenuItem";
            this.cashieringToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.cashieringToolStripMenuItem.Text = "Cashiering";
            this.cashieringToolStripMenuItem.Click += new System.EventHandler(this.cashieringToolStripMenuItem_Click);
            // 
            // orderEntryToolStripMenuItem
            // 
            this.orderEntryToolStripMenuItem.Name = "orderEntryToolStripMenuItem";
            this.orderEntryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.orderEntryToolStripMenuItem.Text = "Sales Entry";
            this.orderEntryToolStripMenuItem.Click += new System.EventHandler(this.orderEntryToolStripMenuItem_Click);
            // 
            // payBillsToolStripMenuItem
            // 
            this.payBillsToolStripMenuItem.Name = "payBillsToolStripMenuItem";
            this.payBillsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.payBillsToolStripMenuItem.Text = "Pay Balance";
            this.payBillsToolStripMenuItem.Click += new System.EventHandler(this.payBillsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openReportsToolStripMenuItem,
            this.dateRangingReportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // openReportsToolStripMenuItem
            // 
            this.openReportsToolStripMenuItem.Name = "openReportsToolStripMenuItem";
            this.openReportsToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.openReportsToolStripMenuItem.Text = "Open All Reports";
            this.openReportsToolStripMenuItem.Click += new System.EventHandler(this.openReportsToolStripMenuItem_Click);
            // 
            // dateRangingReportToolStripMenuItem
            // 
            this.dateRangingReportToolStripMenuItem.Name = "dateRangingReportToolStripMenuItem";
            this.dateRangingReportToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.dateRangingReportToolStripMenuItem.Text = "Date Ranging Reports";
            this.dateRangingReportToolStripMenuItem.Click += new System.EventHandler(this.dateRangingReportToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Petron.Properties.Resources.Petron6;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(999, 393);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 417);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Petron Cashiering and Billing System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viscosityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem billinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cashieringToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem stockMonitoringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payBillsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateRangingReportToolStripMenuItem;
    }
}

