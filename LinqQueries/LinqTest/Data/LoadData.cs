namespace LinqTest.Data
{
    internal class LoadData
    {
        public static List<Employee> LoadEmployee()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(101,"Ashok Anand",50000, null),
                new Employee(102,"Biswa Barik",65000, null),
                new Employee(103,"Chiranjeet Choudhary",45000, null),
                new Employee(104,"Deepak Dash",20000, null),
                new Employee(105,"Elina Ekka",70000, null),
                new Employee(106,"Firoz Firdos",50000, null),
                new Employee(106,"Goutam Gouda",55000, null)
            };
            return employees;
        }

        public static List<Department> Department()
        {

            List<Department> departments = new List<Department>()
            {
                new Department(001,"Physics","Department of Physics"),
                new Department(002, "Mathematics","Department of Mathematics"),
                new Department(002, "Chemestry","Department of Chemestry"),
                new Department(002, "CSA","Department of Computer Science and Application"),
                new Department(002, "Mechanical","Department of Mechanical"),
                new Department(002, "IT","Department of Information Technology")
            };
            return departments;
        }
    }
}
