using System.ComponentModel;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program { 
    
    public static void Main(string[] args)
    {
        // 1)Write a program to print all number from 1 to 100
        //Console.WriteLine("print all number from 1 to 100");
        //for(int i= 1;i<=100;i++)
        //{
        //    if (i < 100)
        //    {
        //    Console.Write(i + ",");
        //    }
        //    else
        //    {
        //        Console.Write(i);
        //    }
        //}

        //2)Write a program to print alternate number from 1 to 99
        //for(int i = 1;i < 100; i+=2)
        //{
        //    if(i < 99)
        //    {
        //        Console.Write(i + ",");
        //    }
        //    else
        //    {
        //        Console.Write(i);
        //    }
        //}

        //3)Write a program to print all numbers backward from 100 to 1 i.e.100,99,98....
        //for(int i = 100; i >= 1; i--)
        //{
        //    Console.Write(i);
        //    if(i > 1)
        //    {
        //        Console.Write(", ");
        //    }
        //}

        //4)Write a program to print all numbers backward from 100 to 1 by skipping 2 number i.e.100,97,94....Console.WriteLine("\nPress any key to exit...");

        for(int i = 100;i > 0; i-=3)
        {
            Console.Write(i);
            if(i -2> 0)
            {
                Console.Write(", ");
            }
        }

        Console.ReadLine();
    }
}