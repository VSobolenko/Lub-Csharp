using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            B classB = new B(3, 4);
            foreach(int i in classB.arrayClass)
            {
                Console.WriteLine(i);
            }
        }
    }
}