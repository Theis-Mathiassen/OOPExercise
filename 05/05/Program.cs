// See https://aka.ms/new-console-template for more information

namespace _05 // Note: actual namespace depends on the project name.
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Task4();
        }

        static void Task1 ()
        {
            do
            {
                Console.WriteLine();
                Console.WriteLine("You wrote: " + ReadInteger());

            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
        static void Task2 ()
        {

        }
        static void Task3 ()
        {
            BankAccount ba = new BankAccount(100m);
            try
            {
                ba.Withdraw(ReadInteger());

            }
            catch (InsufficientFundsException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        static void Task4 ()
        {

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

