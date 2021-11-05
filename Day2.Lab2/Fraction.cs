using System;
using System.Collections.Generic;
using System.Text;

namespace Day2.Lab2
{
    class Fraction
    {
        public int Nom, Den;

        public Fraction() : this(5,6)
        {

        }

        public Fraction(int _Nom, int _Den)
        {
            if (_Den == 0)
            {
                Nom = _Nom;
                Den = 1;
                Console.WriteLine("Invalid Denominator, we will replace it to 1 \n");

            }
            else
            {
                Nom = _Nom;
                Den = _Den;

            }
        }

        public void display()
        {
            Console.WriteLine($"Nominator = {Nom} \n Denominator = {Den} ");
        }

         public Fraction add(Fraction f1)
        {
            Fraction res = new Fraction();
            res.Nom = (f1.Nom * this.Den) + (this.Nom * f1.Den);
            res.Den = f1.Den * this.Den;

            return res;

        }
    }
}
