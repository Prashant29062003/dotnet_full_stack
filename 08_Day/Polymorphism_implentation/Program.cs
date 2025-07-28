
class ShapesArea
{   
    public decimal Circle(decimal radius)
    {
        decimal pi = (decimal) Math.PI;
        return pi * (radius * radius);
    }

    public decimal Triangle(decimal b, decimal h)
    {
        return (decimal)(0.5) * (b * h);
    }

    public decimal Rectangle(decimal b, decimal h)
    {
        {
            return (b * h);
        }
    }
}

class UserMath
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    public decimal Multipy(decimal a, decimal b)
    {
        return (a * b);
    }

    public decimal Multipy(decimal a, decimal b, decimal c)
    {
        return (a * b * c);
    }

    public decimal Divide(decimal a, decimal b)
    {
        return (a / b);
    }

    public decimal Divide(decimal a, decimal b, decimal c)
    {
        return (a / b / c);
    }

    public decimal Subtract(decimal a, decimal b)
    {
        return (a - b);
    }

    public decimal Subtract(decimal a, decimal b, decimal c)
    {
        return (a - b - c);
    }

}

class Program
{
    
    public static void Main(string[] args)
    {
        // Shapes area
        ShapesArea area = new();
        decimal circleArea = area.Circle(34);
        decimal rectangleArea = area.Rectangle(10, 20);
        decimal triangleArea = area.Triangle(10, 20);

        Console.WriteLine(Math.Round(circleArea, 2));
        Console.WriteLine(Math.Round(rectangleArea, 2));
        Console.WriteLine(Math.Round(triangleArea, 2));


        // user math
        UserMath userMath = new();

        // Add()
        int add1 = userMath.Add(2, 3);
        int add2 = userMath.Add(2, 3,6);

        Console.WriteLine("add 2 numbers: " + add1);
        Console.WriteLine("add 3 numbers: " + add2);

        // Multiply()
        decimal mul1 = userMath.Multipy(2, 3);
        decimal mul2 = userMath.Multipy(2, 3, 6);

        Console.WriteLine("Multiplicaction 2 numbers: " + mul1);
        Console.WriteLine("Multiplicaction 3 numbers: " + mul2);

        // Divide()
        decimal div1 = userMath.Divide(2, 3);
        decimal div2 = userMath.Divide(2, 3, 6);

        Console.WriteLine("Division 2 numbers: " + Math.Round(div1,2));
        Console.WriteLine("Division 3 numbers: " + Math.Round(div2,2));

        // Subtact()
        decimal sub1 = userMath.Subtract(2, 3);
        decimal sub2 = userMath.Subtract(2, 3, 6);

        Console.WriteLine("Subtraction 2 numbers: " + sub1);
        Console.WriteLine("Subtraction 3 numbers: " + sub2);

        Console.ReadLine();
    }
}