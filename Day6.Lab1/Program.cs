using System;

namespace Day6.Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point3D p1 = new Point3D {x=2, y=3, z=4};
            Point3D p2 = new Point3D();

            Console.WriteLine("While Compare with Overrided Equals Function to compare data in two objects");

            if (p1.Equals(p2))                     //check if the values of data in objects is equal or not 
                Console.WriteLine("Equal");       // bc i already overrided it to make it compares data NOT reference.
            else
                Console.WriteLine("Not equal");

            Console.WriteLine("=======================================================================");

            Console.WriteLine("While Compare with Default (==)operator to compare reference Of two objects");
            
            if (p1==p2)                           //check if the references of objects is equal or not
                Console.WriteLine("Equal");      // bc it default comparison usage to make it compares data NOT reference.
            else
                Console.WriteLine("Not equal");


            Console.WriteLine("=======================================================================");


            Console.WriteLine("Display Array Of Points");
            Point3D p3 = new Point3D();
            Point3D[] arr= {p1,p2,p3};
            Point3D.Display(arr);






        }
    }
}
