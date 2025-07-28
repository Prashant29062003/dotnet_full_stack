// Create a class called Person
//Populate the class with below private fields
//1. firstname as string
//2. lastname as string
//3. email as string
//DateOfBirth as DateTime


using System;

public class Person
{
    private string firstname;
    private string lastname;
    private string email;
    private DateTime dateOfBirth;


    int age;
    public Person(string firstname, string lastname, string email, DateTime dateOfBirth)
    {
        this.firstname = firstname;
        this.lastname = lastname;
        this.email = email;
        this.dateOfBirth = dateOfBirth;
    }

    public string Firstname
    {
        get { return firstname; }
        set { firstname = value; }
    }
    public string Lastname
    {
        get { return lastname; }
        set { lastname = value; }
    }
    public string Email
    {
        get { return email; }   
        set { email = value; }
    }
    public DateTime DateOfBirth
    {
        get { return dateOfBirth; }
        set { dateOfBirth = value; }
    }


    public int Age
    {
        get
        {
            DateTime today = DateTime.Now;
            int age = today.Year - dateOfBirth.Year;
            if (dateOfBirth > today.AddYears(-age)) age--;
            return age; 

        }
    }
    public bool IsAdult => Age >= 18;

    public bool IsBirthDay => dateOfBirth.Day == DateTime.Today.Day && dateOfBirth.Month == DateTime.Today.Month;

    public void DisplayDetails()
    {
        Console.WriteLine($"Hello! {Firstname} {Lastname}.");
        Console.WriteLine($"Your email: {Email}.");
        Console.WriteLine($"Your age is {Age}");

        if (IsAdult) Console.WriteLine("You are an adult.");
        else Console.WriteLine("You are not adult yet.");

        if (IsBirthDay) Console.WriteLine($"Happy Birthday! {Firstname}. Be a nice day!");
        Console.WriteLine("----------------------------------");
    }
}
//Employee class 
public class Employee : Person
{
    double salary;

    public Employee(string firstname, string lastname, string email, DateTime dob, double salary) : base(firstname, lastname, email, dob)
    {
        this.salary = salary;
    }

    public double Salary
    {
        get => salary; 
        set => salary = value;
    }

    public void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Your salary is {salary:C}");
        Console.WriteLine("----------------------------------");
    }
}



// Ipayable interface
interface Ipayable
{
    void CalculatePay();
}

// HourlyEmployee
public class HourlyEmployee : Person, Ipayable
{
    private double hoursWorked;
    private double payPerHours;
    public HourlyEmployee(string firstname, string lastname, string email, DateTime dob, double hoursWorked, double payPerHours) : base(firstname, lastname, email, dob)
    {
        this.hoursWorked = hoursWorked;
        this.payPerHours = payPerHours;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("\n\n--- Hourly Employee ---");
        base.DisplayDetails();
        Console.WriteLine($"Hours Worked: {hoursWorked}");
        Console.WriteLine($"Pay Per Hour: {payPerHours}");
        CalculatePay();
        Console.WriteLine("----------------------------------\n\n");
    }
    public void CalculatePay()
    {
        double totalPay = hoursWorked * payPerHours;
        Console.WriteLine($"Your total salary is {totalPay}");
    }
    

}

public class PermanentEmployee : Person, Ipayable
{
    double HRA;
    double DA;
    double Tax;
    double NetPay;
    double TotalPay;

    public PermanentEmployee(string firstname, string lastname, string email, DateTime dob, double HRA,double DA, double Tax) : base(firstname,lastname, email, dob)
    {
        this.HRA = HRA;
        this.DA = DA;
        this.Tax = Tax;
        this.NetPay = NetPay;
        this.TotalPay = TotalPay;
    }

    public void DisplayDetails()
    {
        Console.WriteLine("\n\n--- Premanent Employee ---");
        base.DisplayDetails();
        CalculatePay();
        Console.WriteLine("----------------------------------");

    }
    public void CalculatePay()
    {
        double grossPay = HRA + DA;
        double netPay = grossPay - Tax;
        Console.WriteLine($"Gross Pay: {grossPay:C}");
        Console.WriteLine($"Tax: {Tax:C}");
        Console.WriteLine($"Net Pay: {netPay:C}");
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Employee emp1 = new("Prashant", "Kumar", "prash23@gmail.com", new DateTime(2003, 7, 21), 2000000);
        HourlyEmployee hourEmp2 = new("Prashant", "Kumar", "prash23@gmail.com", new DateTime(2003, 7, 21), 120, 204.54);
        PermanentEmployee permanentEmp3 = new("Prashant", "Kumar", "prash23@gmail.com", new DateTime(2003, 7, 21), 15000, 12000, 3000);


        emp1.DisplayDetails();
        hourEmp2.DisplayDetails();
        permanentEmp3.DisplayDetails();


        Console.WriteLine("Press any key to exit...");
        Console.ReadLine();
    }
}