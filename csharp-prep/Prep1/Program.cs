using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name? ");
        string first = Console.ReadLine();
        Console.Write("what is your last name? ");
        string last = Console.ReadLine();
        Console.Write($"Your name is {last}, {first} {last}.");
    }
}