using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    class Rectangle
    {
        protected Line l;
        protected Line w;

        public Rectangle()
        {

        }

        public Rectangle(Line _l, Line _w)
        {
            l = _l;
            w = _w;
        }

         int GetLength()
        {
            return l.GetLength();
        }

         int GetWidth()
        {
            return w.GetLength();
        }

        public  int GetArea()
        {
            int area = l.GetLength() * w.GetLength();
            return area;    
        }

    }
}
