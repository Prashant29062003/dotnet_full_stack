class Program
{
    public static void Main(string[] args)
    {
        List<string> words = new List<string> { "falcon", "owl", "sky", "hawk", "stork" };
        List<int> lengths = words.ConvertAll(s => s.Length);
        foreach(int i in lengths)
        {
            Console.WriteLine(i);
        }
        Console.ReadLine();
    }
}