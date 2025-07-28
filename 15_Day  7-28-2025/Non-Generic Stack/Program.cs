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

class Program
{
    static void Main()
    {
        Stack studentStack = new Stack();

        // Push (Boxing happens)
        studentStack.Push(new Student("Amit", 101, 88.5));
        studentStack.Push(new Student("Bhavya", 102, 77.0));
        studentStack.Push(new Student("Charan", 103, 91.2));

        // Peek (Check top element without removing - Unboxing)
        Console.WriteLine("Top element (Peek):");
        Student topStudent = (Student)studentStack.Peek();
        topStudent.Display();

        // Pop (Remove top element - Unboxing)
        Console.WriteLine("\nPopped element:");
        Student poppedStudent = (Student)studentStack.Pop();
        poppedStudent.Display();

        // Remaining elements
        Console.WriteLine("\nRemaining students in stack:");
        foreach (object obj in studentStack)
        {
            Student s = (Student)obj;
            s.Display();
        }

        Console.ReadLine();
    }
}
