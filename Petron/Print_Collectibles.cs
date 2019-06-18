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
    public partial class Print_Collectibles : Form
    {
        public Print_Collectibles()
        {
            InitializeComponent();
        }

        private void Print_Collectibles_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbpetron2CollectiblesDateRangeDataSet.view_collectibles_daterange' table. You can move, or remove it, as needed.
            this.view_collectibles_daterangeTableAdapter.Fill(this.dbpetron2CollectiblesDateRangeDataSet.view_collectibles_daterange);

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
