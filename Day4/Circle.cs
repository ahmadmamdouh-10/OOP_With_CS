using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    class Circle:Shape
    {
        public Circle(double _Dim)
        {
            Dim = _Dim;
        }

        public override double CalcArea()
        {
            return Dim * Dim * 3.14;
        }
    }
}
