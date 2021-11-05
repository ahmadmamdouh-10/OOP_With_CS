using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1.Lab2
{
    class Fraction
    {
        public int nom { set; get; }
        private int den;

        public int Den
        {
            set
            {
                if (value == 0)
                {
                    den = 1;
                    Console.WriteLine("Invalid Denominator, we will replace it to 1 \n");
                    
                }
                else
                {
                    den = value;
                    
                }

            }

            get
            {
                return den;

            }
        }
       

       public  void display() {
            Console.WriteLine($"Nominator = {nom} \n Denominator = {den} ");
        }

        public Fraction add(Fraction f1, Fraction f2)
        {
            Fraction res= new Fraction();
            res.nom = (f1.nom * f2.Den) + (f2.nom * f1.Den);
            res.Den = f1.den * f2.den;

            return res;

        }



    }
}
