using System;
using System.Collections.Generic;

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

}
     

class Program
{

}
