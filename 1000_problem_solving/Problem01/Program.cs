//1.Reverse Pair ASCII Difference Sum

//Problem:
//Given a string, calculate the sum of absolute differences between the first and last character, second and second last, and so on.

//example:
//Input: "HELLO"
//Pairs: (H, O), (E, L), L(middle)
//ASCII: (72, 79), (69, 76), (76)
//Sum = | 72 - 79 | + | 69 - 76 | +76 = 7 + 7 + 76 = 90

//---------------------------------------------------------------------------------------------------------------------------------------------------------
//2.Alternate ASCII Subtraction
//Problem:
//Given a string, subtract ASCII value of every second character from the previous one and sum the result.

//Example:

//Input: "ABCD"
//(65 - 66) + (67 - 68) = -1 + -1 = -2

//---------------------------------------------------------------------------------------------------------------------------------------------------------

//3.Center Character Bonus
//Problem:
//For each word in a sentence:

//If it has an odd length, add the ASCII value of the center letter.

//Otherwise, subtract the ASCII value of the middle two characters.

//Example:

//Input: "HELLO EVEN"
//"HELLO" → center: L = 76
//"EVEN" → middle: V(86), E(69) → subtract = | 86 - 69 | = 17
//Output: 76 + 17 = 93

//---------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;


class Program
{
    static int solution_1(string input)
    {
        int sum = 0;
        int l = 0, r = input.Length - 1;
        while (l <= r)
        {
            if (l == r)
            {
                sum += input[l];
            }
            else
            {
                sum += Math.Abs(input[l] - input[r]);
            }
            l++;
            r--;
        }
        return sum;
    }

    static int solution_2(string input)
    {
        int sum = 0;
        for(int i = 0;i< input.Length;i += 2)
        {
            sum += input[i] - input[i + 1];
        }
        return sum;
    }

    static int solution_3(string input)
    {
        string[] str = input.Split(' ');
        int evenSum =0, oddSum =0;
        foreach(string s in str)
        {
            if (s.Length % 2 != 0)
            {
                oddSum += s[s.Length / 2];

            }
            else
            {
                evenSum += Math.Abs(s[(s.Length / 2) - 1] - s[(s.Length / 2)]);
            }
        }
        return (evenSum+oddSum);
    }
    public static void Main(String[] args)
    {
        string input_1 = "HELLO";
        string input_2 = "ABCD";
        string input_3 = "HELLO EVEN";

        int sum_1 = solution_1(input_1);
        int sum_2 = solution_2(input_2);
        int sum_3 = solution_3(input_3);
        
        Console.WriteLine(sum_1);
        Console.WriteLine(sum_2);
        Console.WriteLine(sum_3);
        Console.ReadLine();

    }
}