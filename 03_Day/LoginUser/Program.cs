using System;

namespace LoginUser
{
    class Program
    {
        public static void Main(String[] args)
        {
            // User Login Confirmation if wrong more than 3 then out of this

            string name = "Prashant Kumar";
            string pass = "123abc";

            string userName;
            string userPass;
            int atempt = 3;


            Console.WriteLine("\n--- User Login ---");



            

            Console.Write("Enter You name: ");
            userName = Console.ReadLine();
            Console.Write("Enter your PassWord: ");
            userPass = Console.ReadLine();

            while(userName != name || userPass != pass)
            {
                atempt -= 1;
                Console.Write($"Please enter the correct Name or password you have {atempt} atempt left.\n");
                if(atempt <= 0)
                {
                    break;
                }
                
                Console.Write("\n\nEnter You name: ");
                userName = Console.ReadLine();
                Console.Write("Enter your PassWord: ");
                userPass = Console.ReadLine();

            }
            

            if(atempt >= 3)
            {
                Console.WriteLine("Your Chances are finished to login.");
            }
            else
            {
                Console.WriteLine("--- Login Success! --");
            }

            Console.WriteLine("Enter any key to close...");
            Console.ReadLine();
            
        }
    }
}