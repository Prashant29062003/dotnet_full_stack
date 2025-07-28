using System.ComponentModel;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    public static void Main(string[] args)
    {
        //Q7.Use switch statement and perform some task.
        //Console.Write("Enter choice in number: ");
        //if(int.TryParse(Console.ReadLine(), out int choice))
        //{
        //    switch (choice)
        //    {
        //        case 1:
        //            Console.WriteLine("You chose One!");
        //            break;
        //        case 2:
        //            Console.WriteLine("You chose Two!");
        //            break;
        //        case 3:
        //            Console.WriteLine("You chose Three!");
        //            break;
        //        default:
        //            Console.WriteLine("Choice out of range (1-3).");
        //            break;
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Invalid Choice!");
        //}

        Console.WriteLine("--------------------------------------------------");

        Console.WriteLine("--- Conditonals ---");
        //1) write a program to accept a number N and print whether it is positive , negative or zero.
        //Console.Write("Enter any number: ");
        //if(int.TryParse(Console.ReadLine(), out int value))
        //{
        //    if(value < 0)
        //    {
        //        Console.WriteLine($"{value} is negative.");
        //    }else if(value > 0)
        //    {
        //        Console.WriteLine($"{value} is positive.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{value} is Zero.");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Invalid input.");
        //}

        //2)Write a program to accept two number and print greater value of two
        //Console.Write("Enter first number: ");
        //if(float.TryParse(Console.ReadLine(), out float num1))
        //{
        //    Console.Write("Enter Second Number: ");
        //    if(float.TryParse(Console.ReadLine(), out float num2)){
        //        if(num1 > num2)
        //        {
        //            Console.WriteLine($"{num1} is greater");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"{num2} is greater");
        //        }
        //    }
        //}

        //// 3) write a program to accept a number N and print whether the number is Even or Odd
        //Console.Write("Enter an integer to check Even/Odd: ");
        //if (int.TryParse(Console.ReadLine(), out int numEO))
        //{
        //    if (numEO % 2 == 0)
        //    {
        //        Console.WriteLine($"{numEO} is Even.");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"{numEO} is Odd.");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Invalid input. Please enter an integer.");
        //}
        //Console.WriteLine("--------------------------------------------------");


        //Console.WriteLine("\n--- Q9: Return last digit ---");
        //// Q9.Return last digit of the given number.
        //Console.Write("Enter an integer to find its last digit: ");
        //if (int.TryParse(Console.ReadLine(), out int numberLastDigit))
        //{
        //    int lastDigit = Math.Abs(numberLastDigit % 10); // Use Math.Abs to handle negative numbers correctly
        //    Console.WriteLine($"The last digit of {numberLastDigit} is: {lastDigit}");
        //}
        //else
        //{
        //    Console.WriteLine("Invalid input. Please enter an integer.");
        //}
        //Console.WriteLine("--------------------------------------------------");


        //Console.WriteLine("\n--- Q10: Return second last digit ---");
        // Q10.Return second last digit of the given number.
        Console.Write("Enter an integer to find its second last digit: ");
        if (int.TryParse(Console.ReadLine(), out int numberSecondLastDigit))
        {
            if (Math.Abs(numberSecondLastDigit) < 10) // If number has less than 2 digits
            {
                Console.WriteLine($"{numberSecondLastDigit} does not have a second last digit.");
            }
            else
            {
                int secondLastDigit = Math.Abs((numberSecondLastDigit / 10) % 10);
                Console.WriteLine($"The second last digit of {numberSecondLastDigit} is: {secondLastDigit}");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
        }
        Console.WriteLine("--------------------------------------------------");





        Console.WriteLine("Press Any Key to exit...");
        Console.ReadLine();

    }
}