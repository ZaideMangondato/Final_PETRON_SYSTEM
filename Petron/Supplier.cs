using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace Petron
{
    
    public partial class Supplier : Form
    {
        String constr = "data source=localhost;database=dbpetron2;user id=root; password=;";
        MySqlConnection con = null;
        MySqlDataAdapter da;
        MySqlDataReader rdr;
        MySqlCommand cmd;
        public Supplier()
        {
            InitializeComponent();
        }
        public void loadsupplier()
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
        private void Supplier_Load(object sender, EventArgs e)
        {
            loadsupplier();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtsupname.Text == "")
            {
                MessageBox.Show("Please Enter a Supplier name");
            }
            else
            {
                try
                {
                    con = new MySqlConnection(constr);
                    con.Open();
                    String query = "insert into tblsupplier(supplierid,supplier_name)values('"+txtsupid.Text+"','"+txtsupname.Text+"')";
                    cmd = new MySqlCommand(query, con);
                    cmd.ExecuteReader();
                    txtsupid.Text = "";
                    txtsupname.Text = "";
                    MessageBox.Show("Successfully Saved.");

                    loadsupplier();
                }catch(Exception ex){
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from tblsupplier where supplier_name like '%"+Search.Text+"%' ";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgvsupplier.DataSource = bSource;
        }
    }
}
