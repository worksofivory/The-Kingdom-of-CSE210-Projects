using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(2, "blue");
        System.Console.WriteLine($"{square.getColor()}, {square.getArea()}");
        Rectangle rectangle = new Rectangle(2, 3, "green");
        System.Console.WriteLine($"{rectangle.getColor()}, {rectangle.getArea()}");
        Circle circle = new Circle(3, "red");
        System.Console.WriteLine($"{circle.getColor()}, {circle.getArea()}");
    }
}