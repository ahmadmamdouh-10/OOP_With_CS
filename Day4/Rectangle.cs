using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    class Rectangle: Shape
    {
        protected double Dim2;

        public Rectangle(double _dim1, double _dim2)
        {
            Dim = _dim1;
            Dim2 = _dim2;
        }

        public override double CalcArea()
        {
            return  Dim * Dim2;
        }

    }
}
