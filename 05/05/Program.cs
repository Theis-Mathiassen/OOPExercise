// See https://aka.ms/new-console-template for more information

namespace _05 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine();
                Console.WriteLine("You wrote: " + ReadInteger());

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        static int ReadInteger ()
        {
            string? read = Console.ReadLine();

            try
            {
                return int.Parse(read);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Hello");
            return 0;
        }

    }
}

