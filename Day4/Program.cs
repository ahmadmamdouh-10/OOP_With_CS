using System;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(2,3);
            Console.WriteLine($"Area of Rectangle = {r.CalcArea()}");

           
            Console.WriteLine($"========================================");


            Square s = new Square(2);
            Console.WriteLine($"Area of Square = {s.CalcArea()}");

            Console.WriteLine($"========================================");


            Circle c = new Circle(3);
            Console.WriteLine($"Area of Circle = {c.CalcArea()}");

            

            Console.WriteLine($"========================================");


            Shape[] sh = {r,s,c};

            Picture pic = new Picture(sh);
            

            pic.DisplayAllShapesArea();


            



        }
    }
}
