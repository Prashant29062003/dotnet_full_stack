//emp name, id, designation , exp, salary

using System;
using System.Collections;

class Employee
{
    public string Name { get; set; }
    public int Id { get; set; }
    public string Designation { get; set; }
    public double Experience { get; set; }
    public double Salary { get; set; }
    public Employee(string name, int id, string designation, double experience, double salary)
    {
        Name = name;
        Id = id;
        Designation = designation;
        Experience = experience;
        Salary = salary;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, Id: {Id}, Designation: {Designation}, Experience: {Experience} years, Salary: ${Salary}");
    }
}

class program
{
    public static void Main(string[] args)
    {
        Hashtable employees = new Hashtable();

        // Adding emplyees (Boxing implementing)
        employees.Add(101, new Employee("Prashant", 101, "Software Engineer", 2.5, 1200000));

        employees.Add(102, new Employee("Amit", 102, "Data Scientist", 3.0, 1500000));
        employees.Add(103, new Employee("Bhavya", 103, "Product Manager", 4.0, 1800000));
        employees.Add(104, new Employee("Charan", 104, "DevOps Engineer", 3.5, 1600000));

        // Display specific employee details using key
        Console.WriteLine("Employee details for Id 102:");
        if (employees.ContainsKey(102))
        {
            Employee emp = (Employee)employees[102]; // Unboxing
            emp.Display();
        }
        else
        {
            Console.WriteLine("Employee with Id 102 not found.");
        }

    }
}

