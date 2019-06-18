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
    public partial class Print_Collections : Form
    {
        public Print_Collections()
        {
            InitializeComponent();
        }

        private void Print_Collections_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbpetron2PrintCollectionsDataSet.view_collections_daterange' table. You can move, or remove it, as needed.
            this.view_collections_daterangeTableAdapter.Fill(this.dbpetron2PrintCollectionsDataSet.view_collections_daterange);

            this.reportViewer1.RefreshReport();
        }

        private void pc_from_TextChanged(object sender, EventArgs e)
        {
            ReportParameter fromParam = new ReportParameter("fromParam", this.pc_from.Text);
            reportViewer1.LocalReport.SetParameters(fromParam);
            this.reportViewer1.RefreshReport();
        }

        private void pc_to_TextChanged(object sender, EventArgs e)
        {
            ReportParameter toParam = new ReportParameter("toParam", this.pc_to.Text);
            reportViewer1.LocalReport.SetParameters(toParam);
            this.reportViewer1.RefreshReport();
        }
    }
}
