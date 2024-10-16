using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction one = new Fraction();
        Fraction two = new Fraction(5);
        Fraction three = new Fraction(3 , 4);
        Fraction four = new Fraction(1, 3);

        string oneString = one.getFractionString();
        string twoString = two.getFractionString();
        string threeString = three.getFractionString();
        string fourString = four.getFractionString();

        double oneDecimal = one.getDecimalValue();
        double twoDecimal = two.getDecimalValue();
        double threeDecimal = three.getDecimalValue();
        double fourDecimal = four.getDecimalValue();

        System.Console.WriteLine($"{oneString}\n{oneDecimal}\n{twoString}\n{twoDecimal}\n{threeString}\n{threeDecimal}\n{fourString}\n{fourDecimal}");
    }
}