namespace Models
{
    public static class HelperMethods
    {
        public static EmployeeDto ToDto(this EmployeeEntity employee)
        {
            return new EmployeeDto()
            {
                Name = employee.Name,
                Position = employee.Position,
                Height = employee.Height * 100
            };
        }
    }
}