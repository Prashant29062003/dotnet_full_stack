using System;

namespace Loops
{
    class Program { 

        public static void PrintHundNumbers()
        {
            Console.WriteLine("\n--- 1) Numbers from 1 to 100 ---");
            for (int i = 1; i <= 100;  i++)
            {
                if(i < 100)
                {
                    Console.Write(i + ", ");
                }
                else
                {
                    Console.Write(i);
                }
            }
        }

        public static void PrintAlternateNumbers()
        {
            Console.WriteLine("\n\n--- 2) Alternative Numbers from 1 to 99 ---");
            for (int i = 1; i<=99; i += 2)
            {
                if(i <= 97)
                {
                    Console.Write(i + ", ");
                }
                else
                {
                    Console.Write(i);   
                }
            }
            Console.WriteLine();
        }

        public static void PrintBackwardNumbers()
        {
            Console.WriteLine("\n\n--- 3)  Numbers from 100 to 1---");
            for (int i = 100; i > 0; i--)
            {
                if (i > 1)
                {
                    Console.Write(i + ", ");
                }
                else
                {
                    Console.Write(i);
                }
            }
        }
        public static void PrintBackAlternateNumbers()
        {
            Console.WriteLine("\n\n--- 4)  Numbers from 100 to 1 by skipping 2 numbers---");
            for (int i = 100; i > 0; i -= 3)
            {
                if (i - 3 >= 1)
                {
                    Console.Write(i + ", ");
                }
                else
                {
                    Console.Write(i);
                }
            }
        }
        public static void Main(string[] args)
        {
            //Looping Constructs


            //1)Write a program to print all number from 1 to 100
            PrintHundNumbers();

            //2)Write a program to print alternate number from 1 to 99
            PrintAlternateNumbers();

            //3)Write a program to print all numbers backward from 100 to 1 i.e.100,99,98....
            PrintBackwardNumbers();

            //4)Write a program to print all numbers backward from 100 to 1  by skipping 2 number i.e.100,97,94....
            PrintBackAlternateNumbers();
            Console.ReadLine();
        }
    }
}