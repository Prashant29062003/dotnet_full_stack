using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace DelegateConcepts
{
    public delegate void greet(string name);

    public delegate void Notify();
    public class Program
    {
            public static void Greeting(string name)
            {
                Console.WriteLine("Hello "+ name+ "! How are you?");
            }
        public static void Main(string[] args)
        {
            greet GreetDelegate = new greet(Greeting);
            GreetDelegate("Prashant Kumar");


            static void SayHello()
            {
                Console.WriteLine("Hello");
            }
            static void SayWelcome()
            {
                Console.WriteLine("Welcome");

            }
            // two method uses
            Notify notify = SayHello;
            notify += SayWelcome;
            notify();


            // Delegate (System.Delegate class) --> Base class for all delegate types in .NET.
            Delegate[] methodList = notify.GetInvocationList();


            ((Notify)methodList[0])();

            Console.ReadLine();

        }

    }
}