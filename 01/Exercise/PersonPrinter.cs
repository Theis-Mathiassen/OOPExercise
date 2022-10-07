using System;

namespace Exercise
{
    static class PersonPrinter
    {
        static public void PrintPerson (Person p)
        {
            Console.WriteLine($"ID: {p.ID} First name: {p.FirstName} Last name: {p.LastName} age: {p.Age}");
        }

        static public void PrintFamilyTree (Person p)
        {
            if (p.Mother != null)
            {
                PrintFamilyTree(p.Mother);
            }
            if (p.Father != null)
            {
                PrintFamilyTree(p.Father);
            }
            PrintPerson(p);
        }

    }





}
