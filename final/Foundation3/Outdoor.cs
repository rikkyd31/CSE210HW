public class Outdoor : Event
{
    // Attribute
    private string _weatherForecast;
    
    // Constructor
    public Outdoor() : base("Outdoor Gathering")
    {
        _eventType = "Outdoor Gathering";
    }

    // This method is slightly different from the FullDetails() method in Event class,
    // so it uses the keyword override.
    public override void FullDetails()
    {
        Console.WriteLine("Full Details");
        Console.WriteLine($"Title: {_eventTitle}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address}");
        Console.WriteLine($"Weather: {_weatherForecast}");
        Console.WriteLine("");
    }

    // Setter
    public void SetWeather(string weatherForecast)
    {
        _weatherForecast = weatherForecast;
    }
}