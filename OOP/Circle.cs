using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace OOP
{
    class Circle : IGeometricFigure, IEnumerator
    {
        private float _radius;
        private string _color;
        public IGeometricFigure[] _list;
        private int position = -1;
        //private enum _colorCircle
        //{
        //    red,
        //    green,
        //    blue
        //}

        public Circle(float radius, string color)
        {
            _radius = radius;
            _color = color;
        }

        public Circle(IGeometricFigure[] list)
        {
            _list = list;
        }

        public float GetArea { get => (float)Math.Pow(_radius, 2) *(float) Math.PI; set => throw new NotImplementedException(); }

        public void GetInformation()
        {
            Console.WriteLine($"Радиус = {_radius}\nЦвет: {_color}\nПлощадь = {GetArea}\n");
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
