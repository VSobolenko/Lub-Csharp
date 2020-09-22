using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class A
    {
        private int _a = 3;
        private int _b = 10;

        public A(int a, int b)
        {
            _a = a;
            _b = b;
        }

        public A()
        {
        }

        public int c
        {
            get
            {
                return _a %= (_a + _b);
            }
            set
            {
                _a = value;
            }
        }
    }
}
