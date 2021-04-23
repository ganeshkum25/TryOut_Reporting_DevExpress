using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DevExpress.DataAccess.ObjectBinding;
using Models;

[DisplayName("Employees")]
[HighlightedClass]
public class EmployeeDataSource
{
    private string department;

    public EmployeeDataSource()
    {
        this.department = "Management";
    }

    [HighlightedMember]
    public EmployeeDataSource(string department = "Management")
    {
        this.department = department;
        this.department = "Management";
    }

    [HighlightedMember]
    public IEnumerable<EmployeeDto> GetEmployeeList(int recordCount)
    {

        return new EmployeeRepo().GetEmployeeList(department).Select(e=>e.ToDto()).ToList();
    }

    [HighlightedMember]
    public IEnumerable<EmployeeDto> GetEmployeeList()
    {
        List<EmployeeDto> employees = new EmployeeRepo().GetEmployees().Select(e=>e.ToDto()).ToList();

        employees.AddRange(employees);
        employees.AddRange(employees);
        employees.AddRange(employees);

        //if (this.department == "Management")
        //    employees = this.management;
        //if (this.department == "Financial")
        //    employees = this.financial;
        //if (this.department == "Sales")
        //    employees = this.sales;
        foreach (var employee in employees)
            yield return employee;
    }
}