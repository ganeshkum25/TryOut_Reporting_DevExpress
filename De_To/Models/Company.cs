using System.Collections.Generic;

namespace Models
{
    public class Company
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public EmployeeDto Manager { get; set; }

        public EmployeeDto CEO { get; set; }

        public List<EmployeeDto> Employees { get; set; }
    }
}