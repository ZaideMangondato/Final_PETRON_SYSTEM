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
    public partial class Product_Stock_Entries : Form
    {
        String constr = "data source=localhost;database=dbpetron2;user id=root; password=;";
        MySqlConnection con = null;
        MySqlDataAdapter da;
        MySqlDataReader rdr;
        MySqlCommand cmd;
        public Product_Stock_Entries()
        {
            InitializeComponent();
        }
        public void loadProductStockEntries()
        {
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "select stock_entry_id,stock_added,date_stock_logs,tracecode from tblstockentrylogs where productid = '"+txtprodid.Text+"' ORDER BY date_stock_logs desc ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgvstockentries.DataSource = bSource; 
        }
        public void loadtotalstocks()
        {
                con = new MySqlConnection(constr);
                con.Open();
                string query = "select sum(stock_added) from tblstockentrylogs where productid = '" + txtprodid.Text + "' "; // Select Statement with where clauses
                cmd = new MySqlCommand(query);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read() == true)
                {
                    txttotalstockentries.Text = rdr.GetString("sum(stock_added)");
                }
                con.Close();
        }

        public void loadstockorders()
        {
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = " select transid,quantity,date_order,tracecode from tblorderlogs where productid = '" + txtprodid.Text + "' ORDER BY date_order desc ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgvstockorders.DataSource = bSource; 
        }
        public void loadstotalorderedstocks()
        {
            con = new MySqlConnection(constr);
            con.Open();
            string query = "select sum(quantity) from tblorderlogs where productid = '" + txtprodid.Text + "' "; // Select Statement with where clauses
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            rdr = cmd.ExecuteReader();

            while (rdr.Read() == true)
            {
                txttotalstockorders.Text = rdr.GetString("sum(quantity)");
            }
            con.Close();
        }
        private void Product_Stock_Entries_Load(object sender, EventArgs e)
        {
            loadProductStockEntries();
            loadtotalstocks();
            //-------------------------
            loadstockorders();
            loadstotalorderedstocks();

            //-----------------------
            int calcremainingstocks = Convert.ToInt32(txttotalstockentries.Text) - Convert.ToInt32(txttotalstockorders.Text);
            txttotalstocksremaining.Text = calcremainingstocks.ToString();

            
        }

        private void txtprodid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
