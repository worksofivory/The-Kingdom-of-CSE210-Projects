using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment student = new Assignment("Jimmy Fallon", "English");
        System.Console.WriteLine(student.getSummary());
        MathAssignment math = new MathAssignment("Timmy Turner", "Multiplication", "7.10", "5-15");
        System.Console.WriteLine(math.getSummary());
        System.Console.WriteLine(math.getHomeworkList());
        WritingAssignment writing = new WritingAssignment("Mary Shelly", "Historical Fiction", "Frankenstein");
        System.Console.WriteLine(writing.getSummary());
        System.Console.WriteLine(writing.getWritingAssignment());
    }
}