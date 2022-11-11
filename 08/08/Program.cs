namespace _08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sequence numbers = new((prev, current) => prev+current, 1);
            RandomNumbers numbers = new(1, 10, 1, 10);
            Console.WriteLine();
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}






/* Smart
 * 
 * int current = -1;
            while (true)
            {
                yield return current;
            }

*/