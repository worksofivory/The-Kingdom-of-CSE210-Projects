using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 100);
        string guess;
        do{
            Console.Write("What is your guess? ");
            guess = Console.ReadLine();
            if(int.Parse(guess) > magic){
                System.Console.WriteLine("Lower");
            }
            else if(int.Parse(guess)<magic){
                System.Console.WriteLine("Higher");
            }
            else{
                System.Console.WriteLine("That's it!");
            }
            
        } while(int.Parse(guess) != magic);

    }
}