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
    public partial class Form1 : Form
    {
        MySqlConnection con = null;
        String constr = "data source=localhost;database=dbpetron2;user id=root;password=;";
        MySqlCommand cmd = null;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Form er = new StockRegistration();
            er.ShowDialog();  
        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
          
        }

        private void classificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form er = new Classification();
            er.ShowDialog();

        }

        private void subClassificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form er = new SubClassification();
            er.ShowDialog();
        }

        private void stockEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form er = new Stock_Entry_Inventory();
            er.ShowDialog();
        }

        private void pOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form er = new POS();
            er.ShowDialog();
        }

        private void maintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void queryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void queryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form er = new Supplier();
            er.ShowDialog();
        }

        private void salesAndExpenseSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form er = new Sales_and_Expenses_Summary();
            er.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form er = new Customer();
            er.ShowDialog();

        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form er = new Category();
            er.ShowDialog();
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form er = new Type();
            er.ShowDialog();
        }

        private void viscosityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form er = new Viscosity();
            er.ShowDialog();
        }

        private void stockEntryToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form er = new Stock_Entry_Inventory();
            er.ShowDialog();
        }

        private void cashieringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void stockMonitoringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_Monitoring sm = new Stock_Monitoring();
            sm.ShowDialog();
        }

        private void orderEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form er = new Order_Entry();
            er.ShowDialog();
        }

        private void billinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Billing bill = new Billing();
            bill.ShowDialog();
        }

        private void payBillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Pay_Balance pb = new Pay_Balance();
            pb.ShowDialog();
        }

        private void collectiblesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void collectionsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }
        public void createViewCollections()
        {
            con = new MySqlConnection(constr);
            con.Open();
            String query = "  create or replace view view_collections as select b.transid, a.customer_name, b.totalamount,b.totalamount - b.balance 'totalamountpaid', b.balance, b.date_order, b.bill_remark from tblcustomer a, tbldownpaymentorder b where b.customerid = a.customerid and b.bill_remark = 'Unpaid' order by b.date_order desc  ";//Insert Query
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
            //MessageBox.Show("Successfully Saved.");
        }
        public void createViewCollectibles()
        {
            //
            con = new MySqlConnection(constr);
            con.Open();
            String query = " create or replace view view_collectibles as select a.or_no, a.transid, c.customer_name, a.totalamount, a.payment, a.balance, a.date_payment from tblpayments a, view_collections c where a.transid = c.transid order by a.date_payment desc  ";//Insert Query
            cmd = new MySqlCommand(query);
            cmd.Connection = con;
            cmd.ExecuteReader();
            con.Close();
        }
        private void openReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            createViewCollections();
            createViewCollectibles();


            All_Reports ar = new All_Reports();
            ar.Show();
        }

        private void dateRangingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            All_Petron_dateRange_Reports apdr = new All_Petron_dateRange_Reports();
            apdr.Show();
        }
    }
}
