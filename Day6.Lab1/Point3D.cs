using System;
using System.Collections.Generic;
using System.Text;

namespace Day6.Lab1
{
    class Point3D
    {
        public int x { get; set; }                 //object intializer
        public int y { get; set; }
        public int z { get; set; }

        


        public Point3D() : this(2, 3, 4)        //constructor chaining 
        {

        }
        public Point3D(int _x, int _y, int _z)
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

        //public static bool operator ==(Point3D p1, Point3D p2)
        //{
        //    return p1.x == p2.x && p1.y == p2.y && p1.z == p2.z;
        //}

        //public static bool operator !=(Point3D p1, Point3D p2)
        //{
        //    return p1.x != p2.x || p1.y != p2.y || p1.z != p2.z;
        //}


        public override string ToString()
        {
            return $"X : {x} \t Y : {y} \t Z : {z}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Point3D)
            {
                Point3D p = (Point3D)obj;
                return this.x == p.x & this.y ==p.y & this.z ==p.z;
            }
            else
                return false;
        }


        public static void Display(Point3D[] p)
        {
            for (int i = 0; i < p.Length; i++)
            {
                 
                    Console.WriteLine($" X{i+1} = {p[i].x}, Y{i+1} = {p[i].y}, Z{i+1} = {p[i].z} ");

            }
        }




    }
}
