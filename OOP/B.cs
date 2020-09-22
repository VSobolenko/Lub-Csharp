using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class B : A
    {
        private int _d;
        private int[] _arrayClass;

        public B(int a, int b, int d) : base(a, b)
        {
            _d = d;
        }
        public B()
        {
        }

        public int c2
        {
            get
            {
                //if()
                return _d;
            }
            set
            {
                _d = value;
            }
        }
    }
}
