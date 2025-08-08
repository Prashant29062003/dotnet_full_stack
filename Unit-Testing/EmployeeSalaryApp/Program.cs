public class Employee
{
    public string Name { get; set; }
    public double BaseSalary { get; set; }

    public double CalculateSalary(double bonus)
    {
        return BaseSalary + bonus;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Employee employee = new Employee();
        employee.Name = "John Doe";
        employee.BaseSalary = 50000;
        double bonus = 5000;
        double totalSalary = employee.CalculateSalary(bonus);
        Console.WriteLine($"Employee Name: {employee.Name}");
        Console.WriteLine($"Base Salary: {employee.BaseSalary}");
        Console.WriteLine($"Bonus: {bonus}");
        Console.WriteLine($"Total Salary: {totalSalary}");
        Console.WriteLine("Press any key to exit...");
        Console.ReadLine();
    }
}