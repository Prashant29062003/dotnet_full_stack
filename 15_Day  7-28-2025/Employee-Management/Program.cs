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
        }
        employees.Add(e);
        return true;
    }

    public bool DeleteEmployee(int id)
    {
        for(int i = employees.Count; i>=0;i--){
            Employyee emp = (Employee)employees[i];
            if(emp.EmployeeId == id)
            {
                employees.Remove(i);
                Console.WriteLine("Employee deleted successfully.");
                return true;
            }
        }
        Console.WriteLine("Employee with this ID does not exist.");
        return false;
    }

    public string SearchEmployee(int id)
    {
        foreach(Employee emp in employees)
        {
            if(emp.EmployeeId == id)
            {
                return emp.EmployeeName;
            }
        }
        return null;
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

        // Displaying all employees
        foreach(var emp in employeeDAL.GetAllEmployees())
        {
            Console.WriteLine($"{emp.EmployeeId}: {emp.EmployeeName}, Salary: {emp.Salary}");
        }

        Console.WriteLine("-----");



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
        Console.ReadLine();
    }
}