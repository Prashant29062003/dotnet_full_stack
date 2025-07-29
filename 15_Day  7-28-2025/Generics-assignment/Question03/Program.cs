using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        string digitString = "asjh234fASDj32";

        // list 
        List<char> AlphaList = new List<char>();
        List<char> DigitList = new List<char>();

        foreach(char ch in digitString)
        {
            if (char.IsLetter(ch))
            {
                AlphaList.Add(ch);
            } 
            else if (char.IsDigit(ch))
            {
                DigitList.Add(ch);
            }
        }

        AlphaList.Sort();
        DigitList.Sort();

        Console.Write($"Sorted Aplhabets in {digitString}: ");
        foreach(char ch in AlphaList)
        {
            Console.Write(ch);
        }
        Console.WriteLine();

        Console.WriteLine(new string('-',70));

        Console.Write($"Sorted Digits in {digitString}: ");
        foreach (char ch in DigitList)
        {
            Console.Write(ch);
        }

        Console.ReadLine();
    }
}
