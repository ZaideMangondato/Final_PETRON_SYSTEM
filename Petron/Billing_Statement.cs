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
    public partial class Billing_Statement : Form
    {
        public Billing_Statement()
        {
            InitializeComponent();
        }

        private void Billing_Statement_Load(object sender, EventArgs e)
        {
            ReportParameter billingdateParam = new ReportParameter("billingdateParam", this.bstxtbillingdate.Text);
            reportViewer1.LocalReport.SetParameters(billingdateParam);
            this.reportViewer1.RefreshReport();
        }

        private void bstxttransid_TextChanged(object sender, EventArgs e)
        {
            ReportParameter transidParam = new ReportParameter("transidParam", this.bstxttransid.Text);
            reportViewer1.LocalReport.SetParameters(transidParam);
            
            
            
            
            
            

            
            
            

            this.reportViewer1.RefreshReport();
        }

        private void bstxtcustid_TextChanged(object sender, EventArgs e)
        {
            ReportParameter custidParam = new ReportParameter("custidParam", this.bstxtcustid.Text);
            reportViewer1.LocalReport.SetParameters(custidParam);
            this.reportViewer1.RefreshReport();
        }

        private void bstxtname_TextChanged(object sender, EventArgs e)
        {
            ReportParameter nameParam = new ReportParameter("nameParam", this.bstxtname.Text);
            reportViewer1.LocalReport.SetParameters(nameParam);
            this.reportViewer1.RefreshReport();
        }

        private void bstxtaddress_TextChanged(object sender, EventArgs e)
        {
            ReportParameter addrParam = new ReportParameter("addrParam", this.bstxtaddress.Text);
            reportViewer1.LocalReport.SetParameters(addrParam);
            this.reportViewer1.RefreshReport();
        }

        private void bstxtdatetrans_TextChanged(object sender, EventArgs e)
        {
            ReportParameter dateorderedParam = new ReportParameter("dateorderedParam", this.bstxtdatetrans.Text);
            reportViewer1.LocalReport.SetParameters(dateorderedParam);
            this.reportViewer1.RefreshReport();
        }

        private void bstxttotalamount_TextChanged(object sender, EventArgs e)
        {
            ReportParameter totalamountParam = new ReportParameter("totalamountParam", this.bstxttotalamount.Text);
            reportViewer1.LocalReport.SetParameters(totalamountParam);
            this.reportViewer1.RefreshReport();
        }

        private void bstxtamountpaid_TextChanged(object sender, EventArgs e)
        {
            ReportParameter amountpaidParam = new ReportParameter("amountpaidParam", this.bstxtamountpaid.Text);
            reportViewer1.LocalReport.SetParameters(amountpaidParam);
            this.reportViewer1.RefreshReport();
        }

        private void bstxtbalance_TextChanged(object sender, EventArgs e)
        {
            ReportParameter balanceParam = new ReportParameter("balanceParam", this.bstxtbalance.Text);
            reportViewer1.LocalReport.SetParameters(balanceParam);
            this.reportViewer1.RefreshReport();
        }

        private void bstxtbillingdate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
