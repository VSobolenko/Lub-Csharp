using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Square : IGeometricFigure, IEnumerator
    {
        private float _side;
        public IGeometricFigure[] _list;
        private int position = -1;

        public Square(IGeometricFigure[] list)
        {
            _list = list;
        }
        public Square(float side)
        {
            _side = side;
        }

        public float GetArea { get => (float)Math.Pow(_side, 2); set => throw new NotImplementedException(); }

        public void GetInformation()
        {
            Console.WriteLine($"Длина стороны = {_side}\nПлощадь = {GetArea}\n");
        }
        public float GetPerimetr()
        {
            return _side * 4;
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public object Current
        {
            get
            {
                try
                {
                    return _list[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public bool MoveNext()
        {
            position++;
            return (position < _list.Length);
        }

        public void Reset()
        {
            position = -1;
        }
    }
}
