using System.Collections.Generic;
using DevExpress.DataAccess.Native.DataFederation.QueryBuilder;

namespace Models
{
    public class EmployeeRepo
    {
        private List<EmployeeEntity> management = new List<EmployeeEntity>() {
            new EmployeeEntity() {
                Name = "Ana Trujillo",
                Position = "CEO"
            },
            new EmployeeEntity() {
                Name = "Andrew Fuller",
                Position = "Vice President, Sales"
            }
        };
        private List<EmployeeEntity> financial = new List<EmployeeEntity>() {
            new EmployeeEntity() {
                Name = "Nancy Davolio",
                Position = "Accountant"
            },
            new EmployeeEntity() {
                Name = "Maria Anders",
                Position = "Accountant"
            }
        };
        private List<EmployeeEntity> sales = new List<EmployeeEntity>() {
            new EmployeeEntity() {
                Name = "Antonio Moreno",
                Position = "Sales Representative"
            },
            new EmployeeEntity() {
                Name = "Thomas Hardy",
                Position = "Sales Representative"
            },
            new EmployeeEntity() {
                Name = "Christina Berglund",
                Position = "Order Administrator"
            },
            new EmployeeEntity() {
                Name = "Frédérique Citeaux",
                Position = "Marketing Manager"
            },
            new EmployeeEntity() {
                Name = "Hanna Moos",
                Position = "Sales Representative"
            }
        };

        private string department = "Management";

        public List<EmployeeEntity> GetEmployees()
        {
            List<EmployeeEntity> employees = new List<EmployeeEntity>();

            employees.AddRange(management);
            employees.AddRange(financial);
            employees.AddRange(sales);
            return employees;
        }

        public IEnumerable<EmployeeEntity> GetEmployeeList(string department)
        {
            List<EmployeeEntity> employees = new List<EmployeeEntity>();
            if (this.department == department/*"Management"*/)
                employees = this.management;
            if (this.department == department/*"Financial"*/)
                employees = this.financial;
            if (this.department == department/*"Sales"*/)
                employees = this.sales;
            foreach (var employee in employees)
                    yield return employee;
        }
    }
}