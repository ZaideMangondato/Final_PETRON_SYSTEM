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

    public partial class Customer : Form
    {
        String constr = "data source=localhost;database=dbpetron2;user id=root; password=;";
        MySqlConnection con = null;
        MySqlDataAdapter da;
        MySqlDataReader rdr;
        MySqlCommand cmd;
        public Customer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void loadcustomer()
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
            dataGridView1.DataSource = bSource;
        }
        private void Customer_Load(object sender, EventArgs e)
        {
            loadcustomer();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcustid.Text == "" || txtcustname.Text == "" || txtaddress.Text == "" || txtnumber.Text == "" ||
                txtcompaff.Text == "" || txtcomppos.Text == "")
            {
                MessageBox.Show("Please Enter a Supplier name");
            }
            else
            {
                try
                {
                    con = new MySqlConnection(constr);
                    con.Open();
                    String query = "insert into tblcustomer values('" + txtcustid.Text + "','" + txtcustname.Text + "','" + txtaddress.Text + "','" + txtnumber.Text + "','" + txtcompaff.Text + "','" + txtcomppos.Text + "')";//Insert Query
                    cmd = new MySqlCommand(query);
                    cmd.Connection = con;
                    cmd.ExecuteReader();
                    con.Close();
                    MessageBox.Show("Successfully Saved.");

                    txtcustid.Text = "";
                    txtcustname.Text = "";
                    txtaddress.Text = "";
                    txtnumber.Text = "";
                    txtcompaff.Text = "";
                    txtcomppos.Text = "";

                    loadcustomer();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;

            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];
           
            upcustid.Text = row.Cells[0].Value.ToString();//convert current row values into string and pass it to the textbox
            upcustname.Text = row.Cells[1].Value.ToString();
            upaddress.Text = row.Cells[2].Value.ToString();
            upnumber.Text = row.Cells[3].Value.ToString();
            upcompaff.Text = row.Cells[4].Value.ToString();
            upcomppos.Text = row.Cells[5].Value.ToString();
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            con = new MySqlConnection(constr);
            con.Open();
            String query = "update tblcustomer set customer_name = '" + upcustname.Text + "', address = '" + upaddress.Text + "', contact_number = '" + upnumber.Text + "', company_affiliation = '" + upcompaff.Text + "', company_position = '" + upcomppos.Text + "' where customerid = '" + upcustid.Text + "'"; 
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Successfully Updated.");
            loadcustomer();

            upcustid.Text = "";
            upcustname.Text = "";
            upaddress.Text = "";
            upnumber.Text = "";
            upcompaff.Text = "";
            upcomppos.Text = "";
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from tblcustomer where customer_name like '%"+textBox6.Text+"%' ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dataGridView1.DataSource = bSource;
        }
    }
}
