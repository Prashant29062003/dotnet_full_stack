class Program
{
     // Single inheritance
    class Animal
    {
        public void speak() => Console.WriteLine("Animal Sound");
    }
    class Dog : Animal
    {
        public void speak() => Console.WriteLine("Dog barks");
    }

    // multilevel inheritance
    class mammal : Animal
    {
        public void Breathe() => Console.WriteLine("Breathing...");
    }
    class Cat : mammal
    {
        public void speak() => Console.WriteLine("Cat meow.");
    }
    // Herarchial inheritance
    class Vehicle
    {
        public void Start() => Console.WriteLine("Starting vehicle...");
    }

    class Car : Vehicle
    {
        public void Drive() => Console.WriteLine("Driving car...");
    }

    class Bike : Vehicle
    {
        public void Ride() => Console.WriteLine("Riding bike...");
    }


    public static void Main(string[] args)
    {

    }
}