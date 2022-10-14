using _06;






//firstTask();
secondTask();





void firstTask ()
{
    List<int> numbers = new();
    numbers.Add(51);
    numbers.Add(39);
    numbers.Add(5);
    numbers.Add(81);
    numbers.Add(43);
    numbers.Add(8);
    numbers.Add(324);
    numbers.Add(53);

    int[] numbersArray = numbers.ToArray();
    Console.WriteLine(numbersArray);

    foreach (int item in numbersArray)
    {
        Console.WriteLine(item);
    }
    HandyMethods.shuffle(numbersArray);
    Console.WriteLine();
    foreach (int item in numbersArray)
    {
        Console.WriteLine(item);
    }


    Console.WriteLine(HandyMethods.Max(numbers));
    Console.WriteLine(HandyMethods.Min(numbers));
}


void secondTask()
{
    Pair<int, string> pair = new Pair<int, string>(41, "Hello");
    Console.WriteLine(pair);
    Pair<Pair<float,float>,string> pair2 = pair.setFst<Pair<float, float>>(new Pair<float, float>(4.1f, 5.2f));
    Console.WriteLine(pair2);
    Pair<string,Pair<float, float>> pair3 = pair2.Swap();
    Console.WriteLine(pair3);
}