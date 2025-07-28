using System;
using System.Collections;

class Student
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
}

// For sorting students by Marks
class SortByMarks : IComparer
{
    public int Compare(object x, object y)
    {
        Student s1 = (Student)x;
        Student s2 = (Student)y;
        return s1.Marks.CompareTo(s2.Marks);
    }
}

class Program
{
    static void Main()
    {
        ArrayList students = new ArrayList();

        Student sJacob = new Student("Jacob", 1, 89.5);
        Student sRahul = new Student("Rahul", 2, 75.0);
        Student sAdit = new Student("Adit", 3, 92.3);
        Student sVed = new Student("Ved", 4, 81.2);

        // Add
        students.Add(sJacob);   // Boxing
        students.Add(sRahul);
        students.Add(sAdit);

        // Insert
        students.Insert(1, sVed);

        // Remove by value (object reference)
        students.Remove(sAdit);

        // Remove by index
        students.RemoveAt(0);  // Removes Jacob

        // Count
        Console.WriteLine($"Total students after operations: {students.Count}");

        // Access via index (unboxing)
        Student accessed = (Student)students[0];
        Console.WriteLine("\nAccessed at index 0:");
        accessed.Display();

        // Contains check
        bool hasRahul = students.Contains(sRahul);
        Console.WriteLine($"\nContains Rahul? {(hasRahul ? "Yes" : "No")}");

        // Sort by marks
        students.Sort(new SortByMarks());
        Console.WriteLine("\nSorted by Marks:");
        foreach (object obj in students)
        {
            Student s = (Student)obj;  // Unboxing
            s.Display();
        }

        // Reverse
        students.Reverse();
        Console.WriteLine("\nAfter Reverse:");
        foreach (object obj in students)
        {
            Student s = (Student)obj;
            s.Display();
        }

        // Clear
        students.Clear();

        // Check if list is cleared
        Console.WriteLine($"\nList cleared. Count = {students.Count}");
        Console.WriteLine(students.Count == 0 ? "List is empty." : "List still has items.");

        Console.ReadLine();
    }
}
