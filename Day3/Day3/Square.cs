using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{

    class Square : Rectangle
    {
        public Square()
        {
           
        }

        public Square(Line _l)
        {
            l = _l;
            w = null;
        }

        int getLength()
        {
            return l.GetLength();
        }
        public  int GetArea()
        {
            int length = l.GetLength();
            int area = length * length;

            return area;
        }



    }
}
