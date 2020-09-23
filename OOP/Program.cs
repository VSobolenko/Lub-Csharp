using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            IGeometricFigure[] circle = { new Circle(3, "f"), new Circle(2, "t"), new Square(3), new Square(4)};
            Container container = new Container(circle);

            foreach(var index in circle)
            {
                index.GetInformation();
            }
        }
    }
}
