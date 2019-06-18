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
    public partial class Order_Entry : Form
    {
        String constr = "data source=localhost;database=dbpetron2;user id=root; password=;";
        MySqlConnection con = null;
        MySqlDataAdapter da;
        MySqlDataReader rdr;
        MySqlCommand cmd;
        public Order_Entry()
        {
            InitializeComponent();
        }
        public void loadselectcust()
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
            dgvselectcust.DataSource = bSource;
        }
        public void loadselectproduct()
        {
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT a.productid,a.product_name,a.unit_price,b.no_of_stocks from tblproduct a,tblproduct_inv b where a.productid = b.productid";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgvselectproduct.DataSource = bSource;
        }
        public void loadcurrentorder()
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
            dgvorderscart.DataSource = bSource;
            loadOrderLogs();
        }
        public void loadnumberofitems()
        {
            con = new MySqlConnection(constr);
                con.Open();
                string query = "select count(*) from tblorderlogs where transid = '" + txttransid.Text + "' "; // Select Statement with where clauses
                cmd = new MySqlCommand(query);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read() == true)
                {
                    txtnoofitems.Text = rdr.GetString("count(*)");
                }
                con.Close();

                loadtotalamount();
        }
        public void loadtotalamount()
        {
            con = new MySqlConnection(constr);
            con.Open();
            string query = "select sum(total_price) from tblorderlogs where transid = '" + txttransid.Text + "' "; // Select Statement with where clauses
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            rdr = cmd.ExecuteReader();

            while (rdr.Read() == true)
            {
                try
                {
                    txttotalamount.Text = rdr.GetString("sum(total_price)");
                }
                catch (Exception ex)
                {
                    txttotalamount.Text = "0";
                }
                
            }
            con.Close();
        }

        public void loadOrderLogs()
        {
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from tblorderlogs";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgvorderlogs.DataSource = bSource;
        }

        public void loadFullPayments()
        {
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "select a.transid,a.customerid,b.customer_name,a.totalamount,a.amt_rcvd,a.amt_change,a.date_order from tblfullpaymentorder a,tblcustomer b where a.customerid = b.customerid order by date_order desc";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgvfullpayments.DataSource = bSource;
        }
        public void loadDownPayments()
        {
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "select a.transid,a.customerid,b.customer_name,a.totalamount,a.balance,a.date_order,a.bill_remark from tbldownpaymentorder a,tblcustomer b where a.customerid = b.customerid order by date_order desc";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgvdownpayments.DataSource = bSource;
        }
        private void Cashiering_Load(object sender, EventArgs e)
        {
            //------------ORDERING SECTION--------
            loadcurrentorder();
            loadselectcust();
            loadselectproduct();
            loadnumberofitems();
            //------------END------------
            loadFullPayments();
            loadDownPayments();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtchange.Text) < 0)
                {
                    txtchange.Text = "0";
                }
            }
            catch (Exception ex)
            {
                txtchange.Text = "0";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            customerpanel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            customerpanel.Visible = true;

        }

        private void txtsearchcust_TextChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from tblcustomer where customerid like '%" + txtsearchcust.Text + "%' or customer_name like '%" + txtsearchcust.Text + "%' ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgvselectcust.DataSource = bSource;
        }

        private void dgvselectcust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;

            indexRow = e.RowIndex;
            DataGridViewRow row = dgvselectcust.Rows[indexRow];

            txtcustid.Text = row.Cells[0].Value.ToString();
            txtcustname.Text = row.Cells[1].Value.ToString();
            txtcustaddr.Text = row.Cells[2].Value.ToString();
            txtcustnum.Text = row.Cells[3].Value.ToString();
            txtcustcompaff.Text = row.Cells[4].Value.ToString();
            txtcustcomppos.Text = row.Cells[5].Value.ToString();
            customerpanel.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            productpanel.Visible = true;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            productpanel.Visible = false;

        }

        private void txtsearchproduct_TextChanged(object sender, EventArgs e)
        {
            //SELECT a.productid,a.product_name,a.unit_price,b.no_of_stocks from tblproduct a,tblproduct_inv b where a.productid = b.productid
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT a.productid,a.product_name,a.unit_price,b.no_of_stocks from tblproduct a,tblproduct_inv b where a.productid = b.productid and (a.productid like '%" + txtsearchproduct.Text + "%' or a.product_name like '%" + txtsearchproduct.Text + "%' )";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgvselectproduct.DataSource = bSource;
        }

        private void dgvselectproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;

            indexRow = e.RowIndex;
            DataGridViewRow row = dgvselectproduct.Rows[indexRow];

            txtprodid.Text = row.Cells[0].Value.ToString();
            txtprodname.Text = row.Cells[1].Value.ToString();
            txtunitprice.Text = row.Cells[2].Value.ToString();
            txtcurrentstock.Text = row.Cells[3].Value.ToString();

            productpanel.Visible = false;

            txtstockorder.Text = "0";
            txttotalprice.Text = "0";
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            //if (txtcurrentstock.Text == "0")
            //{
            //    MessageBox.Show("Sorry, the product's Current stock is 0 (zero).");
            //}
            //else if (txtprodid.Text == "")
            //{
            //    MessageBox.Show("You must Select a Product first before calculating. ");
            //}
            //else if (txtstockorder.Text == "0")
            //{
            //    MessageBox.Show("Please Specify the quantity of stocks you want to order. ");
            //}
            //else if (Convert.ToInt32(txtcurrentstock.Text) < Convert.ToInt32(txtstockorder.Text))
            //{
            //    MessageBox.Show("Cannot Calculate. The Stocks you ordered is greater than the current Stock");
            //}
            //else
            //{
            //    double dunitprice = Convert.ToDouble(txtunitprice.Text);
            //    int istockorder = Convert.ToInt32(txtstockorder.Text);
            //    txttotalprice.Text = (dunitprice * istockorder).ToString();

            //}

        
        }
        public void ADDTOCART_updateProductInv()
        {
            con = new MySqlConnection(constr);
            con.Open();
            String query = " update tblproduct_inv set no_of_stocks = '"+((Convert.ToInt32(txtcurrentstock.Text)) - (Convert.ToInt32(txtstockorder.Text)))+"' where productid = '"+txtprodid.Text+"'  ";//Insert Query
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show(" inventory Updated.");
        }
        public void ADDTOCART_insertToCartLogs()
        {
            con = new MySqlConnection(constr);
            con.Open();
            String query = " insert into tblorderlogs(transid,customerid,productid,quantity,unit_price,total_price,date_order,tracecode)values('"+txttransid.Text+"','"+txtcustid.Text+"','"+txtprodid.Text+"','"+txtstockorder.Text+"','"+txtunitprice.Text+"','"+txttotalprice.Text+"',curdate(),'"+txttracecode.Text+"') ";//Insert Query
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Successfully added to Cart.");
        }
        

        private void btnaddtocart_Click(object sender, EventArgs e)
        {
            customerpanel.Visible = false;
            productpanel.Visible = false;
            try
            {
                double calctrap = Convert.ToDouble(txtunitprice.Text) * Convert.ToInt32(txtstockorder.Text);


                if (txttotalprice.Text == "0")
                {
                    MessageBox.Show("Please Initiate Calculation of order");
                }
                else if (txtstockorder.Text == "" || txtstockorder.Text == "0")
                {
                    MessageBox.Show("Please Provide a Quantity of your Order");
                }
                else if (txtcustid.Text == "")
                {
                    MessageBox.Show("Please Select a Customer");
                }
                else if (calctrap != Convert.ToDouble(txttotalprice.Text))
                {
                    MessageBox.Show("Please recalculate.\n\nPhp." + txtunitprice.Text + " X " + txtstockorder.Text + "pcs is " + calctrap + "\n\nNot " + txttotalprice.Text);
                    txttotalprice.Text = "0";
                }
                else
                {
                    MessageBox.Show("Ready to add to card");
                    try
                    {
                        ADDTOCART_updateProductInv();
                        ADDTOCART_insertToCartLogs();

                        loadcurrentorder();
                        loadselectproduct();
                        loadnumberofitems();

                        txttracecode.Text = "";

                        txtprodid.Text = "";
                        txtprodname.Text = "";
                        txtcurrentstock.Text = "";
                        txtstockorder.Text = "0";
                        txttotalprice.Text = "0";
                        txtunitprice.Text = "";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtnoofitems.Text == "0")
            {
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Please Remove all the items in the Cart before Closing.");
            }
        }

        private void txtstockorder_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvorderscart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;

            indexRow = e.RowIndex;
            DataGridViewRow row = dgvorderscart.Rows[indexRow];

            //txt_code.Text = row.Cells[0].Value.ToString();
            rmvprodid.Text = row.Cells[0].Value.ToString();
            rmvqty.Text = row.Cells[2].Value.ToString();

            rmvtracecode.Text = row.Cells[5].Value.ToString();

            removePanel.Visible = true;
        }

        private void rmvprodid_TextChanged(object sender, EventArgs e)
        {
            
            con = new MySqlConnection(constr);
                con.Open();
                string query = "select no_of_stocks from tblproduct_inv where productid = '"+rmvprodid.Text+"' "; // Select Statement with where clauses
                cmd = new MySqlCommand(query);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read() == true)
                {
                    //string car_id = rdr.GetString("car_id");
                    rmvcurrqty.Text = rdr.GetString("no_of_stocks");
                } 
            con.Close();
        }

        public void REMOVETOCART_updateProductInv()
        {
            con = new MySqlConnection(constr);
            con.Open();
            String query = " update tblproduct_inv set no_of_stocks = '" + ((Convert.ToInt32(rmvqty.Text)) + (Convert.ToInt32(rmvcurrqty.Text))) + "' where productid = '" + rmvprodid.Text + "'  ";//Insert Query
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Product inventory went back to current state.");
        }
        public void REMOVETOCART_removeToCartLogs()
        {
            con = new MySqlConnection(constr);
            con.Open();
            String query = " delete from tblorderlogs where tracecode = '"+rmvtracecode.Text+"' ";//Insert Query
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Successfully Removed to Cart.");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                REMOVETOCART_removeToCartLogs();
                REMOVETOCART_updateProductInv();
                loadcurrentorder();
                loadselectproduct();
                loadnumberofitems();
                removePanel.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            removePanel.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            rmvcurrqty.Text = "";
            rmvprodid.Text = "";
            rmvqty.Text = "";
            rmvtracecode.Text = "";
            removePanel.Visible = false;

        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtprodid.Text = "";
            txtprodname.Text = "";
            txtcurrentstock.Text = "";
            txtstockorder.Text = "0";
            txttotalprice.Text = "0";
            txtunitprice.Text = "";
        }

        private void removePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtamountreceived_TextChanged(object sender, EventArgs e)
        {
            if (txtamountreceived.Text == "")
            {
                txtamountreceived.Text = "";
                txtchange.Text = "";
                txtbalance.Text = "";
            }
            else if (txttotalamount.Text == "0")
            {
                txtamountreceived.Text = "";
                txtchange.Text = "";
                txtbalance.Text = "";
            }
            else
            {
                try
                {
                   
                    double calcchange = Convert.ToDouble(txtamountreceived.Text) - Convert.ToDouble(txttotalamount.Text);
                    txtchange.Text = calcchange.ToString();

                    //-------calc balance-------
                    double dbalance = Convert.ToDouble(txttotalamount.Text) - Convert.ToDouble(txtamountreceived.Text);
                    txtbalance.Text = dbalance.ToString();
                }
                catch (Exception ex)
                {
                    txtamountreceived.Text = "";

                }
            }
        }

        private void txttotalamount_TextChanged(object sender, EventArgs e)
        {
            txtamountreceived.Text = "";
            txtchange.Text = "";
            txtbalance.Text = "";
        }

        private void txtbalance_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDouble(txtbalance.Text) < 0)
                {
                    txtbalance.Text = "0";
                }
            }
            catch (Exception ex)
            {
                txtbalance.Text = "0";
            }
        }

        private void rbfullpayment_CheckedChanged(object sender, EventArgs e)
        {
            txtpaymentmode.Text = "full_payment";
        }

        private void rbdownpayment_CheckedChanged(object sender, EventArgs e)
        {
            txtpaymentmode.Text = "down_payment";
        }

        private void btnsaveproceed_Click(object sender, EventArgs e)
        {
            if (txtnoofitems.Text == "0")
            {
                MessageBox.Show("Please add atleast 1 order");
            }
            else if (txtpaymentmode.Text == "full_payment") // SAVE TO FULL PAYMENT
            {
                //MessageBox.Show("saving for full payment");
                if (txttotalamount.Text == "" ||
                    txttotalamount.Text == "0" ||
                    txtamountreceived.Text == "" ||
                    txtamountreceived.Text == "0"

                    )
                {
                    MessageBox.Show("please provide payment");
                    
                }
                else
                {
                    //MessageBox.Show("READY...");
                    customerpanel.Visible = false;
                    productpanel.Visible = false;
                    if (Convert.ToDouble(txttotalamount.Text) > Convert.ToDouble(txtamountreceived.Text))
                    {
                        MessageBox.Show("Full Payment should not have Balance. Please Enter an Exact amount or higher.");
                    }
                    else
                    {
                        try
                        {
                            con = new MySqlConnection(constr);
                            con.Open();
                            String query = " insert into tblfullpaymentorder(transid,customerid,totalamount,amt_rcvd,amt_change,date_order)values('" + txttransid.Text + "','" + txtcustid.Text + "','" + txttotalamount.Text + "','" + txtamountreceived.Text + "','" + txtchange.Text + "',curdate()) ";//Insert Query
                            cmd = new MySqlCommand(query);
                            cmd.Connection = con;
                            cmd.ExecuteReader();
                            con.Close();
                            MessageBox.Show("Order has been Successfully Saved as Full Payment");

                            txttransid.Text = "";
                            txttracecode.Text = "";

                            txtamountreceived.Text = "";
                            txtchange.Text = "";
                            txtbalance.Text = "";

                            txtprodid.Text = "";
                            txtprodname.Text = "";
                            txtcurrentstock.Text = "";
                            txtstockorder.Text = "0";
                            txttotalprice.Text = "0";
                            txtunitprice.Text = "";

                            txtcustid.Text = "";
                            txtcustname.Text = "";
                            txtcustaddr.Text = "";
                            txtcustnum.Text = "";
                            txtcustcompaff.Text = "";
                            txtcustcomppos.Text = "";

                            loadcurrentorder();
                            loadselectcust();
                            loadselectproduct();
                            loadnumberofitems();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                
            }
            else if (txtpaymentmode.Text == "down_payment") // SAVE TO DOWN PAYMENT
            {
                //MessageBox.Show("saving for down payment");
                if (txttotalamount.Text == "" ||
                    txttotalamount.Text == "0" ||
                    txtamountreceived.Text == "" ||
                    txtamountreceived.Text == "0"


                    )
                {
                    MessageBox.Show("please provide payment");
                }
                else
                {
                    customerpanel.Visible = false;
                    productpanel.Visible = false;
                    if (Convert.ToDouble(txttotalamount.Text) < Convert.ToDouble(txtamountreceived.Text))
                    {
                        MessageBox.Show("Down Payment should not have Change. Please enter a correct Downpayment.");
                    }
                    else
                    {
                        try
                        {
                            insertToDownpaymentOrder();
                            insertToPayments();

                            txttransid.Text = "";
                            txttracecode.Text = "";

                            txtamountreceived.Text = "";
                            txtchange.Text = "";
                            txtbalance.Text = "";

                            txtprodid.Text = "";
                            txtprodname.Text = "";
                            txtcurrentstock.Text = "";
                            txtstockorder.Text = "0";
                            txttotalprice.Text = "0";
                            txtunitprice.Text = "";

                            txtcustid.Text = "";
                            txtcustname.Text = "";
                            txtcustaddr.Text = "";
                            txtcustnum.Text = "";
                            txtcustcompaff.Text = "";
                            txtcustcomppos.Text = "";

                            loadcurrentorder();
                            loadselectcust();
                            loadselectproduct();
                            loadnumberofitems();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else if(txtpaymentmode.Text == "")
            {
                MessageBox.Show("Please Select Payment Method");
            }

            loadFullPayments();
            loadDownPayments();
        }

        public void insertToDownpaymentOrder()
        {
            con = new MySqlConnection(constr);
            con.Open();
            String query = "   insert into tbldownpaymentorder(transid,customerid,totalamount,balance,date_order,bill_remark)values('"+txttransid.Text+"','"+txtcustid.Text+"','"+txttotalamount.Text+"','"+txtbalance.Text+"',curdate(),'Unpaid')   ";//Insert Query
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Successfully Saved to Downpayment Orders.");
        }
        public void insertToPayments()
        {
            con = new MySqlConnection(constr);
            con.Open();
            String query = "  insert into tblpayments(or_no,transid,totalamount,payment,balance,date_payment,payment_remark)values('"+txtoriddownpayment.Text+"','"+txttransid.Text+"','"+txttotalamount.Text+"','"+txtamountreceived.Text+"','"+txtbalance.Text+"',now(),'Unpaid') ";//Insert Query
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Downpayment Saved to Payment Records.");
            txtoriddownpayment.Text = "";

        }
        private void txtpaymentmode_TextChanged(object sender, EventArgs e)
        {
            customerpanel.Visible = false;
            productpanel.Visible = false;
        }

        
        public void searchFullPayments()
        {
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "select a.transid,a.customerid,b.customer_name,a.totalamount,a.amt_rcvd,a.amt_change,a.date_order from tblfullpaymentorder a,tblcustomer b where a.customerid = b.customerid and (a.customerid like '%" + txtsearchsavedorders.Text + "%' or b.customer_name  like '%" + txtsearchsavedorders.Text + "%') order by date_order desc";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgvfullpayments.DataSource = bSource;
        }
        public void searchDownPayments()
        {
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "select a.transid,a.customerid,b.customer_name,a.totalamount,a.balance,a.date_order,a.bill_remark from tbldownpaymentorder a,tblcustomer b where a.customerid = b.customerid and (a.customerid like '%" + txtsearchsavedorders.Text + "%' or b.customer_name  like '%" + txtsearchsavedorders.Text + "%') order by date_order desc";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgvdownpayments.DataSource = bSource;
        }

        private void txtsearchsavedorders_TextChanged(object sender, EventArgs e)
        {
            searchDownPayments();
            searchFullPayments();
        }

        private void txtstockorder_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtstockorder.Text == "")
                {
                    double dunitprice = Convert.ToDouble(txtunitprice.Text);
                    int istockorder = 0;
                    txttotalprice.Text = (dunitprice * istockorder).ToString();
                }
                else if (Convert.ToInt32(txtcurrentstock.Text) < Convert.ToInt32(txtstockorder.Text))
                {
                    MessageBox.Show("Cannot Calculate. The Stocks you ordered is greater than the current Stock");
                    txtstockorder.Text = "";
                }
                else
                {
                    double dunitprice = Convert.ToDouble(txtunitprice.Text);
                    int istockorder = Convert.ToInt32(txtstockorder.Text);
                    txttotalprice.Text = (dunitprice * istockorder).ToString();
                }
                
            }
            catch (Exception ex)
            {
                
                txtstockorder.Text = "";
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
       

        
        
        
    }
}
