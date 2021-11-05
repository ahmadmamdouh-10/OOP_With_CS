using System;

namespace Day1.Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction() {nom = 5, Den = 6 };
            Fraction f2 = new Fraction() { nom = 2, Den = 5 };

           

            f1.display();

          

            f2.display();


            Fraction res = f1.add(f1, f2);
            Console.WriteLine($"The Sum = {res.nom} / {res.Den} ");

        }
    }
}
