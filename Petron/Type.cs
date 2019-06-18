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
    public partial class Type : Form
    {
        String constr = "data source=localhost;database=dbpetron2;user id=root; password=;";
        MySqlConnection con = null;
        MySqlDataAdapter da;
        MySqlDataReader rdr;
        MySqlCommand cmd;
        public Type()
        {
            InitializeComponent();
        }

        public void loadcatname()
        {
            con = new MySqlConnection(constr);
            con.Open();
            string query = "select * from tblcategory"; // Select Query Statement with a specified field name
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            rdr = cmd.ExecuteReader();

            while (rdr.Read() == true)
            {
                string catname = rdr.GetString("category_name"); // Declaring field name values as String


                cbxcatname.Items.Add(catname); // Adds comboBox item from its field's Values

            }
            con.Close();
        }

        public void loadType()
        {
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT tbltype.type_id,tbltype.category_id,tblcategory.category_name,tbltype.type_name from tbltype,tblcategory where tbltype.category_id = tblcategory.category_id";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgvtype.DataSource = bSource;
        }

        private void Type_Load(object sender, EventArgs e)
        {
            loadType();
            loadcatname();
        }

        private void cbxcatname_SelectedIndexChanged(object sender, EventArgs e)
        {
                con = new MySqlConnection(constr);
                con.Open();
                string query = "select * from tblcategory where category_name = '"+cbxcatname.Text+"' "; // Select Statement with where clauses
                cmd = new MySqlCommand(query);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read() == true)
                {
                    txtcatid.Text = rdr.GetString("category_id");

                }
                con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtcatid.Text == "" || txttypename.Text == "")
            {
                MessageBox.Show("Please Fill Up all Requirements");
            }
            else
            {
                try
                {
                    con = new MySqlConnection(constr);
                    con.Open();
                    String query = "insert into tbltype(category_id,type_name)values('"+txtcatid.Text+"','"+txttypename.Text+"')";//Insert Query
                    cmd = new MySqlCommand(query);
                    cmd.Connection = con;
                    cmd.ExecuteReader();
                    con.Close();
                    MessageBox.Show("Successfully Saved.");

                    cbxcatname.Text = "";
                    txtcatid.Text = "";
                    txttypename.Text = "";

                    loadType();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT tbltype.type_id,tbltype.category_id,tblcategory.category_name,tbltype.type_name from tbltype,tblcategory where (tbltype.category_id = tblcategory.category_id) and tbltype.type_name like '%"+textBox1.Text+"%' ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgvtype.DataSource = bSource;
        }
    }
}
