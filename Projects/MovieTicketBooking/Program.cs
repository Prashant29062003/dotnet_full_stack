using System;

class MovieTicketBooking
{
    private string MovieID;
    private string MovieName;
    private string DirectorName;
    private string ProducerName;
    private double Duration;
    private string Story;
    private string Genre;
    private string Language;

    public MovieTicketBooking(string MovieName, string DirectorName, string ProducerName, double Duration, string Story, string Genre, string Language)
    {
        this.MovieID = $"{(MovieName.Substring(0, 2))}-{(ProducerName.Substring(0, 2))}-{(Genre.Substring(0, 2))}-{(Language.Substring(0, 2))}";
        this.MovieName = MovieName ;
        this.DirectorName = DirectorName ;
        this.ProducerName = ProducerName ;
        this.Duration = Duration ;
        this.Story = Story ;
        this.Genre = Genre ;
        this.Language = Language ;
    }

    public void DisplayMovieDetails()
    {
        Console.WriteLine("--- Booking Details ---");
        Console.WriteLine($"Movie Name: {MovieName}");
        Console.WriteLine($"Producer Name: {ProducerName}");
        Console.WriteLine($"Genre Name: {Genre}");
        Console.WriteLine($"Language Name: {Language}");
        Console.WriteLine($"MovieID Name: {MovieID}");
    }

}

class Threater
{
    private int ThreaterID;
    private string ThreaterName;
    private int NumberOfSeats;

    public Threater(string threaterName, int numberOfSeats)
    {
        this.ThreaterName = threaterName;
        this.NumberOfSeats = numberOfSeats ;
    }

    public void DisplayThreaterDetails()
    {
        Console.WriteLine("\n\n--- Threater Details ---");
        Console.WriteLine($"Therater Name: {ThreaterName}");
        Console.WriteLine($"Number Of Seats: {NumberOfSeats}");
    }
}

class Customer { 
    private int CustomerID;
    private string CustomerName;
    private string City;

    public Customer(string CustomerName,  string City)
    {
        this.CustomerName = CustomerName;
        this.City = City;
    }

    public void DisplayCustomerDetails()
    {
        Console.WriteLine("\n\n--- Threater Details ---");
        Console.WriteLine($"Customer Name: {CustomerName}");
        Console.WriteLine($"Customer City: {City}");
    }
}

class LoginDetails
{
    private string LoginID;
    private string Password;
    private string Login;
    private string LoginType;

    public LoginDetails(string LoginID, string Password, string LoginType)
    {
        // TODO
        // For Customer:: loginID = CustomerID
        // For Admin:: loginID = static text (MOVIEADMIN)

        // TODO
        // :: for Customer and Admin login types consider the default password same as the LoginID.

        if(LoginType.ToLower() == "admin")
        {
            this.LoginID = "MOVIEADMIN";
            this.Password = "MOVIEADMIN";
        }
        else if(LoginType.ToLower() == "customer")
        {
            this.LoginID = LoginID;
            this.Password = Password;
        }
        else
        {
            throw new ArgumentException("Invalid Login Type.");
        }
        this.Login = LoginType;
    }

    public void DisplayThreaterDetails()
    {
        //TODO
        Console.WriteLine("\n--- Login Details ---");
        Console.WriteLine($"Login Type: {Login}");
        Console.WriteLine($"Login ID: {LoginID}");
        Console.WriteLine($"Password: {Password}");
    }
}

class InvalidLanguageException : Exception
{
    public InvalidLanguageException(string message) : base(message) { }
}

class IvalidDurationException : Exception
{
    public IvalidDurationException(string message) : base(message){ }
}