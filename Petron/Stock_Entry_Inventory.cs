using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Petron
{
    public partial class Stock_Entry_Inventory : Form
    {
        String constr = "data source=localhost;database=dbpetron2;user id=root; password=;";
        MySqlConnection con = null;
        MySqlDataAdapter da;
        MySqlDataReader rdr;
        MySqlCommand cmd;
        public Stock_Entry_Inventory()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            supplierpanel.Visible = true;
            loadSupplier();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            productpanel.Visible = true;
            loadproduct();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            supplierpanel.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            productpanel.Visible = false;
        }
        public void loadSupplier()
        {
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from tblsupplier";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgvsupplier.DataSource = bSource;
        }
        public void loadproduct()
        {
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT productid,product_name from tblproduct";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgvproduct.DataSource = bSource;
            //SELECT a.stock_entry_id,a.productid,b.product_name,a.stock_added,a.date_stock_logs from tblstockentrylogs a,tblproduct b where a.productid = b.productid and a.stock_entry_id = '"+txtstockentryid.Text+"' 
        }


        public void loadcurrentstockentrygrid()
        {
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT a.stock_entry_id,a.productid,b.product_name,a.stock_added,a.date_stock_logs,a.tracecode from tblstockentrylogs a,tblproduct b where a.productid = b.productid and a.stock_entry_id = '" + txtstockentryid.Text + "' ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgvstockentry.DataSource = bSource;

            countEntries();
        }
        public void countEntries()
        {
            con = new MySqlConnection(constr);
            con.Open();
            cmd = new MySqlCommand("select count(*) from tblstockentrylogs where stock_entry_id = '"+txtstockentryid.Text+"' ", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                txtcountentries.Text = rdr.GetString("count(*)");
            }
            con.Close();
        }
        private void Stock_Entry_Inventory_Load(object sender, EventArgs e)
        {
            loadSupplier();
            loadproduct();
            loadcurrentstockentrygrid();
            
        }

        private void dgvsupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;

            indexRow = e.RowIndex;
            DataGridViewRow row = dgvsupplier.Rows[indexRow];

            txtsuppid.Text = row.Cells[0].Value.ToString();//convert current row values into string and pass it to the textbox
            txtsuppname.Text = row.Cells[1].Value.ToString();
            supplierpanel.Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;

            indexRow = e.RowIndex;
            DataGridViewRow row = dgvproduct.Rows[indexRow];

            txtprodid.Text = row.Cells[0].Value.ToString();//convert current row values into string and pass it to the textbox
            txtprodname.Text = row.Cells[1].Value.ToString();
            productpanel.Visible = false;
        }

        private void txtprodid_TextChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(constr);
                con.Open();
                string query = " select * from tblproduct_inv where productid = '"+txtprodid.Text+"' "; // Select Statement with where clauses
                cmd = new MySqlCommand(query);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read() == true)
                {
                    string curstock = rdr.GetString("no_of_stocks");
                    txtcurrentstock.Text = curstock;
                }
                con.Close();
        }
        public void savestockentrylogs()
        {
            int calcAllstock = Convert.ToInt32(txtcurrentstock.Text) + Convert.ToInt32(txtaddstock.Text);

            con = new MySqlConnection(constr);
            con.Open();
            String query = " insert into tblstockentrylogs(stock_entry_id,productid,stock_added,date_stock_logs,tracecode)values('"+txtstockentryid.Text+"','"+txtprodid.Text+"','"+txtaddstock.Text+"',curdate(),'"+txttracecode.Text+"') ";//Insert Query
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Successfully Added Stock");
        }
        public void updateproductinv()
        {
            int calcAllstock = Convert.ToInt32(txtcurrentstock.Text) + Convert.ToInt32(txtaddstock.Text);

            con = new MySqlConnection(constr);
            con.Open();
            String query = " update tblproduct_inv set no_of_stocks = '" + calcAllstock +"' where productid = '"+txtprodid.Text+"' ";//Insert Query
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Product "+txtprodid.Text+" stock updated to "+calcAllstock+"(pcs) stocks");
        }
        private void btnaddstock_Click(object sender, EventArgs e)
        {
            if (txtsuppid.Text == "" || txtprodid.Text == "" || txtaddstock.Text == "0" || txtaddstock.Text == "")
            {
                MessageBox.Show("Please Select a necessary Requirements");
            }
            else
            {
                int calcAllstock = Convert.ToInt32(txtcurrentstock.Text) + Convert.ToInt32(txtaddstock.Text);
                //MessageBox.Show(calcAllstock+"");
                try
                {
                    savestockentrylogs();
                    updateproductinv();
                    loadcurrentstockentrygrid();
                    txtprodid.Text = "";
                    txtprodname.Text = "";
                    txtcurrentstock.Text = "";
                    txtaddstock.Text = "0";
                    txttracecode.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
                
            }
        }

        private void dgvstockentry_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panel2.Visible = true;
            int indexRow;

            indexRow = e.RowIndex;
            DataGridViewRow row = dgvstockentry.Rows[indexRow];

            reprodid.Text = row.Cells[1].Value.ToString();//convert current row values into string and pass it to the textbox
            reprodname.Text = row.Cells[2].Value.ToString();
            readdedstock.Text = row.Cells[3].Value.ToString();
            retracecode.Text = row.Cells[5].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        private void reprodid_TextChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(constr);
                con.Open();
                string query = "select * from tblproduct_inv where productid = '" + reprodid.Text + "' "; // Select Statement with where clauses
                cmd = new MySqlCommand(query);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read() == true)
                {
                    recurstock.Text = rdr.GetString("no_of_stocks");
                }
                con.Close();
        }
        
        public void updatetooriginal()
        {
            con = new MySqlConnection(constr);
            con.Open();
            String query = "  update tblproduct_inv set no_of_stocks = '"+(Convert.ToInt32(recurstock.Text)-Convert.ToInt32(readdedstock.Text) )+"' where productid = '"+reprodid.Text+"' "; // Update Query Statement
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Product stock returned to Previous Quantity.");
        }
        public void deleteLogs()
        {
            con = new MySqlConnection(constr);
            con.Open();
            String query = "  delete from tblstockentrylogs where productid = '" + reprodid.Text + "' and stock_entry_id = '" + txtstockentryid.Text + "' and tracecode = '"+retracecode.Text+"' "; // Update Query Statement
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Successfully delete from Entry Logs.");
        }
        private void button6_Click(object sender, EventArgs e)
        {
            updatetooriginal();
            deleteLogs();
            panel2.Visible = false;
            reprodid.Text = "";
            reprodname.Text = "";
            recurstock.Text = "";
            readdedstock.Text = "";
            loadcurrentstockentrygrid();
        }

        private void txtsuppid_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT productid,product_name from tblproduct where product_name like '%"+textBox7.Text.Replace("'","")+"%' ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgvproduct.DataSource = bSource;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from tblsupplier where supplier_name like '%"+ textBox6.Text.Replace("'","") +"%' ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgvsupplier.DataSource = bSource;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtcountentries.Text == "0")
            {
                MessageBox.Show("Add atleast 1 Stock Entry");
            }
            else
            {
                panel3.Visible = true;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtcountentries.Text == "0")
            {
                MessageBox.Show("Add atleast 1 Stock Entry");
            }
            else
            {
                try
                {
                    con = new MySqlConnection(constr);
                    con.Open();
                    String query = " insert into tblstockentry(stock_entry_id,supplierid,date_stock_in)values('" + txtstockentryid.Text + "','" + txtsuppid.Text + "',curdate()) ";//Insert Query
                    cmd = new MySqlCommand(query);
                    cmd.Connection = con;
                    cmd.ExecuteReader();
                    con.Close();
                    MessageBox.Show("Stock Entry Saved.");

                    txtprodid.Text = "";
                    txtprodname.Text = "";
                    txtcurrentstock.Text = "";
                    txtaddstock.Text = "0";
                    txttracecode.Text = "";

                    txtstockentryid.Text = "";
                    txtsuppid.Text = "";
                    txtsuppname.Text = "";

                    loadSupplier();
                    loadproduct();
                    loadcurrentstockentrygrid();

                    supplierpanel.Visible = true;
                    productpanel.Visible = true;
                    panel3.Visible = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;

        }

      
    }
}
