using LinqTest.Data;
using System;
using System.Collections.Generic;
/*Element Type has 9 Methods  - 8 - Immediate Execution, 1 - Deferred Execution
 *1. First - 2 Overloads 
 *2. FirstOrDefault - 4 Overloads 
 *3. Last - 2 Overloads 
 *4. LastOrDefault - 4 Overloads 
 *5. Single - 2 Overloads 
 *6. SingleOrDefault - 4 Overloads 
 *7. ElementAt - 2 Overloads 
 *8. ElementAtOrDefault  - 2 Overloads 
 *9. DefaultIfEmpty - 2 Overloads - Deferred Execution 
 */


namespace LinqTest.Queries
{
    internal class LinqElementQueries
    {
        private List<Employee> _employees;
        internal LinqElementQueries()
        {
            _employees = EmployeeDataContext.Employees;
        }

        internal void KnowAllElementQueries()
        {
            #region First

            WriteEmployee(_employees.First());
            WriteEmployee(_employees.First(m => m.Id.ToString().Contains('2')));

            #endregion First

            #region FirstOrDefault

            WriteEmployee(_employees.FirstOrDefault(m => m.Id.ToString().Contains('2')));
            WriteEmployee(_employees.FirstOrDefault());

            #endregion FirstOrDefault
        }

        private void WriteEmployee(Employee? employee)
        {
            if (employee is not null)
            {
                Console.WriteLine("EmplyeeId - " + employee.Id + " Name - " + employee.Name + " Salary - " + employee.Salary);
            }
        }
    }
}
