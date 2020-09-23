using System;
using System.Collections;


namespace OOP
{
    class Circle : IGeometricFigure
    {
        private float _radius;
        private string _color;
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

        public float GetArea { get => (float)Math.Pow(_radius, 2) * (float)Math.PI; set => throw new NotImplementedException(); }

        public void GetInformation()
        {
            Console.WriteLine($"Радиус = {_radius}\nЦвет: {_color}\nПлощадь = {GetArea}\n");
        }
    }
}
