public class RandomHelper
{ 
    public static void randint(int n1, int n2)
    {
        Random random = new Random();

        int min = Math.Min(n1, n2);
        int max = Math.Max(n1,n2);

        int randomNum = random.Next(min, max + 1);

        Console.WriteLine($"Random number between {n1} & {n2} is {randomNum}");
    }

    public static void randomdouble(int n1, int n2)
    {
        Random rand = new Random();

        double min = Math.Min(n1, n2);
        double max = Math.Max(n1, n2);

        // Gives fraction number b/w 0.0 to 1.0
        double randomDoubleFraction = rand.NextDouble();

        double randomNumDouble = min + (randomDoubleFraction * (min-max));
        Console.WriteLine($"Random number between {n1} & {n2} is {randomNumDouble}");
    }
}
class Program {
    public static void Main(string[] args)
    {
        Console.WriteLine("enter two numbers: ");
        bool isValid = false;
        while (!isValid)
        {
            Console.Write("Enter first number: ");
            if (int.TryParse(Console.ReadLine(), out int n1))
            {
                Console.Write("Enter second number: ");  
                if (int.TryParse(Console.ReadLine(), out int n2)){
                    RandomHelper.randint(n1, n2);
                    RandomHelper.randomdouble(n1, n2);
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Enter Valid Second Number!");
                }
            }
            else
            {
                Console.WriteLine("Enter Valid First Number!");
            }
        }
        Console.WriteLine("Exit...");
        Console.ReadLine();
    }


    
}