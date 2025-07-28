using System;

class Program
{
    public static void Main(string[] args)
    {
        int num1;
        int num2;

        Console.WriteLine("--- Check second Number's place in first number ---");

        while (true)
        {
            Console.Write("Enter any number: ");
            string input1 = Console.ReadLine(); 
            if(int.TryParse(input1, out num1)){
                break;
            }
            else
            {
                Console.WriteLine("Please enter valid number");
            }

        }

        while (true)
        {
            Console.Write("Enter number from 0 to 9: ");
            string input2 = Console.ReadLine();
            if (int.TryParse(input2, out num2) || num2 >= 0 || num2 <= 9)
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter number in between 0 to 9");
            }

           
        }
        Console.WriteLine($"\nChecking for digit of {num2} in {num1}: ");

        string[] str = {"one's","ten's" ,"hundred'th",};
        string num1AsString = num1.ToString();
        bool found = false;

        for (int i = 0; i < num1AsString.Length; i++)
        {
            int currentDigit = (int)Char.GetNumericValue(num1AsString[i]);

            if (currentDigit == num2)
            {
                Console.WriteLine($"Number {num2} is found at {i + 1}'s place of number {num1}.");
                found = true;
            }
        }

        if (!found)
        {
            Console.WriteLine($"Number {num2} is not found in number {num1}.");
        }
        Console.ReadLine();


    }
}