using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            A classA = new A();
            Console.WriteLine(classA.c);
        }
    }
    class A
    {
        private int a = 3;
        private int b = 7;
        public int c
        {
            get
            {
                return a %= (a + b);
            }
            set
            {
                a = value;
            }
        }
    }
}
