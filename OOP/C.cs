using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class C<T>
    {
        private static T _somevariable;
        public static string _staticVariableStr;
        public T GetSomeVariable
        {
            get
            {
                return _somevariable;
            }
            private set
            {
                _somevariable = value;  
            }
        }
    }
}
