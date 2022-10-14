using _06;






//firstTask();
//secondTask();
thirdTask();





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

void thirdTask ()
{
    Dict<int, string> dictionay = new Dict<int, string>();
    dictionay.Put(new Pair<int, string>(0, "Hello World!"));
    dictionay.Put(new Pair<int, string>(3, "Theis"));
    dictionay.Put(new Pair<int, string>(6, "Test"));
    dictionay.Put(new Pair<int, string>(87, "Foo"));
    dictionay.Put(new Pair<int, string>(32, "Bar"));
    dictionay.Put(new Pair<int, string>(31, "Secret"));

    Console.WriteLine(dictionay.Get(32));
    dictionay.Put(new Pair<int, string>(32, "Bar2"));
    Console.WriteLine(dictionay.Get(32));


}