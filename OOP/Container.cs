using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Container : IEnumerable
    {
        private IGeometricFigure[] _geometricFigures;

        public Container(IGeometricFigure[] geometricFigures)
        {
            _geometricFigures = new IGeometricFigure[geometricFigures.Length];
            _geometricFigures = geometricFigures;
        }

        public IEnumerator GetEnumerator()
        {
            return _geometricFigures.GetEnumerator();
        }
    }
}
