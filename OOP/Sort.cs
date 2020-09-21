using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Sort : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
    
            if (x.Info() > y.Info())
                return 1;
            else if (x.Info() < y.Info())
                return -1;
            else
                return 0;
        }
    }
}
