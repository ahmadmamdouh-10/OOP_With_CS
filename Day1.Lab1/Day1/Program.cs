using System;

namespace Day1.Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            point p1 = new point() { x = 50, y = 75, z = 90 };
            point p2 = new point() { x = 70, y=65, z= 80 };


            p1.displayAll();

            p2.displayAll();

           Console.WriteLine($"the result of calculation distance = {p2.CalcDistance(p1)} ");
        }
    }
}
