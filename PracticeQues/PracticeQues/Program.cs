namespace PracticeQues;

using Microsoft.VisualBasic;
using System;

using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;

/*
        *create a console application to accept a string and perform below operations:
        1) Print the string in reverse order.
        2) Extract part of string from 2nd position till the end of the string
        3)Replace any given character by "$" and print new string
        4) Copy the string to another string variable, Modify the data in  2nd string variable and print both the strings
*/
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a String: ");

        string inputString = Console.ReadLine();
        if (inputString == null)
        {
            Console.WriteLine("No input provided.");
            return;
        }

        // 1) Print the string in reverse order.
        for (int i = inputString.Length - 1; i >= 0; i--)
        {
            Console.Write(inputString[i]);
        }

        // 2) Extract part of string from 2nd position till the end of the string
        Console.WriteLine("\nExtracted part from 2nd position: " + inputString.Substring(1));

        // 3) Replace any given character by "$" and print new string
        Console.WriteLine("Enter a character to replace with '$': ");
        char ReplaceChar = Console.ReadKey().KeyChar;

        Console.WriteLine();

        string res = "";
        for(int i = 0; i < inputString.Length; i++)
        {
            if (inputString[i] == ReplaceChar) 
            {
                res += '$';
            }
            else
            {
                res += inputString[i];
            }
        }

        //string replacedString = inputString.Replace(ReplaceChar, '$');
        Console.WriteLine("String after replacement: " + res);

        // 4) Copy the string to another string variable, modify the data in 2nd string variable and print both the strings
        string myString = "abcdefghijklmnopqrstuvwxyz";
        string copiedString = myString;
        copiedString += "0123456789";
        Console.WriteLine("Original String: " + myString);
        Console.WriteLine("Modified Copied String: " + copiedString);

        // Wait for user input before closing the console window
    }
}