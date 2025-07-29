// implement the hands-on -1 using Sortedlist being EmployeeID as key

using System;
using System.Collections.Generic;

class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }

    public Employee(int id, string name, string dep){
        EmployeeId = id;
        Name = name;
        Department = dep;

    }
    public override string ToString()
    {
        return $"ID: {EmployeeId}, Name: {Name}, Deparment: {Department}";
    }
}

class Program
{
    public static void Main(String[] args)
    {
        SortedList<int, Employee> newEmp = new SortedList<int, Employee>();

        



        newEmp.Add(102, new Employee(102, "Prashant", "IT"));
        newEmp.Add(109, new Employee(109, "Rahul", "IT"));
        newEmp.Add(101, new Employee(101, "Kundan", "Software"));
        
        

        Console.WriteLine("Employee Details: in sorted order as per id.");
        foreach(KeyValuePair<int, Employee> kvp in newEmp)
        {
            Console.WriteLine(kvp.Value);
        }

        Console.WriteLine(new string('-',70));

        // problem-2: Modify hands-on 1 with Generic List
        List<Employee> employees = new List<Employee>();

        employees.Add(new Employee(102, "Prashant", "IT"));
        employees.Add(new Employee(109, "Rahul", "IT"));
        employees.Add(new Employee(101, "Kundan", "Software"));

        Console.WriteLine("Employee Details in a List.");
        foreach(Employee emp in employees)
        {
            Console.WriteLine($"{emp.EmployeeId}: {emp.Name} of Department: {emp.Department}");
        }


        Console.ReadLine();




    }
}