using System;
using System.Collections.Generic;
using System.Text;

namespace Day3
{
    class Line
    {
        _2Dpoint p1;   // creation of two references of class _2Dpoint
        _2Dpoint p2;


        public Line(int _p1x, int _p1y, int _p2x, int _p2y)
        {
            p1 = new _2Dpoint(_p1x, _p1y);                 // creation of 2 objects from _2Dpoint 
            p2 = new _2Dpoint(_p2x, _p2y);                //  this means there is a composition relation between  
        }                                                 //  2DPoint & Lin Classes

        public int GetLength()
        {
           double Length = Math.Sqrt(Math.Pow((p1.GetX() - p2.GetX()), 2) + Math.Pow((p1.GetY() - p2.GetY()), 2));
            return Convert.ToInt32(Length);
        }

    }
}
