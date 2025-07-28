using System;

namespace Conditionals
{
    public class UserRegistrationRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
    }

    public class UserService
    {
        public string RegisterUser(UserRegistrationRequest request)
        {
            if (string.IsNullOrEmpty(request.UserName) || request.UserName.Length < 3)
            {
                return "Username must be at least 3 characters or more.";
            }
            else if (string.IsNullOrEmpty(request.Password) || request.Password.Length < 6)
            {
                return "Password must be at least 6 characters or more.";
            }
            else if (request.Password != request.ConfirmPassword)
            {
                return "Passwords do not match.";
            }
            else if (string.IsNullOrEmpty(request.Email) || !request.Email.Contains("@"))
            {
                return "Email must be a valid email address that contains Symbol '@'";
            }
            else if (request.Age < 18)
            {
                return "You must be at least 18 years old to register.";
            }
            else
            {
                return "User registered successfully!";
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- User Registration ----");

            //1. Create an instance of request model
            UserRegistrationRequest newUser = new UserRegistrationRequest();

            //2. Get input from user
            Console.Write("Enter Username:");
            string uName = Console.ReadLine();

            while (string.IsNullOrEmpty(uName) || uName.Length < 3)
            {
                Console.WriteLine("Invalid input. Username must be at least 3 characters or more.");
                Console.Write("Enter Username:");
                uName = Console.ReadLine();
            }
            newUser.UserName = uName;

            Console.Write("Enter Password:");
            newUser.Password = Console.ReadLine();

            Console.Write("Confirm Password:");
            newUser.ConfirmPassword = Console.ReadLine();

            Console.Write("Enter Email:");  
            string email = Console.ReadLine();

            while (string.IsNullOrEmpty(email) || !email.Contains("@gmail.com"))
            {
                Console.WriteLine("Invalid input. Please enter a valid email address that contains '@'.");
                Console.Write("Enter Email:");
                email = Console.ReadLine();
            }

            Console.Write("Enter Age:");
            string ageInput = Console.ReadLine();
            int age;
            
            while(!int.TryParse(ageInput, out age))
            {
                Console.WriteLine("Invalid input. Please enter a Number.");
                Console.Write("Enter Age:");
                ageInput = Console.ReadLine();

            }

            newUser.Age = age;

            //3. Create an instance of UserService
            UserService userService = new UserService();

            //4. Call RegisterUser method and get the result message
            string registerationResult = userService.RegisterUser(newUser);

            //5. Display the result message
            Console.WriteLine("\n--- Registration Result ---");
            Console.WriteLine(registerationResult);

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}