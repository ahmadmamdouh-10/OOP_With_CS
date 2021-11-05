using System;

namespace Day3
{

    class Program
    {
        static void Main(string[] args)
        {

            // line:
            Line l = new Line(0, 0, 5, 0);
            Line w = new Line(0, 0, 0, 4);

            Console.WriteLine($" Length of Line = {l.GetLength()}");
            Console.WriteLine($" Width of Line  = {w.GetLength()}");

            // rectangle: 
            Rectangle r = new Rectangle(l, w);

            Console.WriteLine($" Area of Rectangle = {r.GetArea()}");

            //Square:
            Square s = new Square(l);
            Console.WriteLine($" Area of Square = {s.GetArea()}");



            Rectangle r2 = new Square(l);
            Console.WriteLine($"Area of Square = {r2.GetArea()}");






        }
    }
}
