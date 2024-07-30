namespace LinqTest.Data
{
    internal class Employee
    {
        private int _id;
        private string _name;
        private double _salary;
        private int? _department;

        public Employee(int id, string name, double salary, int? department)
        {
            this._id = id;
            this._name = name;
            this._salary = salary;
            this._department = department;
        }

        public int Id { get { return _id; } }
        public string Name { get { return _name; } }
        public double Salary { get { return _salary; } }
        public int? Department { get { return _department; } set { _department = value; } }
    }
}
