using System;

class Calculator
{
    static int Sum(int a, int b)
    {
        return a + b;
    }

    static int Subtract(int a, int b)
    {
        return a - b;
    }

    static void Main()
    {
        Console.WriteLine("Enter first number:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Sum: " + Sum(a, b));
        Console.WriteLine("Subtract: " + Subtract(a, b));
    }
}
