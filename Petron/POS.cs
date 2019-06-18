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
    public partial class POS : Form
    {
        MySqlConnection con = null;
        String constr = "data source=localhost;database=dbpetron2;user id=root;password=;";
        MySqlCommand cmd = null;
        MySqlDataAdapter da;
        MySqlDataReader rdr;
        string imgLocation = "";
        public POS()
        {
            InitializeComponent();
        }

        private void POS_Load(object sender, EventArgs e)
        {
            recno.Text = "RC-" + generateID.generateNewID();
        }

        private void Data1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void recno_TextChanged(object sender, EventArgs e)
        {

        }

        private void newtrans_Click(object sender, EventArgs e)
        {
            recno.Text = "RC-" + generateID.generateNewID();
        }
    }
}    

