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
    public partial class Billing : Form
    {
        String constr = "data source=localhost;database=dbpetron2;user id=root; password=;";
        MySqlConnection con = null;
        MySqlDataAdapter da;
        MySqlDataReader rdr;
        MySqlCommand cmd;
        public Billing()
        {
            InitializeComponent();
        }
        public void loadcustomerlist()
        {
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from tblcustomer";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgvcustomerlist.DataSource = bSource;
        }
        private void Billing_Load(object sender, EventArgs e)
        {
            loadcustomerlist();
        }

        private void dgvcustomerlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;

            indexRow = e.RowIndex;
            DataGridViewRow row = dgvcustomerlist.Rows[indexRow];

            txtshowunpaidtrans.Text = row.Cells[0].Value.ToString();
            txtshowcustname.Text = row.Cells[1].Value.ToString();

            b_custid.Text = row.Cells[0].Value.ToString();
            b_custname.Text = row.Cells[1].Value.ToString();
            b_addr.Text = row.Cells[2].Value.ToString();
            b_num.Text = row.Cells[3].Value.ToString();
            b_compaff.Text = row.Cells[4].Value.ToString();
            b_comppos.Text = row.Cells[5].Value.ToString(); 


        }
        public void createViewCustomerTransactions()
        {
            con = new MySqlConnection(constr);
            con.Open();
            String query = "create or replace view view_selectedCustomerTransactions as SELECT transid,totalamount,totalamount - balance 'totalamountpaid',balance,date_order,bill_remark from tbldownpaymentorder where customerid = '" + txtshowunpaidtrans.Text + "' ";//Insert Query
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
            //MessageBox.Show("Successfully Saved.");
        }
        private void txtshowunpaidtrans_TextChanged(object sender, EventArgs e)
        {
            createViewCustomerTransactions();

            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT transid,totalamount,balance,date_order,bill_remark from tbldownpaymentorder where customerid = '"+txtshowunpaidtrans.Text+"' ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgvunpaidtrans.DataSource = bSource; 
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void dgvunpaidtrans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;

            indexRow = e.RowIndex;
            DataGridViewRow row = dgvunpaidtrans.Rows[indexRow];

            txttransid.Text = row.Cells[0].Value.ToString();
            txttransid2.Text = row.Cells[0].Value.ToString();
            txttotalamount.Text = row.Cells[1].Value.ToString();
            txttotalamount2.Text = row.Cells[1].Value.ToString();
            txtbalance.Text = row.Cells[2].Value.ToString();
            lbldateordered.Text = row.Cells[3].Value.ToString();
            lblremark.Text = row.Cells[4].Value.ToString();
            lblremark2.Text = row.Cells[4].Value.ToString();
        }
        public void loadcustomerid()
        {
            con = new MySqlConnection(constr);
                con.Open();
                string query = "select customerid from tbldownpaymentorder where transid = '"+txttransid.Text+"' "; // Select Statement with where clauses
                cmd = new MySqlCommand(query);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    txtcustid.Text = rdr.GetString("customerid");
                    
                    
                }
                
                con.Close();
                txtcustid2.Text = txtcustid.Text;
        }

        public void loadcustomerinfo()
        {
            con = new MySqlConnection(constr);
            con.Open();
            string query = "  select customer_name,address,contact_number,company_affiliation,company_position from tblcustomer where customerid = '" + txtshowunpaidtrans.Text + "'  "; // Select Statement with where clauses
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            rdr = cmd.ExecuteReader();

            while (rdr.Read() == true)
            {
                txtcustname.Text = rdr.GetString("customer_name");
                txtcustname2.Text = rdr.GetString("customer_name");
                txtcustaddr.Text = rdr.GetString("address");
                txtcustnum.Text = rdr.GetString("contact_number");
                txtcustcompaff.Text = rdr.GetString("company_affiliation");
                txtcustcomppos.Text = rdr.GetString("company_position");
            }

            con.Close();
        }

        public void loadpayments()
        {
            //or_id,total_mount,payment,balance,date_payment,payment_remark
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT or_no,totalamount,payment,balance,date_payment,payment_remark from tblpayments where transid = '" + txttransid.Text + "' order by date_payment desc ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgvpayments.DataSource = bSource;

            loadsumpayments();
        }

        public void loadsumpayments()
        {
            con = new MySqlConnection(constr);
                con.Open();
                string query = "SELECT sum(payment) from tblpayments where transid = '" + txttransid.Text + "' "; // Select Statement with where clauses
                cmd = new MySqlCommand(query);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read() == true)
                {
                    txttotalamountpaid.Text = rdr.GetString("sum(payment)");
                }
                con.Close();
        }
        private void txttransid_TextChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "select a.productid,b.product_name,a.quantity,a.unit_price,a.total_price,a.tracecode from tblorderlogs a, tblproduct b where a.productid = b.productid and a.transid = '" + txttransid.Text + "' ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgvcart.DataSource = bSource;
            con.Close();

            loadcustomerid();

            loadcustomerinfo();

            loadpayments();
        }

        private void lblremark_Click(object sender, EventArgs e)
        {

        }

        private void txtcustid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Billing_Statement bs = new Billing_Statement();
            bs.Show();
            bs.bstxttransid.Text = this.txttransid.Text;
            bs.bstxtcustid.Text = this.txtcustid.Text;
            bs.bstxtname.Text = this.txtcustname.Text;
            bs.bstxtaddress.Text = this.txtcustaddr.Text;
            bs.bstxtdatetrans.Text = this.lbldateordered.Text;
            bs.bstxttotalamount.Text = this.txttotalamount.Text;
            bs.bstxtamountpaid.Text = this.txttotalamountpaid.Text;
            bs.bstxtbalance.Text = this.txtbalance.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtshowunpaidtrans.Text == "")
            {
                MessageBox.Show("Please Select A Customer");
            }
            else
            {
                Print_Customer_Transactions pct = new Print_Customer_Transactions();
                
                pct.Show();
                pct.pct_custid.Text = this.b_custid.Text;
                pct.pct_custname.Text = this.b_custname.Text;
                pct.pct_addr.Text = this.b_addr.Text;
                pct.pct_num.Text = this.b_num.Text;
                pct.pct_compaff.Text = this.b_compaff.Text;
                pct.pct_comppos.Text = this.b_comppos.Text;
                
            }
            
            

        }
    }
}
