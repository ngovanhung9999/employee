using System;
using System.Collections;
using System.Collections.Generic;

namespace EmployeeManager
{
    public class SortByName : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.FullName.CompareTo(y.FullName);
        }
    }
}
