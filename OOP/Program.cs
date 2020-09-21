using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] arrayPerson = new Person[5];

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("До сортировки");
            arrayPerson[0] = new Person("Соболенко", 2001, "Студент");
            arrayPerson[0].GetInfo();

            arrayPerson[1] = new Person("Пушкин", 2002, "Студент");
            arrayPerson[1].GetInfo();

            arrayPerson[2] = new Person("Астаренко", 1983, "Бизнесмен");
            arrayPerson[2].GetInfo();

            arrayPerson[3] = new Person("Чехов", 1993, "Преподаватель");
            arrayPerson[3].GetInfo();

            arrayPerson[4] = new Person("Ленин", 2000, "Бизнесмен");
            arrayPerson[4].GetInfo();

            Console.ForegroundColor = ConsoleColor.Blue;

            Array.Sort(arrayPerson);
            Console.WriteLine("\nПосле сортировки по фамилии");
            for(int i = 0; i<arrayPerson.Length; i++)
            {
                arrayPerson[i].GetInfo();
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nПосле сортировки по возрасту");
            Array.Sort(arrayPerson, new Sort());
            for (int i = 0; i < arrayPerson.Length; i++)
            {
                arrayPerson[i].GetInfo();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
