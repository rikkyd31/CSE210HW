public class Event
{
    // String Attributes
    protected string _eventType;
    protected string _eventTitle;
    protected string _description;
    protected string _address;

    // DateTime Attributes
    protected DateOnly _date;
    protected TimeOnly _time;

    // Class Attribute
    Address _myAddress = new Address();

    // Constructor
    public Event(string eventType)
    {
        _eventType = eventType;
    }

    // This method prints the Standard Details for an event, and is the first method called.
    public void StandardDetails()
    {
        _address = _myAddress.CombineAddress();

        Console.WriteLine($"---------------- {_eventType} ----------------");
        Console.WriteLine("");

        Console.WriteLine("Standard Details");
        Console.WriteLine($"Title: {_eventTitle}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address}");
        Console.WriteLine("");
    }

    // This method prints the full details for an event.
    // This method is virtual, meaning the inherited method can override it.
    public virtual void FullDetails()
    {
        _address = _myAddress.CombineAddress();

        Console.WriteLine("Full Details");
        Console.WriteLine($"Title: {_eventTitle}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address}");
        Console.WriteLine("");
    }

    // This method prints the short description for an event.
    // This method is virtual, meaning the inherited method can override it.
    public virtual void ShortDescription()
    {
        _address = _myAddress.CombineAddress();

        Console.WriteLine("Short Description");
        Console.WriteLine($"Event Type: {_eventType}");
        Console.WriteLine($"Title: {_eventTitle}");
        Console.WriteLine($"Date {_date}");
        Console.WriteLine("");
    }

    // Setters
    public void SetTitle(string eventTitle)
    {
        _eventTitle = eventTitle;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetDate(DateOnly date)
    {
        _date = date;
    }

    public void SetTime(TimeOnly time)
    {
        _time = time;
    }

    // Main address setter method. It calls the SetAddress() method inside the Address class.
    public void SetAddress(string address, string city, string state, string zipCode)
    {
        _myAddress.SetAddress(address, city, state, zipCode);
    }
}