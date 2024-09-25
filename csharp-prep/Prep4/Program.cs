using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        System.Console.WriteLine("Enter a list of numbers, enter 0 when finished.");
        int input = 1;
        do{
            System.Console.Write("Enter a number: ");
            input = int.Parse(Console.ReadLine());
            if(input != 0){
                numbers.Add(input);
            }
        }while(input != 0);
        float sum = 0;
        float avg = 0;
        int count = 0;
        int biggest = -1000;
        foreach (int number in numbers){
            sum += number;
            if(number > biggest){
                biggest = number;
            }
            count +=1;
        }
        avg = sum/count;
        System.Console.WriteLine($"The sum of the list is {sum}");
        System.Console.WriteLine($"The average of the list is {avg}");
        System.Console.WriteLine($"The largest number is {biggest}");
    }
}