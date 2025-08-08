using System;
using System.Reflection;


namespace ReflectionExample
{
    class myReflection
    {
        public int a {  get; set; }
        public int b { get; set; }

        public static void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Addition of {0} & {1}  is {2}", a,b,c);    
        }

        public static void Sub(int a, int b)
        {
            int c = a - b;
            Console.WriteLine("Subtraction of {0} & {1}  is {2}", a, b, c);
        }
        public static void Mul(int a, int b)
        {
            int c = a * b;
            Console.WriteLine("Multiplication of {0} & {1} is {2}", a, b,c);
        }
    }

   class Program
    {
        static void Main(string[] args)
        {
            Type t = typeof(myReflection);
            PropertyInfo[] prop = t.GetProperties();
            Console.WriteLine("Properties of {0}", t.Name);
            foreach (var p in prop)
            {
                Console.WriteLine($"{p.Name}: {p.PropertyType.Name}");
            }

            MethodInfo[] prop2 = t.GetMethods();
            Console.WriteLine("Methods: ");
            Console.WriteLine("");

            foreach(var p in prop2)
            {
                //Console.WriteLine(new string('-', 70));
                Console.WriteLine($"method:\t{p.Name}");
                Console.WriteLine($"attributes:\t {p.Attributes}");
                Console.WriteLine(new string('-', 70));
            }
            Console.ReadLine();
        }
    }
}