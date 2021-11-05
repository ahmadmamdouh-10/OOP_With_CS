using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    class Square:Shape
    {
        public Square(double _Dim)
        {
            Dim = _Dim;
        }

        public override double CalcArea()
        {
            return  Dim * Dim;
        }
    }
}
