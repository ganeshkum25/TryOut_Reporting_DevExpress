using System;
using System.Collections.Generic;
using DevExpress.DataAccess.Web;

namespace ToBlazorReporting.Services {
    public class ObjectDataSourceWizardCustomTypeProvider : IObjectDataSourceWizardTypeProvider {
        public IEnumerable<Type> GetAvailableTypes(string context) {
            return new[] { typeof(EmployeeDataSource) };
        }
    }
}
