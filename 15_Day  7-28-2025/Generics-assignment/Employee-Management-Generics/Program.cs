using System;
using System.Collections.Generic;

// CSV Creation format 
/*
static void WriteToCsv(string filePath)
{

    try
    {
        if (!File.Exists(filePath))
        {
            using (File.Create(filePath)) { }
        }


        List<Person> people = new List<Person>
        {
          new Person { Name = "Jane", Age = 25, Country = "UK" },
          new Person { Name = "Any", Age = 30, Country = "Canada" },
          new Person { Name = "Mike", Age = 35, Country = "USA" }
        };


        var configPersons = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            HasHeaderRecord = false
        };

        using (StreamWriter streamWriter = new StreamWriter(filePath, true))
        using (CsvWriter csvWriter = new CsvWriter(streamWriter, configPersons))
        {
            csvWriter.WriteRecords(people);
        }

        Console.WriteLine("Data written to CSV successfully.");
    }

    catch (Exception ex)
    {
        throw;
    }

}
*/

class Employee
{
    public int EmployeeID { get; set; }
    public string EmployeeName { get; set; }
    public string Designation {  get; set; }
    public DateTime JoiningDate { get; set; }
    public string DepartmentName { get; set; }

    public Employee(int id, string name, string designation, DateTime joiningDate, string department)
    {
        EmployeeID = id;
        EmployeeName = name;
        Designation = designation;
        JoiningDate = joiningDate;
        DepartmentName = department;
    }

    public override string ToString()
    {
        return $"{EmployeeID}: {EmployeeName}, designation {Designation}, joins at {JoiningDate}, Department: {DepartmentName}";
    }
}

class EmployeeData
{
    public List<Employee> Employees { get; set; } = new List<Employee> ();

    public void AddData()
    {
        Employees.Add(new Employee(101, "Prashant", "Senior Software Dev", new DateTime(2024, 6, 29), "IT");
        Employees.Add(new Employee(101, "Kundan", "Senior Software Dev", new DateTime(2024, 10, 9), "Product Dev");
    }
}
     

class Program
{

}
