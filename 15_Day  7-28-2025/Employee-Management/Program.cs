using System;
using System.Collections;

class Employee
{
    public string EmployeeName { get; set; }
    public int EmployeeId { get; set; }
    public double Salary { get; set; }
    public Employee(string name, int id, double salary)
    {
        EmployeeName = name;
        EmployeeId = id;
        Salary = salary;
    }

}

class EmployeeDAL
{
    ArrayList employees = new ArrayList();

    public bool AddEmployee(Employee e)
    {
        foreach(Employee emp in employees)
        {
            if(emp.EmployeeId == e.EmployeeId)
            {
                Console.WriteLine("Employee with this ID already exists.");
                return false;
            }
            else
            {
                employees.Add(e);
            }
        }
    }

    public bool DeleteEmployee(int id)
    {
        foreach(Employee emp in employees){
            if(emp.EmployeeId != id)
            {
                Console.WriteLine("Employee with this ID does not exist.");
                return false;
            }
            else
            {
                employees.Remove(emp);
                Console.WriteLine("Employee deleted successfully.");
                return true;
            }
        }
    }

    public string SearchEmployee(int id)
    {
        foreach(Employee emp in employees)
        {
            if(emp.EmployeeId != id)
            {
                return null;
            }
            else
            {
                return $"{emp.EmployeeId}: {emp.EmployeeName}";
            }
        }
    }
    
    public Employee[] GetAllEmployees()
    {
           return (Employee[])employees.ToArray(typeof(Employee));
    }
}

class Program
{
    public static void Main()
    {
        EmployeeDAL employeeDAL = new EmployeeDAL();
        
        // Adding employees
        employeeDAL.AddEmployee(new Employee("Alice", 1, 50000));
        employeeDAL.AddEmployee(new Employee("Bob", 2, 60000));
        
        // Searching for an employee
        string searchResult = employeeDAL.SearchEmployee(1);
        if (searchResult != null)
        {
            Console.WriteLine($"Found: {searchResult}");
        }
        else
        {
            Console.WriteLine("Employee not found.");
        }
        
        // Deleting an employee
        employeeDAL.DeleteEmployee(2);
        
        // Getting all employees
        Employee[] allEmployees = employeeDAL.GetAllEmployees();
        Console.WriteLine("All Employees:");
        foreach (var emp in allEmployees)
        {
            Console.WriteLine($"{emp.EmployeeId}: {emp.EmployeeName}, Salary: {emp.Salary}");
        }
    }
}