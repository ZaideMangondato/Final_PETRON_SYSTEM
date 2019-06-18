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
    public partial class Viscosity : Form
    {
        String constr = "data source=localhost;database=dbpetron2;user id=root; password=;";
        MySqlConnection con = null;
        MySqlDataAdapter da;
        MySqlDataReader rdr;
        MySqlCommand cmd;

        public Viscosity()
        {
            InitializeComponent();
        }
        public void loadtypeName()
        {
            con = new MySqlConnection(constr);
            con.Open();
            string query = "select type_name from tbltype"; // Select Query Statement with a specified field name
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            rdr = cmd.ExecuteReader();

            while (rdr.Read() == true)
            {
                string typename = rdr.GetString("type_name"); // Declaring field name values as String


                cbxtypename.Items.Add(typename); // Adds comboBox item from its field's Values

            }
            con.Close();
        }
        public void loadCatName()
        {
            con = new MySqlConnection(constr);
            con.Open();
            string query = "select category_name from tblcategory"; // Select Query Statement with a specified field name
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
        public void loadviscosity()
        {
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "SELECT * from tblviscosity";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dgvviscosity.DataSource = bSource;
        }
        private void Viscosity_Load(object sender, EventArgs e)
        {
            loadtypeName();
            loadCatName();
            loadviscosity();
        }

        private void cbxtypename_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(constr);
                con.Open();
                string query = "select * from tbltype where type_name = '"+cbxtypename.Text+"' "; // Select Statement with where clauses
                cmd = new MySqlCommand(query);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                while (rdr.Read() == true)
                {
                    txttypeid.Text = rdr.GetString("type_id");
                }
                con.Close();
        }

        private void cbxcatname_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(constr);
            con.Open();
            string query = "select * from tblcategory where category_name = '" + cbxcatname.Text + "' "; // Select Statement with where clauses
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            rdr = cmd.ExecuteReader();

            while (rdr.Read() == true)
            {
                txtcategid.Text = rdr.GetString("category_id");
            }
            con.Close();
        }

        private void New_Click(object sender, EventArgs e)
        {
            if (txtviscosityname.Text == "" || txtcategid.Text == "" || txttypeid.Text == "" ||
                cbxcatname.Text == "" || cbxtypename.Text == "")
            {
                MessageBox.Show("Please fill up all requirements");
            }
            else
            {
                try
                {
                    con = new MySqlConnection(constr);
                    con.Open();
                    String query = " insert into tblviscosity(type_id,category_id,viscosity_name)values('"+txttypeid.Text+"','"+txtcategid.Text+"','"+txtviscosityname.Text+"') ";//Insert Query
                    cmd = new MySqlCommand(query);
                    cmd.Connection = con;
                    cmd.ExecuteReader();
                    con.Close();
                    MessageBox.Show("Successfully Saved.");
                    txtviscosityname.Text = "";
                    txtcategid.Text = "";
                    txttypeid.Text = "";
                    cbxcatname.Text = "";
                    cbxtypename.Text = "";

                    loadviscosity();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
