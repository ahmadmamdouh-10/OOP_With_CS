using System;
using System.Collections.Generic;
using System.Text;

namespace Day6.Lab2
{
    class Address
    {
        public string city { set; get; }
        public string street { set; get; }
        public int zipCode { set; get; }

        public Address() : this("asyut", "soliman Elhakeam", 19997)
        {

        }
        public Address(string _city, string _street, int _zipcode)
        {
            city = _city;
            street = _street;
            zipCode = _zipcode;
        }

        public override string ToString()
        {
            return $"City : {city} \t Street : {street} \t ZIPCODE : {zipCode}";
        }

        public Address Clone()
        {
            
           Address add = (Address)this.MemberwiseClone();

            return add;
        }

    }
}
