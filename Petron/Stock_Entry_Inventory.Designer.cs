namespace Petron
{
    partial class Stock_Entry_Inventory
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
            this.txtstockentryid = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsuppid = new System.Windows.Forms.TextBox();
            this.txtsuppname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txtprodname = new System.Windows.Forms.TextBox();
            this.txtprodid = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.productpanel = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.dgvproduct = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.supplierpanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dgvsupplier = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcurrentstock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtaddstock = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvstockentry = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.btnaddstock = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txttracecode = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.retracecode = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.readdedstock = new System.Windows.Forms.TextBox();
            this.recurstock = new System.Windows.Forms.TextBox();
            this.reprodname = new System.Windows.Forms.TextBox();
            this.reprodid = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.txtcountentries = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.productpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).BeginInit();
            this.supplierpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaddstock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstockentry)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtstockentryid
            // 
            this.txtstockentryid.CustomFormat = "SE-yyMMddhhmmss";
            this.txtstockentryid.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtstockentryid.Location = new System.Drawing.Point(109, 20);
            this.txtstockentryid.Name = "txtstockentryid";
            this.txtstockentryid.Size = new System.Drawing.Size(170, 20);
            this.txtstockentryid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Stock Entry ID";
            // 
            // txtsuppid
            // 
            this.txtsuppid.Location = new System.Drawing.Point(109, 66);
            this.txtsuppid.Name = "txtsuppid";
            this.txtsuppid.ReadOnly = true;
            this.txtsuppid.Size = new System.Drawing.Size(170, 20);
            this.txtsuppid.TabIndex = 3;
            this.txtsuppid.TextChanged += new System.EventHandler(this.txtsuppid_TextChanged);
            // 
            // txtsuppname
            // 
            this.txtsuppname.Location = new System.Drawing.Point(109, 92);
            this.txtsuppname.Name = "txtsuppname";
            this.txtsuppname.ReadOnly = true;
            this.txtsuppname.Size = new System.Drawing.Size(265, 20);
            this.txtsuppname.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(22, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Supplier ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Supplier Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(407, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Product Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(407, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Product ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(670, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Select";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtprodname
            // 
            this.txtprodname.Location = new System.Drawing.Point(494, 92);
            this.txtprodname.Name = "txtprodname";
            this.txtprodname.ReadOnly = true;
            this.txtprodname.Size = new System.Drawing.Size(265, 20);
            this.txtprodname.TabIndex = 9;
            this.txtprodname.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtprodid
            // 
            this.txtprodid.Location = new System.Drawing.Point(494, 66);
            this.txtprodid.Name = "txtprodid";
            this.txtprodid.ReadOnly = true;
            this.txtprodid.Size = new System.Drawing.Size(170, 20);
            this.txtprodid.TabIndex = 8;
            this.txtprodid.TextChanged += new System.EventHandler(this.txtprodid_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.productpanel);
            this.panel1.Controls.Add(this.supplierpanel);
            this.panel1.Location = new System.Drawing.Point(765, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(292, 442);
            this.panel1.TabIndex = 13;
            // 
            // productpanel
            // 
            this.productpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productpanel.Controls.Add(this.label13);
            this.productpanel.Controls.Add(this.label10);
            this.productpanel.Controls.Add(this.textBox7);
            this.productpanel.Controls.Add(this.dgvproduct);
            this.productpanel.Controls.Add(this.button5);
            this.productpanel.Location = new System.Drawing.Point(3, 232);
            this.productpanel.Name = "productpanel";
            this.productpanel.Size = new System.Drawing.Size(280, 203);
            this.productpanel.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(5, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Search";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Select Product";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(3, 45);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(270, 20);
            this.textBox7.TabIndex = 10;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // dgvproduct
            // 
            this.dgvproduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduct.Location = new System.Drawing.Point(3, 68);
            this.dgvproduct.Name = "dgvproduct";
            this.dgvproduct.Size = new System.Drawing.Size(270, 128);
            this.dgvproduct.TabIndex = 2;
            this.dgvproduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproduct_CellContentClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(245, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(28, 32);
            this.button5.TabIndex = 1;
            this.button5.Text = "X";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // supplierpanel
            // 
            this.supplierpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.supplierpanel.Controls.Add(this.label11);
            this.supplierpanel.Controls.Add(this.label9);
            this.supplierpanel.Controls.Add(this.textBox6);
            this.supplierpanel.Controls.Add(this.dgvsupplier);
            this.supplierpanel.Controls.Add(this.button4);
            this.supplierpanel.Location = new System.Drawing.Point(3, 4);
            this.supplierpanel.Name = "supplierpanel";
            this.supplierpanel.Size = new System.Drawing.Size(280, 222);
            this.supplierpanel.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(4, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Search";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Select Supplier";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(3, 55);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(270, 20);
            this.textBox6.TabIndex = 22;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // dgvsupplier
            // 
            this.dgvsupplier.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvsupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsupplier.Location = new System.Drawing.Point(3, 78);
            this.dgvsupplier.Name = "dgvsupplier";
            this.dgvsupplier.Size = new System.Drawing.Size(270, 134);
            this.dgvsupplier.TabIndex = 3;
            this.dgvsupplier.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsupplier_CellContentClick);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(245, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(28, 32);
            this.button4.TabIndex = 0;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(407, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Current Stock";
            // 
            // txtcurrentstock
            // 
            this.txtcurrentstock.Location = new System.Drawing.Point(494, 118);
            this.txtcurrentstock.Name = "txtcurrentstock";
            this.txtcurrentstock.ReadOnly = true;
            this.txtcurrentstock.Size = new System.Drawing.Size(142, 20);
            this.txtcurrentstock.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(407, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Add Stock";
            // 
            // txtaddstock
            // 
            this.txtaddstock.Location = new System.Drawing.Point(494, 145);
            this.txtaddstock.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.txtaddstock.Name = "txtaddstock";
            this.txtaddstock.Size = new System.Drawing.Size(120, 20);
            this.txtaddstock.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(620, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "PCS";
            // 
            // dgvstockentry
            // 
            this.dgvstockentry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvstockentry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstockentry.Location = new System.Drawing.Point(25, 211);
            this.dgvstockentry.Name = "dgvstockentry";
            this.dgvstockentry.Size = new System.Drawing.Size(734, 212);
            this.dgvstockentry.TabIndex = 20;
            this.dgvstockentry.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvstockentry_CellContentClick);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(494, 429);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(265, 39);
            this.button3.TabIndex = 21;
            this.button3.Text = "Save Stock Entry";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnaddstock
            // 
            this.btnaddstock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddstock.ForeColor = System.Drawing.Color.White;
            this.btnaddstock.Location = new System.Drawing.Point(494, 171);
            this.btnaddstock.Name = "btnaddstock";
            this.btnaddstock.Size = new System.Drawing.Size(265, 34);
            this.btnaddstock.TabIndex = 22;
            this.btnaddstock.Text = "ADD STOCK";
            this.btnaddstock.UseVisualStyleBackColor = true;
            this.btnaddstock.Click += new System.EventHandler(this.btnaddstock_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(407, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Tracecode";
            // 
            // txttracecode
            // 
            this.txttracecode.CustomFormat = "TR-mmssyyMMddhh";
            this.txttracecode.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txttracecode.Location = new System.Drawing.Point(494, 19);
            this.txttracecode.Name = "txttracecode";
            this.txttracecode.Size = new System.Drawing.Size(170, 20);
            this.txttracecode.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.retracecode);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.readdedstock);
            this.panel2.Controls.Add(this.recurstock);
            this.panel2.Controls.Add(this.reprodname);
            this.panel2.Controls.Add(this.reprodid);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.button7);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Location = new System.Drawing.Point(185, 265);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(399, 149);
            this.panel2.TabIndex = 25;
            this.panel2.Visible = false;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(26, 78);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(352, 36);
            this.label19.TabIndex = 24;
            this.label19.Text = "Do you really want to Remove the Entery and \r\nReturn the Stock to previuos quanti" +
    "ty?";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 57);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 13);
            this.label18.TabIndex = 23;
            this.label18.Text = "Tracecode";
            // 
            // retracecode
            // 
            this.retracecode.Location = new System.Drawing.Point(81, 54);
            this.retracecode.Name = "retracecode";
            this.retracecode.ReadOnly = true;
            this.retracecode.Size = new System.Drawing.Size(124, 20);
            this.retracecode.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(226, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 21;
            this.label17.Text = "Added Stock";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(226, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Current Stock";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 31);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(75, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Product Name";
            // 
            // readdedstock
            // 
            this.readdedstock.Location = new System.Drawing.Point(321, 28);
            this.readdedstock.Name = "readdedstock";
            this.readdedstock.ReadOnly = true;
            this.readdedstock.Size = new System.Drawing.Size(71, 20);
            this.readdedstock.TabIndex = 18;
            // 
            // recurstock
            // 
            this.recurstock.Location = new System.Drawing.Point(321, 2);
            this.recurstock.Name = "recurstock";
            this.recurstock.ReadOnly = true;
            this.recurstock.Size = new System.Drawing.Size(71, 20);
            this.recurstock.TabIndex = 17;
            // 
            // reprodname
            // 
            this.reprodname.Location = new System.Drawing.Point(81, 28);
            this.reprodname.Name = "reprodname";
            this.reprodname.ReadOnly = true;
            this.reprodname.Size = new System.Drawing.Size(124, 20);
            this.reprodname.TabIndex = 16;
            // 
            // reprodid
            // 
            this.reprodid.Location = new System.Drawing.Point(81, 2);
            this.reprodid.Name = "reprodid";
            this.reprodid.ReadOnly = true;
            this.reprodid.Size = new System.Drawing.Size(124, 20);
            this.reprodid.TabIndex = 15;
            this.reprodid.TextChanged += new System.EventHandler(this.reprodid_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 5);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Product ID";
            // 
            // button7
            // 
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(193, 119);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 1;
            this.button7.Text = "Cancel";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(112, 119);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 0;
            this.button6.Text = "Remove";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(22, 429);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(70, 13);
            this.label20.TabIndex = 26;
            this.label20.Text = "Stock Entries";
            // 
            // txtcountentries
            // 
            this.txtcountentries.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcountentries.Location = new System.Drawing.Point(25, 445);
            this.txtcountentries.Name = "txtcountentries";
            this.txtcountentries.ReadOnly = true;
            this.txtcountentries.Size = new System.Drawing.Size(67, 29);
            this.txtcountentries.TabIndex = 27;
            this.txtcountentries.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Location = new System.Drawing.Point(204, 163);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(399, 100);
            this.panel3.TabIndex = 28;
            this.panel3.Visible = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(194, 54);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(109, 35);
            this.button9.TabIndex = 27;
            this.button9.Text = "NO";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(79, 54);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(109, 35);
            this.button8.TabIndex = 26;
            this.button8.Text = "SAVE";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(13, 13);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(365, 18);
            this.label21.TabIndex = 25;
            this.label21.Text = "Are you sure you want to save the Stock Entry?";
            // 
            // Stock_Entry_Inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(1062, 486);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtcountentries);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txttracecode);
            this.Controls.Add(this.btnaddstock);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvstockentry);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtaddstock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcurrentstock);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtprodname);
            this.Controls.Add(this.txtprodid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsuppname);
            this.Controls.Add(this.txtsuppid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtstockentryid);
            this.Name = "Stock_Entry_Inventory";
            this.Text = "Stock_Entry_Inventory";
            this.Load += new System.EventHandler(this.Stock_Entry_Inventory_Load);
            this.panel1.ResumeLayout(false);
            this.productpanel.ResumeLayout(false);
            this.productpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).EndInit();
            this.supplierpanel.ResumeLayout(false);
            this.supplierpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaddstock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstockentry)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker txtstockentryid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsuppid;
        private System.Windows.Forms.TextBox txtsuppname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtprodname;
        private System.Windows.Forms.TextBox txtprodid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcurrentstock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtaddstock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvstockentry;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel productpanel;
        private System.Windows.Forms.Panel supplierpanel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.DataGridView dgvproduct;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridView dgvsupplier;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnaddstock;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker txttracecode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox readdedstock;
        private System.Windows.Forms.TextBox recurstock;
        private System.Windows.Forms.TextBox reprodname;
        private System.Windows.Forms.TextBox reprodid;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox retracecode;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txtcountentries;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label21;
    }
}