using System;

namespace AbstractSample
{
    // Abstract Class
    abstract class Calculator
    {
        // Concrete Method
        public int AddTwoNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        // Abstract Method
        public abstract int MultiplyTwoNumbers(int num1, int num2);
    }

    // Derived Class
    class BasicCalculator : Calculator
    {
        // Overriding Abstract Method
        public override int MultiplyTwoNumbers(int num1, int num2)
        {
            return num1 * num2;
        }

        // Displaying results using abstract and concrete methods
        public void ShowResults()
        {
            int a = 10, b = 5;
            Console.WriteLine("Addition: " + AddTwoNumbers(a, b));
            Console.WriteLine("Multiplication: " + MultiplyTwoNumbers(a, b));
        }
    }

    // Main Program
    class Program
    {
        static void Main(string[] args)
        {
            BasicCalculator calc = new BasicCalculator();
            calc.ShowResults();

            Console.ReadLine(); // Keep console open
        }
    }
}
