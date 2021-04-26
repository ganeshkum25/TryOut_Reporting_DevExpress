using System;
using DevExpress.XtraReports.UI;

namespace ToBlazorReporting.PreDefinedReports
{
    public partial class XtraReport1
    {
        public XtraReport1()
        {
            InitializeComponent();
        }

        private void label3_Draw(object sender, DrawEventArgs e)
        {
            var t  = ((DevExpress.XtraReports.UI.XRLabel) sender).Name;
        }
    }
}
