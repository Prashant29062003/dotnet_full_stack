class ServiceToken
{
    private int counter = 1;
    public int tokenID { get; set; }
    public string Position { get; set; }
    public DateTime TicketDateTime { get; set; }
    public string Status { get; set; }

    public ServiceToken(string position)
    {
        tokenID = counter++;
        Position = position;
        TicketDateTime = new DateTime.Now;
        Status = "Pending";
    }

    public override string ToString()
    {
        return $"TokenID: {tokenID}, Position: {Position}, Time: {TicketDateTime}, Status: {Status}";
    }
}


class TicketManager
{
    Queue<ServiceToken> TokenQueue { get; set; } = new Queue<ServiceToken>();
    List<ServiceToken> AllToken { get; set; } = new List<ServiceToken>();

    public void GenerateServiceToken()
    {
        Console.WriteLine("Enter the positon (eg. Guard, Clerk...)");
        string position = Console.ReadLine();
        ServiceToken token = new ServiceToken(position);
        TokenQueue.Enqueue(token);
        AllToken.Add(token);
        Console.WriteLine($"Token Generated: {token.tokenID}");
    }

    public void GetNextToken()
    {
        if (TokenQueue.Count > 0)
        {
            int token TokenQueue.Peek();
            Console.WriteLine($"Next Token: {token}")
        }
        else
        {
            Console.WriteLine("Queue is Empty.");
        }
    }
    public void UpdateToken(int TokenId)
    {
        var token = AllToken.Find(t => t.tokenID == TokenId);
        if (token != null)
        {
            token.Status = "Completed";
            Console.WriteLine($"Token: {token} marked as completed.");
            if (TokenQueue > 0 && TokenQueue.Peek().tokenID == TokenId)
            {
                TokenQueue.Dequeue();
            }
        }
    }
    public int skipToken()
    {
        if (TokenQueue.Conut > 0)
        {
            var skipped = TokenQueue.Dequeue();
            Console.WriteLine($"Ticket {skipped} has skipped.")
         }
    }
}


class Program
{
    public static void Main()
    {
        TicketManager ticketManager = new TicketManager();


        Console.Write(new string('*', 30));
        Console.Write(" Token-Management-System ");
        Console.Write(new string('*', 30));

        Console.WriteLine("1. Create a Token");
        Console.WriteLine("2. Get next Token");
        Console.WriteLine("3. Update Token");
        Console.WriteLine("4. Skip Token");
        Console.WriteLine("5. List all Token");
        Console.WriteLine("6. Exit");

        Console.WriteLine("Enter your Choice? ");

        string choice = Console.ReadLine();

        switch (chioce)
        {
            case '1':
                ticketManager.GenerateServiceToken();
                break;
            case '2':
                ticketManager.GetNextToken();
                break;
            case '3':
                ticketManager.UpdateToken()
        }



    }
}