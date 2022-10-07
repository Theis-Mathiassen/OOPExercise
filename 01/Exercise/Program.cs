using System;
using System.IO;

namespace Exercise
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert path");
            string path = Console.ReadLine();
            Console.WriteLine(path);
            int[] ints = new int[100000000];
            Console.WriteLine(ints.Length);
            Console.ReadLine();
            /*
            Person myMother = new Person(new Person(null, null, 80, "Ingelise", "Mathiassen"), new Person(null, null, 80, "Frands", "Mathiassen"), 50, "Laila", "Mathiassen");
            Person myFather = new Person(new Person(null, null, 80, "Far", "mor"), new Person(null, null, 80, "Far", "far"), 50, "Henry", "Mathiassen");
            Person me = new Person(myMother, myFather, 22, "Theis", "Mathiassen");
            Console.WriteLine("Hello World!");
            PersonPrinter.PrintPerson(me);
            Console.WriteLine();
            PersonPrinter.PrintFamilyTree(me);
            */

        }



    }
}


