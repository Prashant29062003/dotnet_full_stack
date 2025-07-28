using System;
using System.Diagnostics.Metrics;
using System.Xml.Linq;

namespace AssignmentQues
{
    class Program
    {
        public static void SwappedThreeNums()
        {
            int a = 10, b = 20, c = 30;
            Console.WriteLine("Before swapping:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);

            int temp = a;
            a = b;
            b = c;
            c = temp;

            Console.WriteLine("After swapping:");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
        }


        public static void GetStudentPassed()
        {
            int[] studentMarks = { 45, 67, 30 };
            int count = 0;
            foreach (int i in studentMarks)
            {
                if (i > 35)
                {
                    count++;
                }
            }
            Console.WriteLine("Number of students who passed the exam: " + count);
        }
        
        public static void NumberOfNegativeAndPositive()
        {
            int[] list = { -5, 10, 0, -3, 7 };
            int positiveCount = 0;
            int negativeCount = 0;

            foreach (int i in list)
            {
                if (i >= 0)
                {
                    positiveCount++;
                }
                else
                {
                    negativeCount++;
                }
            }
            Console.WriteLine("Number of non-negative numbers: " + positiveCount);
            Console.WriteLine("Number of negative numbers: " + negativeCount);
        }


        public static int SumOfArray(int[] ints)
        {
            int sum = 0;
            for(int i = 0; i< ints.Length; i++)
            {
                sum += ints[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            // Numbereplacement assignment questions

            // Assignment 1: swap three numbers 
            //SwappedThreeNums();

            // Assignment 2: Given a set of 3 student's examination marks (in the range from 0 to 100), make a count of the number of students that have passed the exam. A pass is awarded if the students mark is greater than or equal to 35.
            //GetStudentPassed();

            //  3:Design an algorithm that reads a list of 5 numbers(both + ve and - ve) and makes a count of the number of negative and non - negative numbers in the list. Note – 0 must be considered as a + ve number in this algorithm.
            //NumberOfNegativeAndPositive();


            // Array assignment questions
            // Assignment 1: Design an algorithm to accept 10 integer elements for an array and print the sum of all the elements.
            int[] ints = new int[10];
            Console.WriteLine("Enter 10 integers:");
            for(int i = 0; i< ints.Length; i++)
            {
                Console.Write($"Element {i + 1}: ");
                bool isValid = false;
                while (!isValid)
                {
                    if(int.TryParse(Console.ReadLine(), out ints[i]))
                    {
                        isValid = true;
                    }
                    else
                    {
                        Console.WriteLine("Enter Valid number.");
                    }
                }
            }
            Console.WriteLine("The sum of the elements is: " + SumOfArray(ints));
            // answer:
            //Enter 10 integers:
            //Element 1: 45
            //Element 2: 25
            //Element 3: 33
            //Element 4: 65
            //Element 5: 98
            //Element 6: 7
            //Element 7: 1
            //Element 8: 0
            //Element 9: 23
            //Element 10: 12
            //The sum of the elements is: 309



            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}