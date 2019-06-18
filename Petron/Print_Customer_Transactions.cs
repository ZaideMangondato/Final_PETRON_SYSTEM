using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace Petron
{
    public partial class Print_Customer_Transactions : Form
    {
        public Print_Customer_Transactions()
        {
            InitializeComponent();
        }

        private void Print_Customer_Transactions_Load(object sender, EventArgs e)
        {
            

            
            
            // TODO: This line of code loads data into the 'dbpetron2CustomerTransactionsDataSet.view_selectedcustomertransactions' table. You can move, or remove it, as needed.
            this.view_selectedcustomertransactionsTableAdapter.Fill(this.dbpetron2CustomerTransactionsDataSet.view_selectedcustomertransactions);

            this.reportViewer1.RefreshReport();
        }

        private void pct_custid_TextChanged(object sender, EventArgs e)
        {
            ReportParameter custidParam = new ReportParameter("custidParam", this.pct_custid.Text);
            reportViewer1.LocalReport.SetParameters(custidParam);
            this.reportViewer1.RefreshReport();
        }

        private void pct_custname_TextChanged(object sender, EventArgs e)
        {
            ReportParameter custnameParam = new ReportParameter("custnameParam", this.pct_custname.Text);
            reportViewer1.LocalReport.SetParameters(custnameParam);
            this.reportViewer1.RefreshReport();
        }

        private void pct_addr_TextChanged(object sender, EventArgs e)
        {
            ReportParameter addrParam = new ReportParameter("addrParam", this.pct_addr.Text);
            reportViewer1.LocalReport.SetParameters(addrParam);
            this.reportViewer1.RefreshReport();
        }

        private void pct_num_TextChanged(object sender, EventArgs e)
        {
            ReportParameter numParam = new ReportParameter("numParam", this.pct_num.Text);
            reportViewer1.LocalReport.SetParameters(numParam);
            this.reportViewer1.RefreshReport();
        }

        private void pct_compaff_TextChanged(object sender, EventArgs e)
        {
            ReportParameter compaffParam = new ReportParameter("compaffParam", this.pct_compaff.Text);
            reportViewer1.LocalReport.SetParameters(compaffParam);
            this.reportViewer1.RefreshReport();
        }

        private void pct_comppos_TextChanged(object sender, EventArgs e)
        {
            ReportParameter compposParam = new ReportParameter("compposParam", this.pct_comppos.Text);
            reportViewer1.LocalReport.SetParameters(compposParam);
            this.reportViewer1.RefreshReport();
        }
    }
}
