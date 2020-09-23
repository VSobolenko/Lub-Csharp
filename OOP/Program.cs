using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            B classB = new B(3, 4, 5);
            if (!classB)
                Console.WriteLine("Пример 1");

            B classB2 = new B();
            classB2.key = "342";
            classB2.password = "12345678";
            Console.WriteLine(classB2 ? "Секретная информация, пароль: qwerty" : "Неверный пароль");
        }
    }
}
