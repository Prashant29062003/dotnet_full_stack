using System;

public delegate void MathematicalTool(int a, int b);

class Calculator
{
    public static void Add(int a, int b)
    {
        Console.WriteLine($"Addition: {a + b}");
    }

    public static void Subtract(int a, int b)
    {
        Console.WriteLine($"Subtraction: {a - b}");
    }

    public static void Divide(int a, int b)
    {
        if (b != 0)
            Console.WriteLine($"Division: {a / b}");
        else
            Console.WriteLine("Division by zero is not allowed.");
    }

    public static void Multiply(int a, int b)
    {
        Console.WriteLine($"Multiplication: {a * b}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a multicast delegate combining all operations
        MathematicalTool mathtool = Calculator.Add;
        mathtool += Calculator.Subtract;
        mathtool += Calculator.Multiply;
        mathtool += Calculator.Divide;

        // Invoke all operations with same inputs
        mathtool(10, 5);
        Console.ReadLine();
    }
}
