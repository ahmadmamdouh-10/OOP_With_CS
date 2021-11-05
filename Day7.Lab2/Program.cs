using System;
using System.Text;

namespace Day7.Lab2
{
    class Program
    {
        static void Test(string st)
        {
            st = "Hello";
            //object obj = (object)st;
            Console.WriteLine(st);
        }
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D { x = 2, y = 3, z = 4 };
            Point3D p2 = new Point3D();


            Console.WriteLine("While Compare with Default (==)operator to compare reference Of two objects\n");

            if (p1 == p2)                           //check if the references of objects is equal or not
                Console.WriteLine("Equal");      // bc it default comparison usage to make it compares data NOT reference.
            else
                Console.WriteLine("Not equal");


            Console.WriteLine("=======================================================================");

            Console.WriteLine("Display point Cooridantes: \n");

            p2.displayAll();

            Console.WriteLine("=======================================================================");

            Console.WriteLine("Display point Cooridantes After Change Coordinates: \n");

            p2.ChangeCoordinates(20, 30, 40);
            p2.displayAll();

            Console.WriteLine("=======================================================================");

            //StringBuilder stg = "I'm a string";
            //Test(stg);







        }
    }
}
