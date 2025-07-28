using System;
using System.Collections.Generic; // Required for List<T>
using System.Linq; // Required for LINQ methods like OrderBy, Where etc. (optional but useful)

namespace StudentsRecord
{
    // 1. Define a class to represent a Student
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }

        // Constructor to easily create Student objects
        public Student(int id, string name, int age, string grade)
        {
            Id = id;
            Name = name;
            Age = age;
            Grade = grade;
        }

        // Override ToString() for easy printing of Student details
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Age: {Age}, Grade: {Grade}";
        }
    }

    class Program
    {
        // 2. Use a List<Student> to store student records
        private static List<Student> studentList = new List<Student>();

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Student Record Management System!");

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\n--- Menu ---");
                Console.WriteLine("1. Add New Student");
                Console.WriteLine("2. View All Students");
                Console.WriteLine("3. Search Student by ID");
                Console.WriteLine("4. Update Student Information");
                Console.WriteLine("5. Delete Student by ID");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        ViewAllStudents();
                        break;
                    case "3":
                        SearchStudentById();
                        break;
                    case "4":
                        UpdateStudentInformation();
                        break;
                    case "5":
                        DeleteStudentById();
                        break;
                    case "6":
                        exit = true;
                        Console.WriteLine("Exiting program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        // Method to add a new student
        static void AddStudent()
        {
            Console.WriteLine("\n--- Add New Student ---");
            Console.Write("Enter Student ID: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID. Please enter a number.");
                return;
            }

            // Check if student with this ID already exists
            if (studentList.Any(s => s.Id == id))
            {
                Console.WriteLine($"Student with ID {id} already exists. Please use a different ID or update the existing record.");
                return;
            }

            Console.Write("Enter Student Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Student Age: ");
            if (!int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine("Invalid Age. Please enter a number.");
                return;
            }

            Console.Write("Enter Student Grade: ");
            string grade = Console.ReadLine();

            Student newStudent = new Student(id, name, age, grade);
            studentList.Add(newStudent);
            Console.WriteLine($"Student '{name}' added successfully!");
        }

        // Method to view all students
        static void ViewAllStudents()
        {
            Console.WriteLine("\n--- All Student Records ---");
            if (studentList.Count == 0)
            {
                Console.WriteLine("No student records found.");
                return;
            }

            // Optional: Order students by ID for better readability
            foreach (var student in studentList.OrderBy(s => s.Id))
            {
                Console.WriteLine(student);
            }
        }

        // Method to search for a student by ID
        static void SearchStudentById()
        {
            Console.WriteLine("\n--- Search Student by ID ---");
            Console.Write("Enter Student ID to search: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID. Please enter a number.");
                return;
            }

            Student foundStudent = studentList.FirstOrDefault(s => s.Id == id);

            if (foundStudent != null)
            {
                Console.WriteLine("Student Found:");
                Console.WriteLine(foundStudent);
            }
            else
            {
                Console.WriteLine($"Student with ID {id} not found.");
            }
        }

        // Method to update student information
        static void UpdateStudentInformation()
        {
            Console.WriteLine("\n--- Update Student Information ---");
            Console.Write("Enter Student ID to update: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID. Please enter a number.");
                return;
            }

            Student studentToUpdate = studentList.FirstOrDefault(s => s.Id == id);

            if (studentToUpdate != null)
            {
                Console.WriteLine($"Current Information for ID {id}: {studentToUpdate}");

                Console.Write("Enter New Name (leave blank to keep current): ");
                string newName = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newName))
                {
                    studentToUpdate.Name = newName;
                }

                Console.Write("Enter New Age (leave blank to keep current, or enter a number): ");
                string newAgeInput = Console.ReadLine();
                if (int.TryParse(newAgeInput, out int newAge))
                {
                    studentToUpdate.Age = newAge;
                }
                else if (!string.IsNullOrWhiteSpace(newAgeInput))
                {
                    Console.WriteLine("Invalid age format. Keeping current age.");
                }

                Console.Write("Enter New Grade (leave blank to keep current): ");
                string newGrade = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(newGrade))
                {
                    studentToUpdate.Grade = newGrade;
                }

                Console.WriteLine("Student information updated successfully!");
            }
            else
            {
                Console.WriteLine($"Student with ID {id} not found.");
            }
        }

        // Method to delete a student by ID
        static void DeleteStudentById()
        {
            Console.WriteLine("\n--- Delete Student by ID ---");
            Console.Write("Enter Student ID to delete: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Invalid ID. Please enter a number.");
                return;
            }

            Student studentToDelete = studentList.FirstOrDefault(s => s.Id == id);

            if (studentToDelete != null)
            {
                Console.Write($"Are you sure you want to delete student '{studentToDelete.Name}' (ID: {id})? (yes/no): ");
                string confirmation = Console.ReadLine().ToLower();

                if (confirmation == "yes")
                {
                    studentList.Remove(studentToDelete);
                    Console.WriteLine($"Student with ID {id} deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Deletion cancelled.");
                }
            }
            else
            {
                Console.WriteLine($"Student with ID {id} not found.");
            }
        }
    }
}