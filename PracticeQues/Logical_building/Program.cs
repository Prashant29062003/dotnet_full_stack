using System;

class Program
{
    public static bool isEven(int n)
    {
        int num = Math.Abs(n);
        if (num % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public static int lastDigit(int num)
    {
        int n = Math.Abs(num);
        return n % 10;
    }

    public static int secondLastDigit(int num)
    {
        int n = Math.Abs(num);
        if(n < 10)
        {
            return -1;// No second last digit
        }
        else
        {
            return ((n / 10) % 10);
        }
    }
    public static int swapLastTwo(int num)
    {
        bool isNegative = num < 0;
        int n = Math.Abs(num);

        if(n< 10)
        {
            return num;
        }

        int last = n % 10;
        int secondLast = (n / 10) % 10;
        int rest = n / 100;

        int swapped = (rest * 100) + (last * 10) + secondLast;

        return isNegative ? -swapped : swapped;
        
    }

    public static int ReverseNumber(int num)
    {
        int n = Math.Abs(num);
        int newNum = 0;
        while (n> 0)
        {
            int last = n % 10;
                n = n / 10;
                newNum = newNum * 10 + last;
        }
        return newNum;
    }

    public static bool IsPalindrome(int num)
    {
        int n = Math.Abs(num);
        int reversed = 0;
            if (n < 10)
            {
                return false;
            }
        while (n > 0)
        {
            int last = n % 10;
            reversed = reversed * 10 + last;
            n = n / 10;
        }
        return reversed == Math.Abs(num);
    }

    public static int CountDigit(int num)
    {
        int count = 0;
        int n = Math.Abs(num);
        while(n > 0)
        {
            ++count;
            n /= 10;
        }
        return count;
    }

    public static int MirrorLastToFront(int num)
    {
        int n = Math.Abs(num);
        if (n < 10)
        {
            return num < 0 ? -n : n; // No change for single digit numbers
        }
        int lastDigit = n % 10;
        int rest = n / 10;
        int mirrored = lastDigit * (int)Math.Pow(10, CountDigit(rest)) + rest;

        return num < 0 ? -mirrored : mirrored;

    }
    public static int sumLastDigits(int num1,int num2)
    {
        int n1 = Math.Abs(num1);
        int n2 = Math.Abs(num2);

        return (n1 % 10) + (n2 % 10);
    }

    public static int sumEvenDigits(int num)
    {
        int n = Math.Abs(num);
        int sum = 0;
        while(n > 0)
        {
            int last = n % 10;
            if(last % 2 == 0)
            {
                sum += last;
            }
            n /= 10;
        }
        return sum;
    }

    public static void Fibonacci(int num)
    {
        int a = 0, b = 1;
        Console.Write("Fibonacci Series: ");
        Console.Write(a, ", ", b);
        for(int i = 2; i <= num; i++)
        {
            int c = a + b;
            Console.Write(", " + c);
        }
    }
    public static void Main(string[] args)
    {
        
            int n = -16;
        //    Console.WriteLine(isEven(n));
        //Console.WriteLine(lastDigit(n));
        //Console.WriteLine(secondLastDigit(n));
        //Console.WriteLine(sumLastDigits(n, 1234));
        //Console.WriteLine(swapLastTwo(1238374));
        Console.WriteLine(ReverseNumber(123040));
        //Console.WriteLine(IsPalindrome(12321));
        //Console.WriteLine(CountDigit(1234567890));
        //Console.WriteLine(MirrorLastToFront(12345));
        //Console.WriteLine(sumEvenDigits(1234567890));
        Fibonacci(10);
        Console.ReadLine();
    }
}