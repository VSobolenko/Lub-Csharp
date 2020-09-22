using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class A
    {
        public int a = 3;
        private int _b = 10;

        public A(int a1, int b)
        {
            a = a1;
            _b = b;
        }

        public A()
        {
        }

        public int c
        {
            get
            {
                return a %= (a + _b);
            }
            set
            {
                a = value;
            }
        }
    }
}
