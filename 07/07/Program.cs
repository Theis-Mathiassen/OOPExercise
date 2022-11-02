// See https://aka.ms/new-console-template for more information

using _07;




Functions func = new();

string result = func.JoinThree("Hello ", "World", "!", (string str1, string str2) => { return str1 + str2; });

string result2 = func.JoinAll(JoinString, "H", "el", "lo", " W", "or", "ld!");


Console.WriteLine(result2);


string JoinString (string str1, string str2)
{
    return str1 + str2;
}










