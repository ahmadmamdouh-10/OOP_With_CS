using System;
using System.Collections.Generic;
using System.Text;

namespace Day5.Lab1
{
    class Point3D
    {
        public int x, y, z;

        public  Point3D(int _x, int _y, int _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }

        public void displayAll()
        {
            Console.WriteLine($"value of x =  {x} \t , value of y =  {y} \t , value of z = {z}");
        }

        public int CalcDistance(Point3D p1)
        {
            int distance;
            double partx = (int)Math.Pow((x - p1.x), 2);
            distance = (int)Math.Sqrt(partx);
            return distance;
        }

        public static bool operator ==(Point3D p1, Point3D p2)
        {
            return p1.x == p2.x && p1.y == p2.y && p1.z == p2.z;
        }

        public static bool operator !=(Point3D p1, Point3D p2)
        {
            return p1.x != p2.x || p1.y != p2.y || p1.z != p2.z;
        }



    }
}
