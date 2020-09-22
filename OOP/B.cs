using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class B : A
    {
        private int _d;
        public int[] arrayClass1;
        public int[] arrayClass2 = { 1, 2, 3, 5, 6, 2, 4 };
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
            arrayClass1 = new int[a];
            for (int i = 0; i < arrayClass1.Length; i++)
            {
                arrayClass1[i] = c2 * i;
            }
        }
        public int this[int ind1]
        {
            get
            {
                return arrayClass1[ind1];
            }
            set
            {
                arrayClass1[ind1] = value;
            }
        }
    }
}
