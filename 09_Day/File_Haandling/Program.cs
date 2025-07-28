using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string path = "output.md";
        string content = "Good After Noon Mam!";

        File.WriteAllText(path, content);
        File.AppendAllLines(path, "\n This is the second line of text.".Split('\n'));
        Console.WriteLine($"File Created at ./{path}");

        string[] content1 =
        {
            "Namaste",
            "Hello",
            "Bonjor",
            "Hola",
            "Hallo"
        };

        //using (FileStream fs = new FileStream("myFile.txt", FileMode.Create, FileAccess.Write))
        //{

        //}
        File.Delete("myFile.txt");
        using (StreamWriter writer = new StreamWriter("myFile.txt", append: true))
        {
            foreach (string line in content1)
            {
                writer.Write(line);
                writer.Write($"\n$~ {DateTime.Now} \n");

            }
        }

        using (StreamReader reader = new StreamReader("myFile.txt"))
        {
            string line;
            while((line = reader.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }
        Console.ReadLine(); 
    }
}