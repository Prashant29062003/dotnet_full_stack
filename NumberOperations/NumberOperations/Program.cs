namespace NumberOperations;
using System;


public class NumberOperations
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Number Operations App!");
        Console.WriteLine("-------------------------------------");

        // --- Input two numbers ---
        int num1, num2;

        Console.Write("Enter the first number (num1): ");
        // Use int.TryParse for safer input conversion
        while (!int.TryParse(Console.ReadLine(), out num1))
        {
            Console.Write("Invalid input. Please enter an integer for num1: ");
        }

        Console.Write("Enter the second number (num2): ");
        while (!int.TryParse(Console.ReadLine(), out num2))
        {
            Console.Write("Invalid input. Please enter an integer for num2: ");
        }

        Console.WriteLine($"\nInitial values: num1 = {num1}, num2 = {num2}");

        // --- Scenario 1: Assign num1 to num2 by pre-incrementing num1 ---
        Console.WriteLine("\n--- Scenario 1: Pre-increment num1 and assign to num2 ---");
        // Store original num1 for this scenario's demonstration
        int originalNum1_scenario1 = num1;
        int originalNum2_scenario1 = num2;

        // Pre-increment: num1 is incremented first, then its new value is assigned to num2.
        num2 = ++num1;

        Console.WriteLine($"After num2 = ++num1:");
        Console.WriteLine($"  num1 (after pre-increment) = {num1}"); // num1 will be incremented
        Console.WriteLine($"  num2 (assigned value)      = {num2}"); // num2 gets the incremented value of num1
        // Reset values for the next scenario
        num1 = originalNum1_scenario1;
        num2 = originalNum2_scenario1;
        Console.WriteLine($"  Values reset for next scenario: num1 = {num1}, num2 = {num2}");


        // --- Scenario 2: Assign num1 to num2 by post-incrementing num1 ---
        Console.WriteLine("\n--- Scenario 2: Post-increment num1 and assign to num2 ---");
        // Store original num1 for this scenario's demonstration
        int originalNum1_scenario2 = num1;
        int originalNum2_scenario2 = num2;

        // Post-increment: The current value of num1 is assigned to num2 first,
        // then num1 is incremented.
        num2 = num1++;

        Console.WriteLine($"After num2 = num1++:");
        Console.WriteLine($"  num1 (after post-increment) = {num1}"); // num1 will be incremented
        Console.WriteLine($"  num2 (assigned value)       = {num2}"); // num2 gets the original value of num1
        // Reset values for the next scenario
        num1 = originalNum1_scenario2;
        num2 = originalNum2_scenario2;
        Console.WriteLine($"  Values reset for next scenario: num1 = {num1}, num2 = {num2}");


        // --- Scenario 3: Swap both values ---
        Console.WriteLine("\n--- Scenario 3: Swapping num1 and num2 ---");
        Console.WriteLine($"Before swap: num1 = {num1}, num2 = {num2}");

        // Method 1: Using a temporary variable (most common and safest)
        int temp = num1;
        num1 = num2;
        num2 = temp;
        Console.WriteLine($"After swap (using temp variable): num1 = {num1}, num2 = {num2}");

        // To demonstrate another swap, let's reset and swap again
        Console.WriteLine("\nResetting values to original for another swap method demonstration...");
        // Reset to initial values for demonstration of another swap method
        num1 = originalNum1_scenario1; // Assuming original values are still valid from start
        num2 = originalNum2_scenario1;
        Console.WriteLine($"Before swap: num1 = {num1}, num2 = {num2}");

        // Method 2: Using arithmetic operations (only for numbers, can cause overflow with large numbers)
        // This method works by adding and subtracting the numbers.
        // It's generally less preferred than the temp variable method due to potential overflow
        // and readability.
        num1 = num1 + num2; // num1 now holds the sum of original num1 and num2
        num2 = num1 - num2; // num2 now holds original num1 (sum - original num2)
        num1 = num1 - num2; // num1 now holds original num2 (sum - original num1)
        Console.WriteLine($"After swap (using arithmetic operations): num1 = {num1}, num2 = {num2}");


        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey(); // Keep the console window open until a key is pressed
    }
}
