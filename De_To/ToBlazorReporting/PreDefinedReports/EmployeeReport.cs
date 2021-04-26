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

        private void EmployeeReport_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            ApplyLocalization("en-US");
        }

        private void tableCell6_PrintOnPage(object sender, PrintOnPageEventArgs e)
        {
            var cell = (XRTableCell)sender;
            cell.Text = cell.Text + " (mm)";
        }

        private void tableCell4_Draw(object sender, DrawEventArgs e)
        {

        }
    }
}
