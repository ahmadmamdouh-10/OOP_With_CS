using System;
using System.Collections.Generic;
using System.Text;

namespace Day2.Lab1
{
    class point
    {
        public int x, y, z;

        public point():this(10,20,30)
        {

        }

        public point(int _x, int _y, int _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }

        public void displayAll()
        {
            Console.WriteLine($"value of x =  {x} \t , value of y =  {y} \t , value of z = {z}");
        }

        public int CalcDistance(point p1)
        {
            int distance;
            double partx = (int)Math.Pow((x - p1.x), 2);
            distance = (int)Math.Sqrt(partx);
            return distance;
        }
    }
}
