using System.IO;

class Program
{
       static void Main(string[] args)
    {
        string path = "D:\\.net-full-stack\\09_Day\\02_file_halding\\notes.txt";
        string content = "Welcome to C# File Handling";

        File.WriteAllText(path, content);
        Console.WriteLine(File.ReadAllText(path));

        Console.WriteLine("Enter some text to append to the file:");
        string userContent = Console.ReadLine();
        File.AppendAllText(path, userContent);
        Console.WriteLine(File.ReadAllText(path));  
        Console.ReadLine();
    }
}