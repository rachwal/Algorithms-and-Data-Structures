using System;
using System.Collections.Generic;

namespace Algorithms.Sorting
{
    public class MultiKeySort
    {
        public void Sort(Employee[] employees)
        {
            Array.Sort(employees, new EmployeeComparer());
        }

        private class EmployeeComparer : IComparer<Employee>
        {
            public int Compare(Employee x, Employee y)
            {
                var surname = StringComparer.InvariantCultureIgnoreCase.Compare(x.Surname, y.Surname);
                if (surname == 0)
                {
                    return StringComparer.InvariantCultureIgnoreCase.Compare(x.GivenName, y.GivenName);
                }
                return surname;
            }
        }
    }
}