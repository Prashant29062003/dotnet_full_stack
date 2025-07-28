using System.Collections.Generic;

class NegativeNumberException : Exception
{
    public NegativeNumberException(string message) : base(message)
    {

    }
}

class Person
{
    string FirstName, LastName;

    public void UserDetails()
    {
        

    }
}
class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, int> subject = new Dictionary<string, int>
        {
            {"Maths", 0 },
            { "English", 0 },
            {"Science", 0 }
        };
        
        foreach(var sub in subject.Keys)
        {
            while (true)
            {
                Console.Write($"Enter your marks of {sub}:");
                string input = Console.ReadLine();
                try
                {
                    int marks = int.Parse(input);
                    if(marks < 0)
                    {
                        throw new NegativeNumberException("Marks cannot be negative.");
                    }
                    subject[sub] = marks;
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input! Please enter valid integer.");
                }
                catch (NegativeNumberException ex)
                {
                    Console.WriteLine($"Exception :: {ex.Message}");
                }
            }
        }
        Console.WriteLine("\n--- Enterd Marks ---");
        foreach(var s in subject)
        {
            Console.WriteLine($"{s.Key} {s.Value}");
        }
        Console.ReadLine(); 

    }
}