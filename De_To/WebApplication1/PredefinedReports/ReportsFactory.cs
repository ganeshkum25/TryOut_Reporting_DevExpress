using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.PredefinedReports;

namespace Reporting_ObjectDS_AspNetCore
{
    public static class ReportsFactory
    {
        public static Dictionary<string, Func<XtraReport>> Reports = new Dictionary<string, Func<XtraReport>>()
        {
            ["XtraReport1"] = () => new XtraReport1()
        };
    }
}
