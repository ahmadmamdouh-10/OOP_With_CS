using System;

namespace Day7.Lab1
{
    enum Role
    {
        Admin = 1,
        Accountant = 2,
        Stock= 4,
        Reception = 16 ,
        Accountant_And_Stock = 6,
        Accountant_And_Reception = 18,
        Stock_And_Reception = 20


    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee { Name = "Ahmed", Salary = 10000, role = Role.Stock | Role.Reception };

            Console.WriteLine("Create a struct employee (1) and try the multiple roles \n ");

            e1.Display();

            Console.WriteLine("=======================================================================");

            Employee e2 = new Employee();
            e2.Name = "Mohammed";
            e2.Salary = 2000;
            e2.AssignRole(Role.Admin);

            Console.WriteLine("Create an Employee (2) and use assign rule function \n ");

            e2.Display();

            Console.WriteLine("=======================================================================");

            e1.HasRole(e1.role);

            Console.WriteLine("=======================================================================");

            e2.HasRole(e2.role);




        }
    }
}
