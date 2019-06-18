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
    public partial class StockRegistration : Form
    {
        MySqlConnection con = null;
        String constr = "data source=localhost;database=dbpetron2;user id=root;password=;";
        MySqlCommand cmd = null;
        MySqlDataAdapter da;
        MySqlDataReader rdr;
        string imgLocation = "";

        public StockRegistration()
        {
            InitializeComponent();
        }
        public void loadCategory()
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


                cbxcategory.Items.Add(catname); // Adds comboBox item from its field's Values

            }
            con.Close();
        }
        public void loadtype()
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


                cbxtype.Items.Add(typename); // Adds comboBox item from its field's Values

            }
            con.Close();
        }
        public void loadViscosity()
        {
            con = new MySqlConnection(constr);
            con.Open();
            string query = "select viscosity_name from tblviscosity"; // Select Query Statement with a specified field name
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            rdr = cmd.ExecuteReader();

            while (rdr.Read() == true)
            {
                string catname = rdr.GetString("viscosity_name"); // Declaring field name values as String


                cbxviscosity.Items.Add(catname); // Adds comboBox item from its field's Values

            }
            con.Close();
        }
        public void loadProduct()
        {
            con = new MySqlConnection(constr);
            con.Open();
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            MySqlDataAdapter da = new MySqlDataAdapter();
            string sql = "select a.productid,a.product_name,a.description,b.category_name,c.type_name,d.viscosity_name,a.volume,a.unit_price from tblproduct a,tblcategory b,tbltype c,tblviscosity d where a.category_id = b.category_id and a.type_id = c.type_id and a.viscosity_id = d.viscosity_id;";                    // Select Query Statement
            da.SelectCommand = new MySqlCommand(sql, con);
            DataTable table = new DataTable();
            da.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            dataGridView1.DataSource = bSource;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            prodid.Text = "PR-" + generateID.generateNewID();
            loadCategory();
            loadtype();
            loadViscosity();

            loadProduct();
        }
        public void savedefaultzerostock()
        {
            con = new MySqlConnection(constr);
            con.Open();
            String query = " insert into tblproduct_inv(productid,no_of_stocks)values('"+prodid.Text+"','0') ";//Insert Query
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Zero Stock Product Saved.");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (prodid.Text == "" || prodname.Text == "" || description.Text == "" || cbxcategory.Text == "" || cbxtype.Text == "" || cbxviscosity.Text == "")
            {
                MessageBox.Show("Please Fill up all Requirements");
            }
            else
            {
                try
                {
                    con = new MySqlConnection(constr);
                    con.Open();
                    String query = " insert into tblproduct(productid,product_name,description,category_id,type_id,viscosity_id,volume,unit_price)values('" + prodid.Text + "','" + prodname.Text + "','" + description.Text + "','" + txtcategid.Text + "','" + txttypeid.Text + "','" + txtviscosid.Text + "','" + txtvolume.Text + "','" + txtunitprice.Text + "') ";//Insert Query
                    cmd = new MySqlCommand(query);
                    cmd.Connection = con;
                    cmd.ExecuteReader();
                    con.Close();
                    MessageBox.Show("Successfully Saved.");

                    savedefaultzerostock();

                    prodid.Text = "";
                    prodname.Text = "";
                    description.Text = "";
                    cbxcategory.Text = "";
                    cbxtype.Text = "";
                    cbxviscosity.Text = "";
                    txtcategid.Text = "";
                    txttypeid.Text = "";
                    txtunitprice.Text = "";
                    txtviscosid.Text = "";

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            prodid.Text = "PR-" + generateID.generateNewID();
            prodname.Text = "";
            description.Text = "";
            cbxcategory.Text = "";
            cbxtype.Text = "";
           
        }

        private void cbxcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(constr);
            con.Open();
            string query = "select * from tblcategory where category_name = '" + cbxcategory.Text +"' "; // Select Statement with where clauses
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            rdr = cmd.ExecuteReader();

            while (rdr.Read() == true)
            {
                txtcategid.Text = rdr.GetString("category_id");
            }
            
        }

        private void cbxtype_SelectedIndexChanged(object sender, EventArgs e)
        {
            con = new MySqlConnection(constr);
            con.Open();
            string query = "select * from tbltype where type_name = '" + cbxtype.Text + "' "; // Select Statement with where clauses
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            rdr = cmd.ExecuteReader();

            while (rdr.Read() == true)
            {
                txttypeid.Text = rdr.GetString("type_id");
            }
            con.Close();
        }

        private void cbxviscosity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxviscosity.Text == "none")
            {
                txtviscosid.Text = "0";
            }
            else
            {

            con = new MySqlConnection(constr);
            con.Open();
            string query = "select * from tblviscosity where viscosity_name = '" + cbxviscosity.Text + "' "; // Select Statement with where clauses
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            rdr = cmd.ExecuteReader();

            while (rdr.Read() == true)
            {
                txtviscosid.Text = rdr.GetString("viscosity_id");
            }
            con.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;

            indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];

            prodid.Text = row.Cells[0].Value.ToString();//convert current row values into string and pass it to the textbox
            prodname.Text = row.Cells[1].Value.ToString();
            description.Text = row.Cells[2].Value.ToString();
            cbxcategory.Text = row.Cells[3].Value.ToString();
            cbxtype.Text = row.Cells[4].Value.ToString();
            cbxviscosity.Text = row.Cells[5].Value.ToString();
            txtvolume.Text = row.Cells[6].Value.ToString();
            txtunitprice.Text = row.Cells[7].Value.ToString();
        }

        private void txtcategid_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txttypeid_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txtviscosid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con = new MySqlConnection(constr);
            con.Open();
            String query = " update tblproduct set product_name = '" + prodname.Text + "',description = '"+description.Text+"',category_id = '"+txtcategid.Text+"',type_id = '"+txttypeid.Text+"',viscosity_id = '"+txtviscosid.Text+"',volume = '"+txtvolume.Text+"',unit_price = '"+txtunitprice.Text+"' where productid = '"+prodid.Text+"'"; // Update Query Statement
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
            MessageBox.Show("Successfully Updated.");
            

            loadProduct();
            prodid.Text = "PR-" + generateID.generateNewID();
            

            prodname.Text = "";
            description.Text = "";
            cbxcategory.Text = "";
            cbxtype.Text = "";
            cbxviscosity.Text = "";
            //txtcategid.Text = "";
            //txttypeid.Text = "";
            //txtviscosid.Text = "";
            //txtvolume.Text = "";
            txtunitprice.Text = "";

        }

    }
}
