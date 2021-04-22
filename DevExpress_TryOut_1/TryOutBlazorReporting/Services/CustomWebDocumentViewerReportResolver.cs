using DevExpress.DataAccess.ObjectBinding;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using TryOutBlazorReporting.PreDefinedReports;

namespace Reporting_ObjectDS_AspNetCore
{
    public class CustomWebDocumentViewerReportResolver : IWebDocumentViewerReportResolver
    {
        public XtraReport Resolve(string reportEntry)
        {
            if (reportEntry.StartsWith("EmployeeReport"))
            {
                XtraReport rep = CreateReport(reportEntry);
                rep.DataSource = CreateObjectDataSource(reportEntry);
                return rep;
            }

            return new XtraReport();
        }

        private object CreateObjectDataSource(string reportName)
        {
            if (reportName == "EmployeeReport")
            {
                //ObjectDataSource dataSource = new ObjectDataSource();
                //dataSource.Name = "EmployeeObjectDS";
                //dataSource.DataSource = typeof(EmployeeDataSource);
                //dataSource.Constructor = ObjectConstructorInfo.Default;
                //dataSource.DataMember = "GetEmployeeList";
                //return dataSource;


                ObjectDataSource dataSource = new ObjectDataSource();
                dataSource.Name = "EmployeeObjectDS";
                dataSource.DataSource = typeof(EmployeeDataSource);
                // Map data source parameter to report's parameter.
                var parameter = new Parameter()
                {
                    Name = "department",
                    Type = typeof(DevExpress.DataAccess.Expression),
                    Value = new DevExpress.DataAccess.Expression("?parameterDepartment", typeof(string))
                };
                dataSource.Constructor = new ObjectConstructorInfo(parameter);
                dataSource.DataMember = "GetEmployeeList";
                return dataSource;
            }
            else
            if (reportName.EndsWith("7"))
            {
                ObjectDataSource dataSource = new ObjectDataSource();
                dataSource.Name = "EmployeeObjectDS";
                dataSource.DataSource = typeof(EmployeeDataSource);
                // Specify the parameter's default value.
                var parameter = new Parameter("recordCount", typeof(int), 7);
                dataSource.Constructor = new ObjectConstructorInfo(parameter);
                dataSource.DataMember = "GetEmployeeList";
                return dataSource;
            }
            else
            if (reportName.EndsWith("Parameter"))
            {
                ObjectDataSource dataSource = new ObjectDataSource();
                dataSource.Name = "EmployeeObjectDS";
                dataSource.DataSource = typeof(EmployeeDataSource);
                // Map data source parameter to report's parameter.
                var parameter = new Parameter()
                {
                    Name = "recordCount",
                    Type = typeof(DevExpress.DataAccess.Expression),
                    Value = new DevExpress.DataAccess.Expression("?parameterNoOfItems", typeof(int))
                };
                dataSource.Constructor = new ObjectConstructorInfo(parameter);
                dataSource.DataMember = "Items";
                return dataSource;
            }
            else
            {
                ObjectDataSource dataSource = new ObjectDataSource();
                dataSource.Name = "EmployeeObjectDS";
                dataSource.DataSource = typeof(EmployeeDataSource);
                var parameterNoOfItems = new Parameter("noOfItems", typeof(int), 12);
                dataSource.Parameters.Add(parameterNoOfItems);
                dataSource.Constructor = ObjectConstructorInfo.Default;
                dataSource.DataMember = "GetData";
                return dataSource;
            }
        }

        private XtraReport CreateReport(string reportEntry)
        {
            if (reportEntry.Contains("Parameter"))
            {
                XtraReport report = new EmployeeReport();
                DevExpress.XtraReports.Parameters.Parameter param =
                    new DevExpress.XtraReports.Parameters.Parameter()
                    {
                        Name = "parameterDepartment",
                        Type = typeof(string),
                        Value = "Management"
                    };
                param.Description = "Department";
                report.Parameters.Add(param);
                report.RequestParameters = false;
                return report;
            }
            else
                return new EmployeeReport();
        }
    }

}
