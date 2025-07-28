namespace Operators;

using System;

class Exercise {
    // Write a simple program that accepts two numbers num1 and num2.
    //  Assign num1 to num2 in two scenario:
    //      1) Assign num1 to num2 by pre-incrementing num1 and observe the output
    //      2) Assign num1 to num2 by post-incrementing num1 and observe the output
    //      3) Swap both value

    public void Exercise_1()
    {
        Console.Write("Enter the firsrt number (num1): ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number (num2): ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"You entered a = {num1} and b = {num2}");
        Console.WriteLine("=========================================");

        // Pre-incrementing num1
        int preIncrementedNum1 = ++num1; // Pre-increment
        num2 = preIncrementedNum1; // Assigning pre-incremented num1 to num2
        Console.WriteLine($"Pre-incremented num1: {num2}");

        int postIncrementedNum2 = num1++; // Post-increment
        num2 = postIncrementedNum2; // Assigning post-incremented num1 to num2
        Console.WriteLine($"Pre-incremented num1: {num2}");

    }
}

class Program { 
    static void Main(string[] args) {

        Exercise exercise = new Exercise();
        exercise.Exercise_1();


        Console.WriteLine("Demonstrating C# Operators");
        Console.WriteLine("=========================================");

        Console.WriteLine("This program demonstrates various types of operators in C# including arithmetic, relational, logical, bitwise, assignment, unary, ternary, null-coalescing, conditional, type comparison, instance of, is, and as operators.");
        Console.WriteLine("=========================================");

        Console.Write("Enter the firsrt number (a): ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number (b): ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"You entered a = {a} and b = {b}");
        Console.WriteLine("=========================================");

        // -----------------------------------  Arithmetic Operators ----------------------------------- 
        //int a = 10;
        //int b = 5;

        Console.WriteLine($"Performing arithmetic operations on a = {a} and b = {b}\n");

        int c = a + b; // Addition
        int d = a - b; // Subtraction
        int e = a * b; // Multiplication
        int f = a / b; // Division
        int g = a % b; // Modulus
        Console.WriteLine($"Addition: {c}");
        Console.WriteLine($"Subtraction: {d}");
        Console.WriteLine($"Multiplication: {e}");
        Console.WriteLine($"Division: {f}");
        Console.WriteLine($"Modulus: {g}");

        // -----------------------------------  Relational Operators ----------------------------------- 
        Console.WriteLine($"Performing relational operations on a = {a} and b = {b}\n");
        bool isEqual = a == b; // Equal to
        bool isNotEqual = a != b; // Not equal to
        bool isGreater = a > b; // Greater than
        bool isLess = a < b; // Less than
        bool isGreaterOrEqual = a >= b; // Greater than or equal to
        bool isLessOrEqual = a <= b; // Less than or equal to
        Console.WriteLine($"Is Equal: {isEqual}");
        Console.WriteLine($"Is Not Equal: {isNotEqual}");
        Console.WriteLine($"Is Greater: {isGreater}");
        Console.WriteLine($"Is Less: {isLess}");
        Console.WriteLine($"Is Greater or Equal: {isGreaterOrEqual}");
        Console.WriteLine($"Is Less or Equal: {isLessOrEqual}");

        Console.WriteLine("=========================================");

        // -----------------------------------  Logical Operators ----------------------------------- 
        Console.WriteLine($"Performing logical operations with x = true and y = false\n");
        bool x = true;
        bool y = false;
        bool andResult = x && y; // Logical AND
        bool orResult = x || y; // Logical OR
        bool notResult = !x; // Logical NOT
        Console.WriteLine($"Logical AND: {andResult}");
        Console.WriteLine($"Logical OR: {orResult}");
        Console.WriteLine($"Logical NOT: {notResult}");

        Console.WriteLine("=========================================");

        // -----------------------------------  Bitwise Operators ----------------------------------- 
        Console.WriteLine($"Performing bitwise operations on bitA = 5 and bitB = 3\n");
        int bitA = 5; // 0101 in binary
        int bitB = 3; // 0011 in binary
        int bitwiseAnd = bitA & bitB; // Bitwise AND

        int bitwiseOr = bitA | bitB; // Bitwise OR

        int bitwiseXor = bitA ^ bitB; // Bitwise XOR

        int bitwiseNot = ~bitA; // Bitwise NOT
        int leftShift = bitA << 1; // Left shift
        int rightShift = bitA >> 1; // Right shift
        Console.WriteLine($"Bitwise AND: {bitwiseAnd}");
        Console.WriteLine($"Bitwise OR: {bitwiseOr}");
        Console.WriteLine($"Bitwise XOR: {bitwiseXor}");
        Console.WriteLine($"Bitwise NOT: {bitwiseNot}");
        Console.WriteLine($"Left Shift: {leftShift}");
        Console.WriteLine($"Right Shift: {rightShift}");
        Console.WriteLine("=========================================");

        // -----------------------------------  Assignment Operators ----------------------------------- 
        Console.WriteLine($"Performing assignment operations\n");
        int assignment = 10; // Simple assignment
        assignment += 5; // Add and assign
        assignment -= 3; // Subtract and assign
        assignment *= 2; // Multiply and assign
        assignment /= 4; // Divide and assign
        assignment %= 3; // Modulus and assign
        Console.WriteLine($"Assignment: {assignment}");
        Console.WriteLine("=========================================");

        // -----------------------------------  Unary Operators ----------------------------------- 
        Console.WriteLine($"Performing unary operations on x = {x}\n");
        int unaryValue = 5;
        unaryValue++; // Increment
        Console.WriteLine($"Unary Increment: {unaryValue}");
        unaryValue--; // Decrement
        Console.WriteLine($"Unary Decrement: {unaryValue}");
        int unaryNegation = -unaryValue; // Unary negation
        Console.WriteLine($"Unary Negation: {unaryNegation}");
        bool unaryNot = !x; // Unary NOT
        Console.WriteLine($"Unary NOT: {unaryNot}");
        Console.WriteLine("=========================================");

        //-----------------------------------  Ternary Operator -----------------------------------
        Console.WriteLine($"Finding maximum of a = {a} and b = {b} using Ternary Operator\n");
        int max = (a > b) ? a : b; // Ternary operator
        Console.WriteLine($"Max using Ternary Operator: {max}");
        Console.WriteLine("=========================================");

        //----------------------------------- Null-coalescing operator ----------------------------------- 
        Console.WriteLine($"Using Null-coalescing operator with nullable string\n");
        string? nullableString = null;
        string nonNullableString = nullableString ?? "Default Value"; // If nullableString is null, use "Default Value"
        Console.WriteLine($"Null-coalescing result: {nonNullableString}");
        Console.WriteLine("=========================================");



        //-----------------------------------  Conditional Operator ----------------------------------- 
        Console.WriteLine($"Using Conditional Operator to find maximum of a = {a} and b = {b}\n");
        int conditionValue = (a > b) ? a : b; // Conditional operator
        Console.WriteLine($"Conditional Operator Result: {conditionValue}");
        Console.WriteLine("=========================================");




        //-----------------------------------  Type Comparison Operator -----------------------------------
        //---------------------------------------------------------------------------------------------------------
        Console.WriteLine($"Using Type Comparison Operator to check if object is a string\n");
        object obj = "Hello, World!";
        if (obj is string str) {
            Console.WriteLine($"Type Comparison Result: {str}");
        } else {
            Console.WriteLine("Object is not a string.");
        }
        Console.WriteLine("=========================================");





        //-----------------------------------  Instance of Operator -----------------------------------
        Console.WriteLine($"Using Instance of Operator to check if object is an instance of string\n");
        if (obj is string) {
            Console.WriteLine("Object is an instance of string.");
        } else {
            Console.WriteLine("Object is not an instance of string.");
        }
        Console.WriteLine("=========================================");



        //-----------------------------------  Is Operator -----------------------------------
        Console.WriteLine($"Using Is Operator to check if object is not null\n");
        if (obj is not null) {
            Console.WriteLine("Object is not null.");
        } else {
            Console.WriteLine("Object is null.");
        }
        Console.WriteLine("=========================================");



        //-----------------------------------  As Operator -----------------------------------
        Console.WriteLine($"Using As Operator to cast object to string\n");
        if (obj is string asString) {
            Console.WriteLine($"As Operator Result: {asString}");
        } else {
            Console.WriteLine("Object cannot be cast to string using 'as' operator.");
        }
        Console.WriteLine("=========================================");

    }
}