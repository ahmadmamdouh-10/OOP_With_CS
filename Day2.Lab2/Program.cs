using System;

namespace Day2.Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction();

            Fraction result= f1.add(f1);
          
            Console.WriteLine($"the Sum = {result.Nom} / {result.Den} ");
        }
    }
}
