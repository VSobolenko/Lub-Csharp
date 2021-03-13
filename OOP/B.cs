using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class B : A
    {
        private int _d;
        public string key;
        public string password;

        public B(int a, int b, int d) : base(a, b)
        {
            _d = d;
        }
        public B()
        {

        }

        public int year 
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
        public static bool operator true(B variable)
        {
            return variable.key == "342" && variable.password == "Qwertyuiop";
        }
        public static bool operator false(B variable)
        {
            return  variable.year == 1990;
        }
        public static bool operator !(B variable)
        {
            return true;
        }
    }
}
