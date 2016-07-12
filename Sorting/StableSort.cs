using System;
using System.Collections.Generic;

namespace Algorithms.Sorting
{
    public class StableSort
    {
        public void Sort(Employee[] employees)
        {
            var wrappers = new EmployeeWrapper[employees.Length];
            for (var i = 0; i < wrappers.Length; i++)
            {
                wrappers[i] = new EmployeeWrapper {Employee = employees[i], Index = i};
            }

            Array.Sort(wrappers, new EmployeeComparer());

            for (var i = 0; i < wrappers.Length; i++)
            {
                employees[i] = wrappers[i].Employee;
            }
        }

        private class EmployeeWrapper
        {
            public Employee Employee { get; set; }
            public int Index { get; set; }
        }

        private class EmployeeComparer : IComparer<EmployeeWrapper>
        {
            public int Compare(EmployeeWrapper x, EmployeeWrapper y)
            {
                var surname = StringComparer.InvariantCultureIgnoreCase.Compare(x.Employee.Surname, y.Employee.Surname);
                if (surname == 0)
                {
                    return x.Index - y.Index;
                }
                return surname;
            }
        }
    }
}