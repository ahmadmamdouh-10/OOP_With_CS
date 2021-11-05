using System;
using System.Collections.Generic;
using System.Text;

namespace Day7.Lab1
{
    struct Employee
    {
        public string Name { set; get; }
        public double Salary { set; get; }
        public Role role { set; get; }
      //this is a comment
        public Employee(string _Name, double _Salary, Role _role)
        {
            Name = _Name;
            Salary = _Salary;
            role = _role;
        }


        //This is comment from VS
        public void Display()
        {
            Console.WriteLine($"Name: {Name}, \t Salary: {Salary}, \t Role: {role}");
        }

        public void AssignRole(Role _role)
        {
            role = _role;
        }

        public bool HasRole(Role r)
        {
            if ((r & Role.Admin) == Role.Admin)
            {
                Console.WriteLine($"Role of {Name} is Admin");
                return true;
            }
            
            else if ((r & Role.Accountant) == Role.Accountant)
            {
                Console.WriteLine($"Role of {Name} is Accountant.");
                return true;
            }
            
            else if ((r & Role.Stock) == Role.Stock)
            {
                Console.WriteLine($"Role of {Name} is Stock");
                return true;
            }
            else if ((r & Role.Reception) == Role.Reception)
            {
                Console.WriteLine($"Role of {Name} is Reception.");
                return true;
            }

            else if ((r | Role.Accountant_And_Stock) == Role.Accountant_And_Stock)
            {
                Console.WriteLine($" {Name} has multiple roles, and Roles are Acountant and Stock.");
                return true;
            }
            else if ((r | Role.Accountant_And_Reception) == Role.Accountant_And_Reception)
            {
                Console.WriteLine($" {Name} has multiple roles, and Roles are Acountant and Reception.");
                return true;
            }
            else if ((r | Role.Stock_And_Reception) == Role.Stock_And_Reception)
            {
                Console.WriteLine($" {Name} has multiple roles, and Roles are Reception and Stock.");
                return true;
            }
            else
                return false;
        }

    }
}
