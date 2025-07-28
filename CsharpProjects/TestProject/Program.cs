String[] orderIDs  = {"B123","C234","A345","C15","B177","G3003","C235","B179"};

foreach (string orderID in orderIDs)
{
    if (orderID.StartsWith('B'))
    {
        Console.WriteLine(orderID);
    }
    Random dice = new Random();
    int roll = dice.Next(1, 7);
    Console.WriteLine(roll);

    int roll1 = dice.Next(1, 5);
    int roll2 = dice.Next();
    int roll3 = dice.Next(1, 101);

    Console.WriteLine($"Roll1: {roll1}, Roll2: {roll2}, Roll3: {roll3}");
    
    Console.WriteLine("Press any key to exit...");  
    Console.ReadKey();
}