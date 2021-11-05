using System;
using System.Collections.Generic;
using System.Text;

namespace Day6.Lab2
{
    abstract class  Person
    {
        public string name { get; set; }
        public int age { get; set; }
        public Address address;

        public override string ToString()
        {
            return $"name : {name} \t Age : {age} \t Address : {address}";
        }

        public abstract Person Clone();

        public abstract void Display();
       






    }
}
