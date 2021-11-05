using System;
using System.Collections.Generic;
using System.Text;

namespace Day5.Lab2
{
    class Fraction
    {
        double Nom, Den;

       
        public Fraction(double _Nom, double _Den)
        {
            Nom = _Nom;
            Den = _Den;

        }


        public void setNom(double _Num)
        {
            Nom = _Num;
        }

        public double getNom()
        {
            return Nom;
        }

        public bool setDen(int _Den)
        {
            if (_Den == 0)
            {
                Den = 1;
                Console.WriteLine("Invalid Denominator, we will replace it to 1 \n");
                return false;
            }
            else
            {
                Den = _Den;
                return true;
            }
        }

        public double getDen()
        {
            return Den;
        }

        public void display()
        {
            Console.WriteLine($"Nominator = {Nom} \n Denominator = {Den} ");
        }

        public Fraction add(Fraction f1, Fraction f2)
        {
            Fraction res = new Fraction(0,0);
            res.Nom = (f1.Nom * f2.Den) + (f2.Nom * f1.Den);
            res.Den = f1.Den * f2.Den;

            return res;

        }

        public static Fraction operator+(Fraction f1, Fraction f2)
        {
            Fraction res = new Fraction(0, 0);
            res.Nom = (f1.Nom * f2.Den) + (f2.Nom * f1.Den);
            res.Den = f1.Den * f2.Den;

            return res;
        }


        public static implicit operator Fraction(double num)
        {
            return new Fraction(num, num);
        }

        public static explicit operator double(Fraction f)
        {
            return f.getNom() / f.getDen();
        }

    }
}
