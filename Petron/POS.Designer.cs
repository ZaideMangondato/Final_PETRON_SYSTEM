namespace Petron
{
    partial class POS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(POS));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Data1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.recno = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.subclassi = new System.Windows.Forms.TextBox();
            this.classi = new System.Windows.Forms.TextBox();
            this.stockdesc = new System.Windows.Forms.TextBox();
            this.stockname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.quanorder = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.stockhand = new System.Windows.Forms.TextBox();
            this.unitprice = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.newtrans = new System.Windows.Forms.Button();
            this.savetrans = new System.Windows.Forms.Button();
            this.cancelitem = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.payableamount = new System.Windows.Forms.TextBox();
            this.discount = new System.Windows.Forms.TextBox();
            this.amountpaid = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.change = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(133)))));
            this.groupBox1.Controls.Add(this.search);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(465, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(210, 33);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(244, 22);
            this.search.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type Stock Name to Search";
            // 
            // Data1
            // 
            this.Data1.AllowUserToAddRows = false;
            this.Data1.AllowUserToDeleteRows = false;
            this.Data1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data1.Location = new System.Drawing.Point(5, 94);
            this.Data1.Name = "Data1";
            this.Data1.ReadOnly = true;
            this.Data1.RowHeadersVisible = false;
            this.Data1.Size = new System.Drawing.Size(465, 595);
            this.Data1.TabIndex = 1;
            this.Data1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(477, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Receipt No.";
            // 
            // recno
            // 
            this.recno.Enabled = false;
            this.recno.Location = new System.Drawing.Point(569, 22);
            this.recno.Name = "recno";
            this.recno.Size = new System.Drawing.Size(167, 20);
            this.recno.TabIndex = 3;
            this.recno.TextChanged += new System.EventHandler(this.recno_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.subclassi);
            this.groupBox2.Controls.Add(this.classi);
            this.groupBox2.Controls.Add(this.stockdesc);
            this.groupBox2.Controls.Add(this.stockname);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(474, 49);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 169);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stock Information";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // subclassi
            // 
            this.subclassi.Location = new System.Drawing.Point(136, 127);
            this.subclassi.Name = "subclassi";
            this.subclassi.Size = new System.Drawing.Size(198, 22);
            this.subclassi.TabIndex = 7;
            // 
            // classi
            // 
            this.classi.Location = new System.Drawing.Point(137, 93);
            this.classi.Name = "classi";
            this.classi.Size = new System.Drawing.Size(197, 22);
            this.classi.TabIndex = 6;
            // 
            // stockdesc
            // 
            this.stockdesc.Location = new System.Drawing.Point(137, 59);
            this.stockdesc.Name = "stockdesc";
            this.stockdesc.Size = new System.Drawing.Size(197, 22);
            this.stockdesc.TabIndex = 5;
            // 
            // stockname
            // 
            this.stockname.Location = new System.Drawing.Point(136, 28);
            this.stockname.Name = "stockname";
            this.stockname.Size = new System.Drawing.Size(197, 22);
            this.stockname.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Sub-Classification";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Classification";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Stock Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Stock Name";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.quanorder);
            this.groupBox3.Location = new System.Drawing.Point(473, 224);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(348, 54);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(15, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Quantity ordered";
            // 
            // quanorder
            // 
            this.quanorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quanorder.Location = new System.Drawing.Point(137, 12);
            this.quanorder.Name = "quanorder";
            this.quanorder.Size = new System.Drawing.Size(197, 31);
            this.quanorder.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(782, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "Transaction Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(909, 23);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(207, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBox9);
            this.groupBox4.Controls.Add(this.stockhand);
            this.groupBox4.Controls.Add(this.unitprice);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(827, 49);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(289, 169);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox9.Enabled = false;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(125, 108);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(153, 49);
            this.textBox9.TabIndex = 3;
            // 
            // stockhand
            // 
            this.stockhand.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.stockhand.Enabled = false;
            this.stockhand.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockhand.Location = new System.Drawing.Point(125, 24);
            this.stockhand.Name = "stockhand";
            this.stockhand.Size = new System.Drawing.Size(153, 49);
            this.stockhand.TabIndex = 2;
            // 
            // unitprice
            // 
            this.unitprice.AutoSize = true;
            this.unitprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitprice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.unitprice.Location = new System.Drawing.Point(16, 124);
            this.unitprice.Name = "unitprice";
            this.unitprice.Size = new System.Drawing.Size(72, 18);
            this.unitprice.TabIndex = 1;
            this.unitprice.Text = "Unit Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(7, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Stock on Hand";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(838, 231);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 45);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add to Cart";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView1);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox5.Location = new System.Drawing.Point(474, 282);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(642, 270);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cart";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(625, 239);
            this.dataGridView1.TabIndex = 0;
            // 
            // newtrans
            // 
            this.newtrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newtrans.Location = new System.Drawing.Point(977, 640);
            this.newtrans.Name = "newtrans";
            this.newtrans.Size = new System.Drawing.Size(128, 49);
            this.newtrans.TabIndex = 11;
            this.newtrans.Text = "New Transaction";
            this.newtrans.UseVisualStyleBackColor = true;
            this.newtrans.Click += new System.EventHandler(this.newtrans_Click);
            // 
            // savetrans
            // 
            this.savetrans.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savetrans.Location = new System.Drawing.Point(837, 640);
            this.savetrans.Name = "savetrans";
            this.savetrans.Size = new System.Drawing.Size(128, 49);
            this.savetrans.TabIndex = 12;
            this.savetrans.Text = "Proceed and Save Transaction";
            this.savetrans.UseVisualStyleBackColor = true;
            // 
            // cancelitem
            // 
            this.cancelitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelitem.Location = new System.Drawing.Point(693, 640);
            this.cancelitem.Name = "cancelitem";
            this.cancelitem.Size = new System.Drawing.Size(128, 49);
            this.cancelitem.TabIndex = 13;
            this.cancelitem.Text = "Cancel Item";
            this.cancelitem.UseVisualStyleBackColor = true;
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(545, 640);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(128, 49);
            this.close.TabIndex = 14;
            this.close.Text = "Close";
            this.close.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(486, 571);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(164, 20);
            this.label11.TabIndex = 2;
            this.label11.Text = "Total Payable Amount";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(578, 606);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 20);
            this.label12.TabIndex = 15;
            this.label12.Text = "Discount";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(837, 571);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 20);
            this.label13.TabIndex = 16;
            this.label13.Text = "Amount Paid";
            // 
            // payableamount
            // 
            this.payableamount.Enabled = false;
            this.payableamount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payableamount.ForeColor = System.Drawing.Color.DarkRed;
            this.payableamount.Location = new System.Drawing.Point(659, 565);
            this.payableamount.Name = "payableamount";
            this.payableamount.Size = new System.Drawing.Size(162, 29);
            this.payableamount.TabIndex = 17;
            this.payableamount.Text = "0";
            // 
            // discount
            // 
            this.discount.Enabled = false;
            this.discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discount.ForeColor = System.Drawing.Color.DarkRed;
            this.discount.Location = new System.Drawing.Point(659, 600);
            this.discount.Name = "discount";
            this.discount.Size = new System.Drawing.Size(162, 29);
            this.discount.TabIndex = 18;
            this.discount.Text = "0";
            // 
            // amountpaid
            // 
            this.amountpaid.Enabled = false;
            this.amountpaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountpaid.ForeColor = System.Drawing.Color.DarkRed;
            this.amountpaid.Location = new System.Drawing.Point(943, 565);
            this.amountpaid.Name = "amountpaid";
            this.amountpaid.Size = new System.Drawing.Size(162, 29);
            this.amountpaid.TabIndex = 19;
            this.amountpaid.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(869, 606);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 20);
            this.label14.TabIndex = 20;
            this.label14.Text = "Change";
            // 
            // change
            // 
            this.change.Enabled = false;
            this.change.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change.ForeColor = System.Drawing.Color.DarkRed;
            this.change.Location = new System.Drawing.Point(943, 600);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(162, 29);
            this.change.TabIndex = 21;
            this.change.Text = "0";
            // 
            // POS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(36)))), ((int)(((byte)(133)))));
            this.ClientSize = new System.Drawing.Size(1131, 701);
            this.Controls.Add(this.change);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.amountpaid);
            this.Controls.Add(this.discount);
            this.Controls.Add(this.payableamount);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.close);
            this.Controls.Add(this.cancelitem);
            this.Controls.Add(this.savetrans);
            this.Controls.Add(this.newtrans);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.recno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Data1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "POS";
            this.Text = "POS";
            this.Load += new System.EventHandler(this.POS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search;
        private System.Windows.Forms.DataGridView Data1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox recno;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox subclassi;
        private System.Windows.Forms.TextBox classi;
        private System.Windows.Forms.TextBox stockdesc;
        private System.Windows.Forms.TextBox stockname;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox quanorder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox stockhand;
        private System.Windows.Forms.Label unitprice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button newtrans;
        private System.Windows.Forms.Button savetrans;
        private System.Windows.Forms.Button cancelitem;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox payableamount;
        private System.Windows.Forms.TextBox discount;
        private System.Windows.Forms.TextBox amountpaid;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox change;

    }
}