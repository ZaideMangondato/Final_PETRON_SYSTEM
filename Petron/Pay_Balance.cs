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
    public partial class Pay_Balance : Form
    {
        String constr = "data source=localhost;database=dbpetron2;user id=root; password=;";
        MySqlConnection con = null;
        MySqlDataAdapter da;
        MySqlDataReader rdr;
        MySqlCommand cmd;
        public Pay_Balance()
        {
            InitializeComponent();
        }
        public void loadcustomers()
        {
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT customerid,customer_name from tblcustomer";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgvcustomerlist.DataSource = bSource; 
        }
        private void Pay_Balance_Load(object sender, EventArgs e)
        {
            loadcustomers();
        }

        private void dgvcustomerlist_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;

            indexRow = e.RowIndex;
            DataGridViewRow row = dgvcustomerlist.Rows[indexRow];

            txtshowtrans.Text = row.Cells[0].Value.ToString();
            txtshowcustname.Text = row.Cells[1].Value.ToString();
        }
        public void loadshowTrans()
        {
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT transid,totalamount,balance,date_order,bill_remark from tbldownpaymentorder where customerid = '" + txtshowtrans.Text + "' ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgvunpaidtrans.DataSource = bSource; 
        }
        private void txtshowtrans_TextChanged(object sender, EventArgs e)
        {
            loadshowTrans();
        }

        private void dgvunpaidtrans_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;

            indexRow = e.RowIndex;
            DataGridViewRow row = dgvunpaidtrans.Rows[indexRow];

            //txt_code.Text = row.Cells[0].Value.ToString();
            txttransid.Text = row.Cells[0].Value.ToString();
            txttotalamount.Text = row.Cells[1].Value.ToString();
            txtbalance.Text = row.Cells[2].Value.ToString();
            lbldateordered.Text = row.Cells[3].Value.ToString();
            lblremark.Text = row.Cells[4].Value.ToString();

            txtcustid.Text = txtshowtrans.Text;
            txtcustname.Text = txtshowcustname.Text;

            txtamntpayment.Text = "";
            txtexpbalance.Text = "0";
            txtexpremark.Text = "";
            

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
            string query = "SELECT sum(payment),payment_remark from tblpayments where transid = '" + txttransid.Text + "' "; // Select Statement with where clauses
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
            loadpayments();
        }

        private void txtamntpayment_TextChanged(object sender, EventArgs e)
        {
            if (txtamntpayment.Text == "")
            {
                
                txtexpbalance.Text = "0";
                txtexpremark.Text = "";
            }
            else if (txtamntpayment.Text == "0")
            {
                
                txtexpbalance.Text = "0";
                txtexpremark.Text = "";
            }
            else
            {
                try
                {
                    double calcchange = Convert.ToDouble(txtbalance.Text) - Convert.ToDouble(txtamntpayment.Text);
                    txtexpbalance.Text = calcchange.ToString();
                    if (Convert.ToDouble(txtamntpayment.Text) == Convert.ToDouble(txtbalance.Text))
                    {
                        txtexpremark.Text = "Paid";
                    }else if(Convert.ToDouble(txtamntpayment.Text) > Convert.ToDouble(txtbalance.Text))
                    {
                        txtexpremark.Text = "Paid";
                        txtamntpayment.Text = txtbalance.Text;
                    }
                    else if (Convert.ToDouble(txtamntpayment.Text) < Convert.ToDouble(txtbalance.Text))
                    {
                        txtexpremark.Text = "Unpaid";
                    }
                }
                catch (Exception ex)
                {
                    txtamntpayment.Text = "0";
                }
            }
        }

        public void savePayment()
        {
            con = new MySqlConnection(constr);
            con.Open();
            String query = " insert into tblpayments(or_no,transid,totalamount,payment,balance,date_payment,payment_remark)values('"+txtorno.Text+"','"+txttransid.Text+"','"+txttotalamount.Text+"','"+txtamntpayment.Text+"','"+txtexpbalance.Text+"',now(),'"+txtexpremark.Text+"') ";//Insert Query
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Payment Saved.");
        }
        public void updatedownpaymentorder()
        {
            con = new MySqlConnection(constr);
            con.Open();
            String query = "  update tbldownpaymentorder set balance = '"+txtexpbalance.Text+"', bill_remark = '"+txtexpremark.Text+"' where transid = '"+txttransid.Text+"'  ";//Insert Query
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Transaction Updated.");
        }

        public void loadbalance()
        {
            con = new MySqlConnection(constr);
                con.Open();
                string query = "select balance,bill_remark from tbldownpaymentorder where transid = '"+txttransid.Text+"' "; // Select Statement with where clauses
                cmd = new MySqlCommand(query);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read() == true)
                {
                    txtbalance.Text = rdr.GetString("balance");
                    lblremark.Text = rdr.GetString("bill_remark");
                }
                con.Close();
        }
        private void btnsavepayment_Click(object sender, EventArgs e)
        {
            if (txtamntpayment.Text == "" || txtamntpayment.Text == "0")
            {
                MessageBox.Show("You must provide a neccessary Payment.");
            }
            else if (lblremark.Text == "Paid")
            {
                MessageBox.Show("Transaction is Already Paid");
            }
            else if (lblremark.Text == ". . . .")
            {
                MessageBox.Show("Please Select a Transaction First.");
            }
            else
            {
                try
                {
                    savePayment();
                    updatedownpaymentorder();

                    loadshowTrans();
                    loadpayments();
                    loadbalance();

                    txtorno.Text = "";
                    txtamntpayment.Text = "0";
                    txtexpbalance.Text = "0";


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
        }

        private void txtexpbalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtexpremark_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbalance_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
