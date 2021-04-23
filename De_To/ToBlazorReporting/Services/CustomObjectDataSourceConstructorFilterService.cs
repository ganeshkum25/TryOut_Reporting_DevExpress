using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using DevExpress.DataAccess.Web;

namespace ToBlazorReporting.Services
{
    public class CustomObjectDataSourceConstructorFilterService : IObjectDataSourceConstructorFilterService
    {
        public IEnumerable<ConstructorInfo> Filter(Type dataSourceType, IEnumerable<ConstructorInfo> constructors)
        {
            if (dataSourceType == typeof(EmployeeDataSource)) 
                return constructors;
            else
                return constructors.Where(x => x.GetParameters().Length > 0);
        }
    }
}
