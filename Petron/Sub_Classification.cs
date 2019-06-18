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
    public partial class SubClassification : Form
    {
        MySqlConnection con = null;
        String constr = "data source=localhost;database=dbpetron2;user id=root;password=;";
        MySqlCommand cmd = null;
        MySqlDataAdapter da;
        MySqlDataReader rdr;
        string imgLocation = "";

        public SubClassification()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            try
            {
                con = new MySqlConnection(constr);
                con.Open();
                String query = "select * from tblSubclassification ";
                cmd = new MySqlCommand(query, con);
                rdr = cmd.ExecuteReader();
                DataSubclass.Rows.Clear();
                while (rdr.Read() == true)
                {
                    DataSubclass.Rows.Add(rdr[0], rdr[1]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (categoryid.Text == "")
            //{
            //    MessageBox.Show("Please complete all requirements");
            //}
            //else
            //{
            //    try
            //    {

            //        con = new MySqlConnection(constr);
            //        con.Open();
            //        String fields = "subclassificationID,subclassification_Name,";
            //        //String query = "insert into tblsubclassification(subclassificationID,subclassification_Name) values('" + categoryid.Text + "','" + comboBox2.Text + "')";
            //        //cmd = new MySqlCommand(query);
            //        cmd.Connection = con;
            //        cmd.ExecuteReader();

            //        //categoryid.Text = "";
            //        //comboBox2.Text = "";


            //        MessageBox.Show("Succesfully Registered.");

            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //    con.Close();
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con = new MySqlConnection(constr);
                con.Open();
                String query = "select * from tblSubclassification where subclassification_Name like '%" + Search1.Text + "%' ";
                cmd = new MySqlCommand(query, con);
                rdr = cmd.ExecuteReader();
                DataSubclass.Rows.Clear();
                while (rdr.Read() == true)
                {
                    DataSubclass.Rows.Add(rdr[0], rdr[1]);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //categoryid.Text = "";
            //comboBox2.Text = "";
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void DataSubclass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

