namespace LinqTest.Data
{
    internal class Department
    {
        private int _id;
        private string _name;
        private string _description;
        public Department(int id, string name, string description)
        {
            this._id = id;
            this._name = name;
            this._description = description;
        }

        public int Id {  get { return _id; } }
        public string Name { get { return _name; } }
        public string Description { get { return _description; } }
    }
}
