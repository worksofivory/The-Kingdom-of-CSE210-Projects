using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome(){
            System.Console.WriteLine("Welcome to the Program");
        }
        static string PromptUserName(){
            System.Console.Write("Enter your name here: ");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber(){
            System.Console.Write("What's your favorite number?: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }
        static int SquareNumber(int number){
            int squared = number*number;
            return squared;
        }
        static void DisplayResult(string name, int number){
            System.Console.WriteLine($"{name}, the square of your favorite number is {number}");
        }
        DisplayWelcome();
        DisplayResult(PromptUserName(), SquareNumber(PromptUserNumber()));
    }
}