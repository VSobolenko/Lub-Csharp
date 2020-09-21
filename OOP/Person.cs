using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Person : IComparable
    {
        private string _lastName;
        private int _yearOfBirth;
        private string _status;

        public Person()
        {
        }

        public Person(string lastName, int yearOfBirth, string status)
        {
            _lastName = lastName;
            _yearOfBirth = yearOfBirth;
            _status = status;
        }

        public int CompareTo(object obj)
        {
            Person p = obj as Person;
            if (p != null)
                return this._lastName.CompareTo(p._lastName);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }

        public void GetInfo()
        {
            Console.WriteLine("Фамилия: " + _lastName);
            Console.WriteLine("Дата рождения: " + Info());
            Console.WriteLine("Сатус: " + _status);
            Console.WriteLine();
        }

        public virtual int Info()
        {
            return _yearOfBirth;
        }
    }
}
