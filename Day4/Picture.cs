using System;
using System.Collections.Generic;
using System.Text;

namespace Day4
{
    class Picture
    {
        protected Shape[] arr;


        public Picture(Shape[] _arr)
        {
            arr = _arr;
        }

       

        public void DisplayAllShapesArea()
            {
                double sum = 0;
                for(int i=0; i<arr.Length; i++)
                {
                    sum += arr[i].CalcArea();
                }

            Console.WriteLine($" Sum of Areas of ALL SHAPES = {sum}");

        }

    }
}
