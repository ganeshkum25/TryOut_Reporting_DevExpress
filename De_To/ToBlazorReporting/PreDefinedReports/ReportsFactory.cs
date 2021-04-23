using System;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;

namespace ToBlazorReporting.PreDefinedReports
{
    public static class ReportsFactory
    {
        public static Dictionary<string, Func<XtraReport>> Reports = new Dictionary<string, Func<XtraReport>>()
        {
            ["EmployeeReport"] = () => new EmployeeReport()
        };
    }
}
