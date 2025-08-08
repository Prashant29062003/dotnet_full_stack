
using System;
using System.Collections.Generic;
//1.menu
//2. Dictionary ===> Student record {UID, student (class)}
//3. Student ==> class --> id, name, branch, email
class Student {
    int UID;
    string Sname;
    string Branch;
    string Email;
    public Student(int id, string name, string branch, string emial){
        UID = id;
        Sname = name;
        Branch = branch;
        Email = email;
    }
    public override string ToString(){
        return $"{UID}: {name}, Email: {email}, Branch: {branch}";
    }
}



class program
{
    static Dictionary<int, Student> StudentsData = new Dictionary<int, Student>();

    public static void Main(string[] args)
    {
        Console.Write(new String('-',70));
        Console.Write(" Student Management ");
        Console.Write(new String('-',70));
        Console.WriteLine();
        Console.WriteLine("1. List All Students");
        Console.WriteLine("2. Add Student");
        Console.WriteLine("3. Remove Student");
        Console.WriteLine("4. Update Student");
        Console.WriteLine("5. Exit");
        

        string choice = Console.ReadLine();

        
        while (true)
        {
            switch(chioce){
                case '1':
                    ListStudents();
                    break;
                case '2':
                    AddStudent();
                    break;
                case '3':
                    RemoveStudent();
                    break;
                case '4':
                    UpdateStudent();
                case '5':
                    break;
                default:
                    Console.WriteLine("Invalid Choice!");
            }

        }
    }
}