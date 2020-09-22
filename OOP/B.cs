using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class B : A
    {
        private int _d;
        public int[] arrayClass;
        public B(int a, int b, int d) : base(a, b)
        {
            _d = d;
        }
        public B()
        {
        }

        public int c2 { get; set; }
        public B(int var1, int var2)
        {
            a = var1;
            c2 = var2;
            arrayClass = new int[a];
            for (int i = 0; i < arrayClass.Length; i++)
            {
                arrayClass[i] = c2 * i;
            }
        }
    }
}
