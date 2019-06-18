namespace Petron
{
    partial class All_Petron_dateRange_Reports
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnprintCollections = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncollectionsgo = new System.Windows.Forms.Button();
            this.collections_to = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.collections_from = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnprintCollectibles = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btncollectiblesgo = new System.Windows.Forms.Button();
            this.collectibles_to = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.collectibles_from = new System.Windows.Forms.DateTimePicker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1024, 568);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1016, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Collections Report";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnprintCollections);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 494);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1010, 40);
            this.panel2.TabIndex = 2;
            // 
            // btnprintCollections
            // 
            this.btnprintCollections.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnprintCollections.Enabled = false;
            this.btnprintCollections.Location = new System.Drawing.Point(791, 0);
            this.btnprintCollections.Name = "btnprintCollections";
            this.btnprintCollections.Size = new System.Drawing.Size(215, 36);
            this.btnprintCollections.TabIndex = 5;
            this.btnprintCollections.Text = "Print Report";
            this.btnprintCollections.UseVisualStyleBackColor = true;
            this.btnprintCollections.Click += new System.EventHandler(this.btnprintCollections_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1010, 473);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btncollectionsgo);
            this.panel1.Controls.Add(this.collections_to);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.collections_from);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1010, 58);
            this.panel1.TabIndex = 0;
            // 
            // btncollectionsgo
            // 
            this.btncollectionsgo.Location = new System.Drawing.Point(479, 9);
            this.btncollectionsgo.Name = "btncollectionsgo";
            this.btncollectionsgo.Size = new System.Drawing.Size(153, 29);
            this.btncollectionsgo.TabIndex = 4;
            this.btncollectionsgo.Text = "Go";
            this.btncollectionsgo.UseVisualStyleBackColor = true;
            this.btncollectionsgo.Click += new System.EventHandler(this.button1_Click);
            // 
            // collections_to
            // 
            this.collections_to.CustomFormat = "yyyy-MM-dd";
            this.collections_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.collections_to.Location = new System.Drawing.Point(308, 12);
            this.collections_to.Name = "collections_to";
            this.collections_to.Size = new System.Drawing.Size(153, 24);
            this.collections_to.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "To :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "From: ";
            // 
            // collections_from
            // 
            this.collections_from.CustomFormat = "yyyy-MM-dd";
            this.collections_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.collections_from.Location = new System.Drawing.Point(81, 12);
            this.collections_from.Name = "collections_from";
            this.collections_from.Size = new System.Drawing.Size(153, 24);
            this.collections_from.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1016, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Collectibles Report";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btnprintCollectibles);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 494);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1010, 40);
            this.panel3.TabIndex = 5;
            // 
            // btnprintCollectibles
            // 
            this.btnprintCollectibles.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnprintCollectibles.Enabled = false;
            this.btnprintCollectibles.Location = new System.Drawing.Point(791, 0);
            this.btnprintCollectibles.Name = "btnprintCollectibles";
            this.btnprintCollectibles.Size = new System.Drawing.Size(215, 36);
            this.btnprintCollectibles.TabIndex = 5;
            this.btnprintCollectibles.Text = "Print Report";
            this.btnprintCollectibles.UseVisualStyleBackColor = true;
            this.btnprintCollectibles.Click += new System.EventHandler(this.btnprintCollectibles_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 61);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1010, 473);
            this.dataGridView2.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.btncollectiblesgo);
            this.panel4.Controls.Add(this.collectibles_to);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.collectibles_from);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1010, 58);
            this.panel4.TabIndex = 3;
            // 
            // btncollectiblesgo
            // 
            this.btncollectiblesgo.Location = new System.Drawing.Point(535, 12);
            this.btncollectiblesgo.Name = "btncollectiblesgo";
            this.btncollectiblesgo.Size = new System.Drawing.Size(153, 29);
            this.btncollectiblesgo.TabIndex = 4;
            this.btncollectiblesgo.Text = "Go";
            this.btncollectiblesgo.UseVisualStyleBackColor = true;
            this.btncollectiblesgo.Click += new System.EventHandler(this.btncollectiblesgo_Click);
            // 
            // collectibles_to
            // 
            this.collectibles_to.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.collectibles_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.collectibles_to.Location = new System.Drawing.Point(326, 12);
            this.collectibles_to.Name = "collectibles_to";
            this.collectibles_to.Size = new System.Drawing.Size(203, 24);
            this.collectibles_to.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(286, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "To :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "From: ";
            // 
            // collectibles_from
            // 
            this.collectibles_from.CustomFormat = "yyyy-MM-dd hh:mm:ss";
            this.collectibles_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.collectibles_from.Location = new System.Drawing.Point(81, 12);
            this.collectibles_from.Name = "collectibles_from";
            this.collectibles_from.Size = new System.Drawing.Size(199, 24);
            this.collectibles_from.TabIndex = 0;
            // 
            // All_Petron_dateRange_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 568);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "All_Petron_dateRange_Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "All_Petron_DateRange_Reports";
            this.Load += new System.EventHandler(this.All_Petron_dateRange_Reports_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker collections_from;
        private System.Windows.Forms.Button btncollectionsgo;
        private System.Windows.Forms.DateTimePicker collections_to;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnprintCollections;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnprintCollectibles;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btncollectiblesgo;
        private System.Windows.Forms.DateTimePicker collectibles_to;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker collectibles_from;
    }
}