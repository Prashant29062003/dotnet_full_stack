using System.Text;

namespace StringIncrement;

class Program
{
    static void Main(string[] args)
    {
        

        Console.WriteLine("Welcome to the Character Increment and Case Toggle App!");
        Console.WriteLine("-----------------------------------------------------");
            
        Console.WriteLine("Enter a string to increment each character by 1:");
        string input = Console.ReadLine();
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Input cannot be empty. Please enter a valid string.");
            return;
        }

        StringBuilder incrementedString = new StringBuilder();

        foreach (char c in input)
        {
            char incrementedChar = (char) (c + 1);
            incrementedString.Append(incrementedChar);
        }

        for (int i = 0; i< incrementedString.Length; i++)
        {
            char currentChar = incrementedString[i];
            if (char.IsLower(currentChar))
            {
                incrementedString[i] = char.ToUpper(currentChar);
            }
            if(char.IsUpper(currentChar))
            {
                incrementedString[i] = char.ToLower(currentChar);
            }
        }

        Console.WriteLine("Incremented and toggled case string:");
        Console.WriteLine(incrementedString.ToString());

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();

    }
}