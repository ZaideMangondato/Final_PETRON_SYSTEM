namespace Petron
{
    partial class Viscosity
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
            this.cbxcatname = new System.Windows.Forms.ComboBox();
            this.txtviscosityname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxtypename = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.New = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.dgvviscosity = new System.Windows.Forms.DataGridView();
            this.Search1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.txttypeid = new System.Windows.Forms.TextBox();
            this.txtcategid = new System.Windows.Forms.TextBox();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvviscosity)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxcatname
            // 
            this.cbxcatname.FormattingEnabled = true;
            this.cbxcatname.Location = new System.Drawing.Point(203, 155);
            this.cbxcatname.Name = "cbxcatname";
            this.cbxcatname.Size = new System.Drawing.Size(203, 21);
            this.cbxcatname.TabIndex = 10;
            this.cbxcatname.SelectedIndexChanged += new System.EventHandler(this.cbxcatname_SelectedIndexChanged);
            // 
            // txtviscosityname
            // 
            this.txtviscosityname.Location = new System.Drawing.Point(203, 55);
            this.txtviscosityname.Name = "txtviscosityname";
            this.txtviscosityname.Size = new System.Drawing.Size(205, 20);
            this.txtviscosityname.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(80, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Viscosity Name";
            // 
            // cbxtypename
            // 
            this.cbxtypename.FormattingEnabled = true;
            this.cbxtypename.Location = new System.Drawing.Point(203, 103);
            this.cbxtypename.Name = "cbxtypename";
            this.cbxtypename.Size = new System.Drawing.Size(203, 21);
            this.cbxtypename.TabIndex = 11;
            this.cbxtypename.SelectedIndexChanged += new System.EventHandler(this.cbxtypename_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter Viscosity Name To Be Search";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(133)))));
            this.tabPage1.Controls.Add(this.txtcategid);
            this.tabPage1.Controls.Add(this.txttypeid);
            this.tabPage1.Controls.Add(this.New);
            this.tabPage1.Controls.Add(this.txtviscosityname);
            this.tabPage1.Controls.Add(this.btnreset);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cbxtypename);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.cbxcatname);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(600, 291);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Viscosity";
            // 
            // New
            // 
            this.New.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.New.Location = new System.Drawing.Point(124, 233);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(126, 55);
            this.New.TabIndex = 5;
            this.New.Text = "SAVE";
            this.New.UseVisualStyleBackColor = false;
            this.New.Click += new System.EventHandler(this.New_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnreset.Location = new System.Drawing.Point(314, 233);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(121, 55);
            this.btnreset.TabIndex = 6;
            this.btnreset.Text = "Reset";
            this.btnreset.UseVisualStyleBackColor = false;
            // 
            // dgvviscosity
            // 
            this.dgvviscosity.AllowUserToAddRows = false;
            this.dgvviscosity.AllowUserToDeleteRows = false;
            this.dgvviscosity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvviscosity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvviscosity.Location = new System.Drawing.Point(3, 48);
            this.dgvviscosity.Name = "dgvviscosity";
            this.dgvviscosity.ReadOnly = true;
            this.dgvviscosity.RowHeadersVisible = false;
            this.dgvviscosity.Size = new System.Drawing.Size(588, 236);
            this.dgvviscosity.TabIndex = 0;
            // 
            // Search1
            // 
            this.Search1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.Search1.Location = new System.Drawing.Point(270, 20);
            this.Search1.Name = "Search1";
            this.Search1.Size = new System.Drawing.Size(192, 20);
            this.Search1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Search1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dgvviscosity);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(600, 291);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "All Viscosity";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(608, 317);
            this.tabControl1.TabIndex = 9;
            // 
            // txttypeid
            // 
            this.txttypeid.Location = new System.Drawing.Point(414, 103);
            this.txttypeid.Name = "txttypeid";
            this.txttypeid.Size = new System.Drawing.Size(83, 20);
            this.txttypeid.TabIndex = 14;
            // 
            // txtcategid
            // 
            this.txtcategid.Location = new System.Drawing.Point(414, 155);
            this.txtcategid.Name = "txtcategid";
            this.txtcategid.Size = new System.Drawing.Size(83, 20);
            this.txtcategid.TabIndex = 15;
            // 
            // Viscosity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(614, 331);
            this.Controls.Add(this.tabControl1);
            this.Name = "Viscosity";
            this.Text = "Viscosity";
            this.Load += new System.EventHandler(this.Viscosity_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvviscosity)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxcatname;
        private System.Windows.Forms.TextBox txtviscosityname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxtypename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button New;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.DataGridView dgvviscosity;
        private System.Windows.Forms.TextBox Search1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox txtcategid;
        private System.Windows.Forms.TextBox txttypeid;
    }
}