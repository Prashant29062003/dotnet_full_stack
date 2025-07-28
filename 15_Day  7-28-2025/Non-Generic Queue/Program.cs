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
    public void display()
    {
        Console.WriteLine("Name: " + Name + ", RollNo: " + RollNo + ", Marks: " + Marks);
    }
}

class ChromeHistory
{
    public string URL { get; set; }
    public DateTime VisitTime { get; set; }

    public ChromeHistory(string url)
    {
        URL = url;
        VisitTime = DateTime.Now;
    }

}
class Program
{
    public static void Main(string[] args) { 
        Queue StudentQueue = new Queue();

        // Enqueue (Boxing happens)
        StudentQueue.Enqueue(new Student("Amit", 101, 88.5));
        StudentQueue.Enqueue(new Student("Bhavya", 102, 77.0));
        StudentQueue.Enqueue(new Student("Charan", 103, 91.2));

        // Peek (Check front element without removing - Unboxing)
        Console.WriteLine("Front element (Peek):");
        Student frontStudent = (Student)StudentQueue.Peek();
        frontStudent.display();

        // Dequeue (Remove front element - Unboxing)
        Console.WriteLine("\nDequeued element:");
        Student dequeuedStudent = (Student)StudentQueue.Dequeue();
        dequeuedStudent.display();

        // Remaining elements
        Console.WriteLine("\nRemaining students in queue:");
        foreach (object obj in StudentQueue)
        {
            Student s = (Student)obj;
            s.display();
        }

        // Example of ChromeHistory
        Queue historyQueue = new Queue();
        historyQueue.Enqueue(new ChromeHistory("https://www.Google.com"));
        historyQueue.Enqueue(new ChromeHistory("https://www.openai.com"));  
        historyQueue.Enqueue(new ChromeHistory("https://www.github.com"));
        Console.WriteLine("\nChrome History:");
        foreach (ChromeHistory history in historyQueue)
        {
            Console.WriteLine($"URL: {history.URL}, Visit Time: {history.VisitTime}");
        }
        Console.ReadLine();
    }
}