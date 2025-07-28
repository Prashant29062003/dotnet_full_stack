using System;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;


//Q2.find the length of the firstname and lastname and if the length is same then give the . . boolean output true or false, and find the value by index no
//Q3.Use compare to operation and perform some task.
//Q.create a console application that finds number of digits and alphabet in a given string
//Q. create a console application that accept a string and increments each character in the string by 1 and toggle all characters in the new string to UPPER CASE or LOWER CASE.


class Program
{ 
    public static void Main(string[] args)
    {
        //string firstname = "";
        //string lastname = "";
        ////Q1.write code c# for taking input string firstname and lastname.
        //Console.Write("Enter Your first Name: ");
        //firstname = Console.ReadLine();

        //Console.Write("Enter Your last Name: ");
        //lastname = Console.ReadLine();

        //Console.WriteLine($"Hello, {firstname} {lastname}!");

        ////Q2.find the length of the firstname and lastname and if the length is same then give the . . boolean output true or false,and find the value by index no

        //int length1 = firstname.Length;
        //int length2 = lastname.Length;

        //Console.WriteLine($"First Name length: {length1}");
        //Console.WriteLine($"Last Name length: {length2}");

        //bool areLengthSame = length1 == length2;
        //Console.WriteLine($"Are length same? {areLengthSame}");

        //int indexNum;
        //Console.WriteLine("Enter Index number to find value");
        //indexNum = int.Parse(Console.ReadLine());
        //Console.WriteLine($"At index: {indexNum}, value at first-name '{firstname[indexNum]}' and last-name '{lastname[indexNum]}'");

        //Console.WriteLine("--------------------------------------------------");



        //Q3.Use compare to operation and perform some task.
        //string name1 = "Prashant";
        //string name2 = "Ankit";

        //if(name1.CompareTo(name2) < 0) { 

        //    Console.WriteLine($"{name1} comes before {name2} alphabetically.");
        //}else if(name1.CompareTo(name2) > 0)
        //{
        //    Console.WriteLine($"{name1} comes after {name2} alphabetically.");
        //}
        //else
        //{
        //    Console.WriteLine($"{name1} is equal than {name2}alphabetically.");
        //}


        Console.WriteLine("--------------------------------------------------");


        //// 4. create a console application that finds number of digits and alphabet in a given string
        //Console.WriteLine("Write Any thing: ");
        //string inputStringCount = Console.ReadLine();
        //int digitCount = 0;
        //int alphaCount = 0;
        //foreach(char ch in inputStringCount)
        //{
        //    if (char.IsDigit(ch))
        //    {
        //        digitCount++;
        //    }else if (char.IsLetter(ch))
        //    {
        //        alphaCount++;
        //    }
        //}

        //Console.WriteLine($"Number of Digits: {digitCount}");
        //Console.WriteLine($"Number of Alphabets: {alphaCount}");

        Console.WriteLine("--------------------------------------------------");

        // 5.create a console application that accept a string and increments each character in the string by 1 and toggle all characters in the new string to UPPER CASE or LOWER CASE.
        Console.Write("Enter the any string: ");
        string originalString = Console.ReadLine();
        string modifiedString = "";
        foreach(char c in originalString)
        {
            char incrementedChar = (char)(c+1);

            if (char.IsLetter(incrementedChar))
            {
                if (char.IsUpper(incrementedChar))
                {
                    modifiedString += char.ToLower(incrementedChar);
                }
                else
                {
                    modifiedString += char.ToUpper(incrementedChar);
                }
            }
            else
            {
                modifiedString += incrementedChar;
            }
        }
        Console.WriteLine($"Original String: {originalString}");
        Console.WriteLine($"Modified String: {modifiedString}");


        Console.WriteLine("Press any key to exit...");
        Console.ReadLine();
    }
}
