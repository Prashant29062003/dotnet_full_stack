using NUnit.Framework;
using EmployeeSalaryApp; 

namespace EmployeeSalaryAppTests;

[TestFixture]
public class EmployeeTests
{
    [Test]
    public void CalculateSalary_ReturnsCorrectValue()
    {
        var emp = new Employee { Name = "Alice", BaseSalary = 50000 };
        double result = emp.CalculateSalary(10000);
        Assert.AreEqual(60000, result);
    }
}
