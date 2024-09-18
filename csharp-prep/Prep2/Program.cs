using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What was your number grade? ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        string grade;
        if(number >= 90){
            grade = "A";
        }
        else if(number < 90 && number >= 80){
            grade = "B";
        }
        else if(number < 80 && number >= 70){
            grade = "C";
        }
        else if(number < 70 && number >= 60){
            grade = "D";
        }
        else{
            grade = "F";
        }
        Console.WriteLine($"Your letter grade is {grade}");
    }
}