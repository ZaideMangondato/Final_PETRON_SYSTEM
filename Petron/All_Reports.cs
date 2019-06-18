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
    public partial class All_Reports : Form
    {
        MySqlConnection con = null;
        String constr = "data source=localhost;database=dbpetron2;user id=root;password=;";
        MySqlCommand cmd = null;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        public All_Reports()
        {
            InitializeComponent();
        }
        public void loadSalesToDataGridview()
        {
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from tblfullpaymentorder where date_order = '"+dtp_date.Text+"' ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_sales.DataSource = bSource;
        }
        private void All_Reports_Load(object sender, EventArgs e)
        {

            
            
            
            // TODO: This line of code loads data into the 'dbpetron2CollectiblesDataSet.view_collectibles' table. You can move, or remove it, as needed.
            this.view_collectiblesTableAdapter.Fill(this.dbpetron2CollectiblesDataSet.view_collectibles);
            // TODO: This line of code loads data into the 'dbpetron2DataSet.view_collections' table. You can move, or remove it, as needed.
            this.view_collectionsTableAdapter.Fill(this.dbpetron2DataSet.view_collections);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();

            
        }
        public void createViewSales()
        {
            con = new MySqlConnection(constr);
            con.Open();
            String query = " create or replace view view_salesreport as select a.transid,b.customer_name,a.totalamount,a.amt_rcvd,a.amt_change,a.date_order from tblfullpaymentorder a,tblcustomer b where a.customerid = b.customerid and date_order = '" + dtp_date.Text + "'    ";//Insert Query
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
        }
        private void btngo_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            
            createViewSales();

            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "select a.transid,b.customer_name,a.totalamount,a.amt_rcvd,a.amt_change,a.date_order from tblfullpaymentorder a,tblcustomer b where a.customerid = b.customerid and date_order = '" + dtp_date.Text + "' ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgv_sales.DataSource = bSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sales_Report sr = new Sales_Report();
            sr.Show();
            sr.txtdate.Text = dtp_date.Text;
        }
    }
}
