using System;

namespace Day5.Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            Point3D p1 = new Point3D(2,4,6);
            Point3D p2 = new Point3D(1,3,5);

            if (p1 == p2)
                Console.WriteLine("Equal");
            else
                Console.WriteLine("Not equal");




        }
    }
}
