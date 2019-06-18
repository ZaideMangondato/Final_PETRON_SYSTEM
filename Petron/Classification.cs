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
    public partial class Classification : Form
    {
        MySqlConnection con = null;
        String constr = "data source=localhost;database=dbpetron2;user id=root;password=;";
        MySqlCommand cmd = null;
        MySqlDataAdapter da;
        MySqlDataReader rdr;
        string imgLocation = "";

        public Classification()
        {
            InitializeComponent();
        }

        private void Classification_Load(object sender, EventArgs e)
        {
            try
            {
                con = new MySqlConnection(constr);
                con.Open();
                String query = "select * from tblclassification";
                cmd = new MySqlCommand(query, con);
                rdr = cmd.ExecuteReader();
                DataClass.Rows.Clear();
                while (rdr.Read() == true)
                {
                    DataClass.Rows.Add(rdr[0], rdr[1]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            con.Close();
            //ClassiID.Text = "CID-" + generateID.generateNewID();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // if (ClassiID.Text == "")
            //{
            //    MessageBox.Show("Please complete all requirements");
            //}
            //else
            //{
            //    try
            //    {

            //        con = new MySqlConnection(constr);
            //        con.Open();
            //        String fields = "classificationID,classification_Name,";
            //        String query = "insert into tblclassification(classificationID,classification_Name) values('" + ClassiID.Text + "','" + classiname.Text + "')";
            //        cmd = new MySqlCommand(query);
            //        cmd.Connection = con;
            //        cmd.ExecuteReader();

            //        ClassiID.Text = "";
            //        classiname.Text = "";


            //        MessageBox.Show("Succesfully Registered.");

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //    con.Close();
            //}
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

       
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = new MySqlConnection(constr);
                con.Open();
                String query = "select * from tblclassification where classification_Name like '%" + Search.Text + "%' ";
                cmd = new MySqlCommand(query, con);
                rdr = cmd.ExecuteReader();
                DataClass.Rows.Clear();
                while (rdr.Read() == true)
                {
                    DataClass.Rows.Add(rdr[0], rdr[1]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void DataClass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow;

            indexRow = e.RowIndex;
            DataGridViewRow row = DataClass.Rows[indexRow];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ClassiID.Text = "";
            //classiname.Text = "";
        }

        private void ClassiID_TextChanged(object sender, EventArgs e)
        {
            //ClassiID.Text = "CID-" + generateID.generateNewID();
        }
    }
}
      