using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Square : IGeometricFigure
    {
        private float _side;

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
    }
}
