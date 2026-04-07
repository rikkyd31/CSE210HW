public class Receptions : Event
{
    // Attribute
    private string _email;

    // Constructor
    public Receptions() : base("Reception")
    {
        _eventType = "Reception";
    }

    // This override method is slightly different from the base event FullDetails() method,
    // So it uses the keyword override.
    public override void FullDetails()
    {
        Console.WriteLine("Full Details");
        Console.WriteLine($"Title: {_eventTitle}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address}");
        Console.WriteLine($"Email: {_email}");
        Console.WriteLine("");
    }

    // Setter
    public void SetEmail(string email)
    {
        _email = email;
    }

}