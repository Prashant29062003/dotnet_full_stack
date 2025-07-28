using System.Runtime.Intrinsics.Arm;

namespace HelloWorld;

class Car
{
    // Properties
    public int modelYear;
    public string carName;
    public string carType;
    public double price;

    // Methods
    public void DriveCar()
    {
        Console.WriteLine("Car is driving");
    }

    public void ApplyBrake()
    { 
        Console.WriteLine("Car is applying brakes");
    }

    public void GetDetails()
    {
        Console.WriteLine($"{this.carName}: ${this.carType} \n price: ${this.price} \n model Year: ${this.modelYear}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        var name = Console.ReadLine();
        var currentDate = DateTime.Now;
        Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");

        Console.WriteLine("Car: ");
        Car myCar = new Car();
        myCar.modelYear = 2003;
        myCar.carName = "ferrari";
        myCar.carType = "electric";
        myCar.price = 2040.68;

        myCar.DriveCar();
        myCar.GetDetails();

        


        Console.WriteLine($"{Environment.NewLine}Press any key to exit...");
        Console.ReadKey();
    }
}