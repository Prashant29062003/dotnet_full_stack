using System;
using System.Collections.Generic;

class Student : IComparable<Student>
{
    public string Name { get; set; }
    public int RollNo { get; set; }
    public double Marks { get; set; }

    public Student(string name, int rollNo, double marks)
    {
        Name = name;
        RollNo = rollNo;
        Marks = marks;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {Name}, RollNo: {RollNo}, Marks: {Marks}");
    }

    // Sorting by Marks
    public int CompareTo(Student other)
    {
        return this.Marks.CompareTo(other.Marks); // ascending
    }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();

        // Add
        Student isJacob = new Student("Jacob", 1, 89.5);
        Student isRahul = new Student("Rahul", 2, 75.0);
        Student isAdit = new Student("Adit", 3, 92.3);
        Student isVed = new Student("Ved", 4, 81.2);

        students.Add(isJacob);
        students.Add(isRahul);
        students.Add(isAdit);

        // Insert at index 2
        students.Insert(2, isVed);

        // Remove by value (Charlie)
        students.RemoveAll(s => s.Name == "Charlie");

        // Remove by index - remove student at index 0
        students.RemoveAt(0);

        // Count
        Console.WriteLine($"Total students after operations: {students.Count}");

        // Access via index
        if (students.Count > 0)
        {
            Console.WriteLine("\nAccessed at index 0:");
            students[0].Display();
        }

        // Sort by Marks (ascending)
        students.Sort();
        Console.WriteLine("\nSorted by Marks:");
        foreach (Student s in students)
            s.Display();

        // Reverse
        students.Reverse();
        Console.WriteLine("\nAfter Reverse:");
        foreach (Student s in students)
            s.Display();

        // Contains check (by reference)
        bool containsVed = students.Contains(isVed);
        Console.WriteLine($"\nContains Bob? {(containsVed ? "Yes" : "No")}");

        // Clear all
        students.Clear();

        // Check if list is empty
        Console.WriteLine($"\nList cleared. Count = {students.Count}");
        Console.WriteLine(students.Count == 0 ? "List is empty." : "List still has items.");

        Console.ReadLine();
    }
}
