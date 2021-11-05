using System;

namespace Day6.Lab2
{
    class Program
    {
        public static void DsiplayPersons(Person[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].Display();
                Console.WriteLine("\n--------------------------------------------\n");
            }
        }
        static void Main(string[] args)
        {

            Address ad = new Address();
            Employee e1 = new Employee ("ahmed", 23,  1,  5000 , ad);
            Employee e2 = new Employee("Mohamed", 25, 2, 8000, ad);
            Employee e3 = new Employee("Ali", 28, 3, 7000, ad);

            Employee e4 = new Employee
            {
                name = "ahmed",
                age = 23,
                address = new Address() { city = "asyut", street = "helaly", zipCode = 15522 },
                NID = 1,
                salary = 5000
            };


            Trainee t1 = new Trainee("Karim", 29, 1, 1, ad);
            Trainee t2 = new Trainee("Moataz", 27, 2, 2, ad);
            Trainee t3 = new Trainee("Mostafa", 26, 3, 3, ad);







            Person[] p = new Person[6];
            p[0] = e1;
            p[1] = e2;
            p[2] = e3;
            p[3] = t1;
            p[4] = t2;
            p[5] = e4;
           
            DsiplayPersons(p);


            //Console.WriteLine(e1.ToString());
            


        }
    }
}
