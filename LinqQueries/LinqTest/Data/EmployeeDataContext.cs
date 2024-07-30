namespace LinqTest.Data
{
    internal class EmployeeDataContext
    {
        internal static List<Employee> Employees = LoadData.LoadEmployee();
        internal static List<Department> Departments = LoadData.Department();
    }
}
