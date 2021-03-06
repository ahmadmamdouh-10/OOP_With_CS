using System;
using System.Collections.Generic;
using System.Text;

namespace Day6.Lab2
{
    class Trainee:Person
    {
        public int NID { set; get; }
        public int intakeNumber { set; get; }


        public Trainee(string _name, int _age, int _NID, int _intakeNumber, Address _ad)
        {
            name = _name;
            age = _age;
            NID = _NID;
            intakeNumber = _intakeNumber;
            address = _ad;
        }
        public override string ToString()
        {
            return $"name : {name} \t Age : {age} \t Address : {address}  \n" +
                   $" Address  City : {address.city} \t Street : {address.street} \t ZIPCODE : {address.zipCode} \n" +
                   $" NID  : {NID}  \t IntakeNumber : {intakeNumber}";
        }

        public override Person Clone()
        {

            Employee e = (Employee)this.MemberwiseClone();

            e.address = new Address();
            e.address.city = this.address.city;
            e.address.street = this.address.street;
            e.address.zipCode = this.address.zipCode;

            e.address = this.address.Clone();

            return e;
        }

        public override void Display()
        {
            Console.WriteLine($" name: {name} \t Age: {age} \n" +
                $" Address: {address}  \t City : {address.city} \n" +
                $" Street : {address.street} \t ZIPCODE : {address.zipCode} \n" +
                $" NID  : {NID}  \t inTakeNumber : {intakeNumber}");
        }


    }
}
