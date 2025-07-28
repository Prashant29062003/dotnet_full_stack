using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;


class Program
{
    public static void Main(string[] args)
    {
        // Q4.Create a Console Application to accept the side of a square and print the area of the square
        //Console.Write("Enter the side of a Square: ");
        //if(double.TryParse(Console.ReadLine(), out double side))
        //{
        //    if(side >= 0)
        //    {
        //        double area = side * side;
        //        Console.WriteLine($"Area of a Sqare {area}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Enter Positive Number!");

        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Enter Valid Number!");

        //}

        //Console.WriteLine("------------------------------------------------");

        //Q5.implement the arithmetic operation.
        //double val1 = 20.5;
        //double val2 = 5.2;

        //Console.WriteLine($"Value 1: {val1}, Value 2: {val2}");
        //Console.WriteLine($"Addition: {val1 + val2}");
        //Console.WriteLine($"Subtraction: {val1 - val2}");
        //Console.WriteLine($"Multiplication: {val1 * val2}");
        //Console.WriteLine($"Division: {val1 / val2}");
        //Console.WriteLine($"Modulus (remainder for integers): {10 % 3}");
        //Console.WriteLine("--------------------------------------------------");

        //.Write a simple program that accepts two numbers num1 and num2.
        //Assign num1 to num2 in two scenario:
        //i)Assign num1 to num2 by pre-incrementing num1 and observe the output
        //ii)Assign num1 to num2 by post-incrementing num1 and observe the output
        //iii) Swap both value
        //int num1 = 5;
        //int num2;
        //Console.WriteLine($"Initial values for pre-increment: num1 = {num1}");
        //num2 = ++num1; // num1 is incremented first, then assigned to num2
        //Console.WriteLine($"After pre-increment: num1 = {num1}, num2 = {num2}"); // num1=6, num2=6

        //int num3 = 5;
        //int num4;
        //Console.WriteLine($"Initial values for post-increment: num1 = {num3}");
        //num4 = num3++; // num3 is assigned to num4 first, then incremented
        //Console.WriteLine($"After post-increment: num1 = {num3}, num2 = {num4}"); // num1=6, num2=5

        //// iii) Swap both value
        //Console.WriteLine("\n--- Swapping Values ---");
        //int swapNum1 = 10;
        //int swapNum2 = 20;
        //Console.WriteLine($"Before swap: swapNum1 = {swapNum1}, swapNum2 = {swapNum2}");


        //int temp = swapNum1;
        //swapNum1 = swapNum2;
        //swapNum2 = temp;
        //Console.WriteLine($"After swap (using temp): swapNum1 = {swapNum1}, swapNum2 = {swapNum2}");

        // Reset values for next swap method
        //swapNum1 = 30;
        //swapNum2 = 40;
        //Console.WriteLine($"Before swap: swapNum1 = {swapNum1}, swapNum2 = {swapNum2}");

        //// Method 2: Using arithmetic operations (for integers only, be careful with overflow)
        //swapNum1 = swapNum1 + swapNum2; // swapNum1 is 70
        //swapNum2 = swapNum1 - swapNum2; // swapNum2 is 70 - 40 = 30 (original swapNum1)
        //swapNum1 = swapNum1 - swapNum2; // swapNum1 is 70 - 30 = 40 (original swapNum2)
        //Console.WriteLine($"After swap (using arithmetic): swapNum1 = {swapNum1}, swapNum2 = {swapNum2}");
        //Console.WriteLine("--------------------------------------------------");


        Console.WriteLine("\n--- ARRAY AND ARRAYLIST BASED QUESTIONS ---");
        //1. create an array and take input from user
        //int arrSize;
        //Console.Write("Enter the Size of the array: ");
        //if(int.TryParse(Console.ReadLine(), out  arrSize)){
        //    if (arrSize <= 0){
        //        Console.WriteLine("Array size must be a positive integer.");
        //        return;
        //    }
        //    int[] myArr = new int[arrSize];
        //    Console.WriteLine($"Enter {arrSize} Elements of array: ");
        //    for(int i = 0; i < arrSize; i++){
        //        bool isValid = false;
        //        while (!isValid){
        //            Console.Write($"Element {i + 1}: ");
        //            if(int.TryParse(Console.ReadLine(), out int elem)){
        //                myArr[i] = elem;
        //                isValid = true;
        //            }
        //            else{
        //                Console.WriteLine("Enter valid number!");
        //            }
        //        }
        //    }
        //    Console.Write("Your Array Elements are: ");
        //    foreach(int i in myArr){
        //        Console.Write(i + " ");
        //    }
        //    Console.WriteLine();
        //}
        //else{
        //    Console.WriteLine("Invalid input. Please enter a valid number!");
        //}
        //Console.WriteLine("--------------------------------------------------");


        //Q12.Write a program that finds a number of element in an array with out using built in function.
        //int[] myArr2 = { 23, 12, -47, 0, 23, 85 };
        //int count = 0;
        //foreach(int i in myArr2)
        //{
        //    count++;
        //}
        //Console.Write($"Lenth of Array: {count}\n");

        //Q13.Write a program to accept 10 integers to an array and perform the below action:
        //1) print the element in descending order
        //2)find the min value, max value entered
        //3)Print the sum we get after adding all the number in the array
        int sizeOfmyArr3 = 10;
        int[] myArr3 = new int[sizeOfmyArr3];
        Console.WriteLine($"Enter {sizeOfmyArr3} Elements of Array: ");
        for(int i = 0; i < 10; i++)
        {
            bool isValid = false;
            while (!isValid)
            {
                Console.Write($"Enter Element-{i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int el))
                {
                    myArr3[i] = el;
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Enter Valid Integer!");
                }
            }
        }

        Console.WriteLine("\nOriginal Q13 Array: " + string.Join(", ", myArr3));

        Console.WriteLine("Descending order of Array: ");
        //1) print the element in descending order
        for (int i = 0; i < myArr3.Length; i++){
            for(int j = 0; j< myArr3.Length - 1 - i; j++){
                if (myArr3[j] < myArr3[j + 1]){
                    int temp = myArr3[j];
                    myArr3[j] = myArr3[j + 1];
                    myArr3[j + 1] = temp;
                }
            }
        }
        Console.WriteLine(String.Join(", ", myArr3));
        //2)find the min value, max value entered
        int minVal = myArr3[0];
        int maxVal = myArr3[0];
        for(int i = 0;i< myArr3.Length; i++){
            if (myArr3[i] < minVal){
                minVal = myArr3[i];
            }else if (myArr3[i] > maxVal){
                maxVal = myArr3[i];
            }
        }
        Console.WriteLine($"\n   Min Value : {minVal}");
        Console.WriteLine($"   Max Value : {maxVal}");

        //3)Print the sum we get after adding all the number in the array
        int sum = 0;
        foreach(int i in myArr3){
            sum += i;
        }
        Console.WriteLine($"\nSum of the array is {sum}");




        Console.WriteLine("Press any key to exit...");
        Console.ReadLine();

    }
}