using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            A classA = new A();
            Console.WriteLine(classA.c);
            A classA2 = new A(3, 4);
            Console.WriteLine(classA2.c);

            B classB = new B();
            Console.WriteLine(classB.c2);
            B classB2 = new B(3, 4, 5);
            Console.WriteLine(classB2.c2);
        }
    }
}
