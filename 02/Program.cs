using System;
using System.Collections.Generic;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {

            BankAccount b1 = new BankAccount(0, 0.1M, 0.01M);
            b1.Deposit(500M);
            b1.AccrueInterest();
            b1.Withdraw(600M);
            for (int i = 0; i < 5000; i++)
            {
                b1.AccrueInterest();
                b1.Deposit(10M);
                Console.WriteLine(b1.Balance);
            }
        }

        void Filter ()
        {
            //With a Person-list:
            List<Person> plist = new List<Person>();
            plist.Add(new Person(15, "Thomas"));
            plist.Add(new Person(23, "Bo"));
            plist.Add(new Employee(28, "Bo", "sales", 51M, 8));
            plist.Add(new Employee(31, "Hans", "director", 5M, 10));
            plist.Add(new Person(42, "Kurt"));
            //I can retrieve a list of all named ''Thomas'' using:
            PersonFilter pfilter = new OrFilter(new NameFilter("Bo"), new EmployeeFilter());
            List<Person> filteredList = pfilter.Filter(plist);

            Console.WriteLine("All elements in filtered list");
            foreach (Person p in filteredList)
            {
                Console.WriteLine(p.name + " age: " + p.Age);
            }

            Console.WriteLine("Hello World!");
            Employee p1 = new Employee(20, "Bob", "Production worker", 4000M, 2);
            Employee p2 = new Manager(13, 10000M, "Bob", "Production worker", 5000M, 2);

            Console.WriteLine(p1.CalculateYearlySalary());
            Console.WriteLine(p2.CalculateYearlySalary());


            Console.WriteLine(true);
        }
    }
}
