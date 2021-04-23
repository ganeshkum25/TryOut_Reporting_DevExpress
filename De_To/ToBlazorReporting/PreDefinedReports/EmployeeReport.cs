using System;
using DevExpress.XtraReports.UI;

namespace ToBlazorReporting.PreDefinedReports
{
    public partial class EmployeeReport
    {
        public EmployeeReport()
        {
            InitializeComponent();
        }

        private void tableCell3_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            var cell = (XRTableCell)sender;
            cell.Text = cell.Text + " (\"*!#©™®\")";
        }

        private void tableCell6_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            var cell = (XRTableCell)sender;
            cell.Text = cell.Text + " (mm)";
        }
    }
}
