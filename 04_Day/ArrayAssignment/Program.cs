using System;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Numerics;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AssignmentQues
{
    class Program
    {
        public static int SumOfArray(int[] ints)
        {
            int sum = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                sum += ints[i];
            }
            return sum;
        }

        public static void Answer2()
        {
            int[] elements2 = { 12, 45, 67, 23, 89, 34, 56, 78, 90, 11,
                                22, 33, 44, 55, 66, 77, 88, 99, 100, 0};

            Console.WriteLine("Orginal Array: " + string.Join(", ", elements2));

            int max1 = int.MinValue;
            int max2 = int.MinValue;
            int max3 = int.MinValue;
            foreach(int element in elements2)
            {
                if(element > max1)
                {
                    max3 = max2;
                    max2 = max1;
                    max1 = element;
                }else if(element > max2)
                {
                    max3 = max2;
                    max2 = element;
                }else if (element > max3)
                {
                    max3 = element;
                }
            }
            Console.WriteLine($"First Max: {max1}");
            Console.WriteLine($"Second Max: {max2}");
            Console.WriteLine($"Third Max: {max3}");


        }

        public static void Answer3()
        {
            int[] elements3 = new int[10];
            Console.WriteLine("Please enter 10 integer elements for the array:");
            for (int i = 0; i < elements3.Length; i++)
            {
                bool isValidInput = false;
                while (!isValidInput)
                {
                    Console.Write($"Element {i + 1}: ");
                    if (int.TryParse(Console.ReadLine(), out int parsedValue))
                    {
                        elements3[i] = parsedValue;
                        isValidInput = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid integer.");
                    }
                }
            }


            Console.WriteLine("Original Array:");
            foreach (int i in elements3)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // R1everse the array
            int f = 0, l = elements3.Length - 1;
            while (f < l)
            {
                int temp = elements3[f];
                elements3[f] = elements3[l];
                elements3[l] = temp;
                f++;
                l--;
            }

            Console.WriteLine("Reversed Array:");
            foreach (int i in elements3)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        public static void Answer4(int n){
            int[] studentMarks = new int[n];
            Console.WriteLine("Enter the Student's number (in the range of 0 to 100): ");
            for(int i = 0; i< studentMarks.Length; i++){
                bool isValidIn = false;
                while (!isValidIn){
                    Console.Write($"Student {i+1}: ");
                    if(int.TryParse(Console.ReadLine(), out int parsedVal)){
                        if(parsedVal < 0 || parsedVal > 100){
                            Console.WriteLine("Enter number between 0 to 100");
                        }
                        else{
                            isValidIn = true;
                            studentMarks[i] = parsedVal;
                        }
                    }
                    else{
                        Console.WriteLine("Enter Valid Number between 0 to 100!");
                    }
                }
            }
            Console.WriteLine("Number of Student's as per the marks: ");
            int[] individualMarks = new int[101];
            foreach(int mark in studentMarks){
                individualMarks[mark]++;
            }
            for(int i = 0; i< individualMarks.Length; i++){
                if (individualMarks[i] > 0){
                    Console.Write($"Mark {i}: {individualMarks[i]} student(s)\n");
                }
            }

        }

        public static void Answer5()
        {
            int[] studentmarks = new int[10];
            Console.WriteLine("\nEnter 10 marks of students: ");
            for(int i = 0; i< studentmarks.Length; i++)
            {
                bool isCorrect = false;
                while (!isCorrect)
                {
                    Console.Write($"Student-{i+1}: ");
                    if(int.TryParse(Console.ReadLine(), out int parsedValue))
                    {
                        if(parsedValue < 0 || parsedValue > 100)
                        {
                            Console.WriteLine("Enter Number between 0 to 100!");
                        }
                        else
                        {
                            studentmarks[i] = parsedValue;
                            isCorrect = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input! Enter number between 0 to 100");
                    }
                }

            }
            Console.WriteLine("Number of students as per percentage: ");
            int[] rangeCounts = new int[10]; // range for 10

            foreach(int mark in studentmarks)
            {
                if(mark <= 10)
                {
                    rangeCounts[0]++;
                }else if(mark <= 20)
                {
                    rangeCounts[1]++;
                }else if (mark <= 30)
                {
                    rangeCounts[2]++;
                }
                else if(mark <= 40)
                {
                    rangeCounts[3]++;
                }
                else if (mark <= 50)
                {
                    rangeCounts[4]++;
                }
                else if(mark <= 60)
                {
                    rangeCounts[5]++;
                }else if(mark <= 70)
                {
                    rangeCounts[6]++;
                }
                else if(mark <= 80)
                {
                    rangeCounts[7]++;
                }else if(mark <= 90)
                {
                    rangeCounts[8]++;
                }else if (mark <= 100)
                {
                    rangeCounts[9]++;
                }
            }

            Console.WriteLine($"0% to 10% {rangeCounts[0]} student(s)");
            Console.WriteLine($"11% to 20% {rangeCounts[1]} student(s)");
            Console.WriteLine($"21% to 30% {rangeCounts[2]} student(s)");
            Console.WriteLine($"31% to 40% {rangeCounts[3]} student(s)");
            Console.WriteLine($"41% to 50% {rangeCounts[4]} student(s)");
            Console.WriteLine($"51% to 60% {rangeCounts[5]} student(s)");
            Console.WriteLine($"61% to 70% {rangeCounts[6]} student(s)");
            Console.WriteLine($"71% to 80% {rangeCounts[7]} student(s)");
            Console.WriteLine($"81% to 90% {rangeCounts[8]} student(s)");
            Console.WriteLine($"91% to 100% {rangeCounts[9]} student(s)");
        }


        // ----------- Driver code -----------
        static void Main(string[] args)
        {


            // Array assignment questions
            // Assignment 1: Design an algorithm to accept 10 integer elements for an array and print the sum of all the elements.
            //int[] ints = new int[10];
            //Console.WriteLine("Enter 10 integers:");
            //for (int i = 0; i < ints.Length; i++)
            //{
            //    Console.Write($"Element {i + 1}: ");
            //    string temp = Console.ReadLine();
            //    ints[i] = int.Parse(temp);
            //}
            //Console.WriteLine("The sum of the elements is: " + SumOfArray(ints));


            //--------------------------------------------

            // Assignment 2: Design an algorithm to accept 20 integer elements for an array and print the maximum 3 and minimum 3 elements from the array.
            // Note: Sorting of array elements are not expected as part of this activity.
            Answer2();

            //--------------------------------------------

            // Assignment 3 :Design an algorithm to accept 10 integer elements for an array and then rearrange the elements in the array in reverse order. The reversed array must be displayed as output.
            //Answer3();

            //--------------------------------------------

            // Assignment 4:Design an algorithm which accepts a set of N (consider N to be 30) student's examination marks (in the range of 0 to 100). Then make a count of the number of students that obtain each possible mark (i.e., count of how many students scored 0, count of how many students scored 1, .... till count of how many students scored 100).

            //int n = 10;
            //Answer4(n);

            //--------------------------------------------

            //Assignment 5: Modify the algorithm written in Activity 4 in order to get count of students in a specific range of marks as defined below.
            //Range of marks:
            //0 to 10 %
            //11 % to 20 %
            //;
            //;
            //;
            //91 % to 100 %
            //Answer5();

            // -------------------------------------------

            




            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}