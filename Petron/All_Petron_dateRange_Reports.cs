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
    public partial class All_Petron_dateRange_Reports : Form
    {
        MySqlConnection con = null;
        String constr = "data source=localhost;database=dbpetron2;user id=root;password=;";
        MySqlCommand cmd = null;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        public All_Petron_dateRange_Reports()
        {
            InitializeComponent();
        }
        public void createViewCollectionsDateRange()
        {
            con = new MySqlConnection(constr);
            con.Open();
            String query = "   create or replace view view_Collections_daterange as select customer_name,totalamount,totalamountpaid,balance,date_order,bill_remark from view_collections where date_order between '" + collections_from.Text + "' and '" + collections_to.Text + "' order by date_order desc  ";//Insert Query
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
            //MessageBox.Show("Successfully Saved.");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            createViewCollectionsDateRange();

            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = " select customer_name,totalamount,totalamountpaid,balance,date_order,bill_remark from view_collections where date_order between '"+collections_from.Text+"' and '"+collections_to.Text+"'    ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dataGridView1.DataSource = bSource;

            btnprintCollections.Enabled = true;
        }

        private void btnprintCollections_Click(object sender, EventArgs e)
        {
            Print_Collections pc = new Print_Collections();
            pc.Show();
            pc.pc_from.Text = collections_from.Text;
            pc.pc_to.Text = collections_to.Text;
        }
        public void createViewCollectiblesDateRange()
        {
            con = new MySqlConnection(constr);
            con.Open();
            String query = "  create or replace view view_Collectibles_daterange as select or_no,customer_name,totalamount,payment,balance,date_payment from view_collectibles where date_payment between '" + collectibles_from.Text + "' and '" + collectibles_to.Text + "' order by date_payment desc  ";//Insert Query
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
        }
        private void btncollectiblesgo_Click(object sender, EventArgs e)
        {
            createViewCollectiblesDateRange();

            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "  select or_no,customer_name,totalamount,payment,balance,date_payment from view_collectibles where date_payment between '" + collectibles_from.Text + "' and '" + collectibles_to.Text + "' order by date_payment desc    ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dataGridView2.DataSource = bSource;
            
            btnprintCollectibles.Enabled = true;


        }

        private void btnprintCollectibles_Click(object sender, EventArgs e)
        {
            Print_Collectibles pc = new Print_Collectibles();
            pc.Show();
            pc.pc_from.Text = collectibles_from.Text;
            pc.pc_to.Text = collectibles_to.Text;

        }

        private void All_Petron_dateRange_Reports_Load(object sender, EventArgs e)
        {

        }
    }
}
