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
    public partial class Stock_Monitoring : Form
    {
        String constr = "data source=localhost;database=dbpetron2;user id=root; password=;";
        MySqlConnection con = null;
        MySqlDataAdapter da;
        MySqlDataReader rdr;
        MySqlCommand cmd;
        public Stock_Monitoring()
        {
            InitializeComponent();
        }
        public void loadProducts()
        {
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "select a.productid,a.product_name,a.description,e.no_of_stocks,b.category_name,c.type_name,d.viscosity_name,a.volume,a.unit_price from tblproduct_inv e,tblproduct a,tblcategory b,tbltype c,tblviscosity d where a.category_id = b.category_id and a.type_id = c.type_id and a.viscosity_id = d.viscosity_id and a.productid = e.productid";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgvproducts.DataSource = bSource;
        }
        public void loadstockentries()
        {
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = " select a.stock_entry_id,a.supplierid,b.supplier_name,a.date_stock_in from tblstockentry a,tblsupplier b where a.supplierid = b.supplierid ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgvstockentries.DataSource = bSource;
        }
        private void Stock_Monitoring_Load(object sender, EventArgs e)
        {
            loadProducts();
            loadstockentries();
        }

        private void dgvproducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;

            indexRow = e.RowIndex;
            DataGridViewRow row = dgvproducts.Rows[indexRow];

            txtprodid.Text = row.Cells[0].Value.ToString();//convert current row values into string and pass it to the textbox
            txtprodname.Text = row.Cells[1].Value.ToString();
            txtdesc.Text = row.Cells[2].Value.ToString();
            txtnostocks.Text = row.Cells[3].Value.ToString();
            txtcategory.Text = row.Cells[4].Value.ToString();
            txttype.Text = row.Cells[5].Value.ToString();
            txtviscosity.Text = row.Cells[6].Value.ToString();
            txtvolume.Text = row.Cells[7].Value.ToString();
            txtunitprice.Text = row.Cells[8].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtprodid.Text == "")
            {
                MessageBox.Show("Please Select a Product on the table");
            }
            else
            {
                Product_Stock_Entries er = new Product_Stock_Entries();
                er.txtprodid.Text = txtprodid.Text;
                er.txtprodname.Text = txtprodname.Text;
                er.ShowDialog();
            }
        }

        private void dgvstockentries_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;

            indexRow = e.RowIndex;
            DataGridViewRow row = dgvstockentries.Rows[indexRow];

            txtstockentryid.Text = row.Cells[0].Value.ToString();//convert current row values into string and pass it to the textbox
            txtsupplierid.Text = row.Cells[1].Value.ToString();
            txtsuppliername.Text = row.Cells[2].Value.ToString();
        }
        public void countProducts()
        {
            con = new MySqlConnection(constr);
            con.Open();
            string query = " select count(*) from tblstockentrylogs where stock_entry_id = '" + txtstockentryid.Text + "'"; // Select Statement with where clauses
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            rdr = cmd.ExecuteReader();

            while (rdr.Read() == true)
            {
                txtnumberproducts.Text = rdr.GetString("count(*)");
            }
            con.Close();
        }
        private void txtstockentryid_TextChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "select a.productid,b.product_name,a.date_stock_logs,a.tracecode from tblstockentrylogs a,tblproduct b where a.productid = b.productid and stock_entry_id = '"+txtstockentryid.Text+"' ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dataGridView1.DataSource = bSource;

            countProducts();
        }
    }
}
