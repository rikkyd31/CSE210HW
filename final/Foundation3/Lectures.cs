public class Lecture : Event
{
    // Attributes
    private string _speakerName;
    private int _speakerCapacity;
    
    // Constructor
    public Lecture() : base("Lecture")
    {
        _eventType = "Lecture"; 
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
        Console.WriteLine($"Speaker Name: {_speakerName}");
        Console.WriteLine($"Speaker Capacity: {_speakerCapacity}");
        Console.WriteLine("");
    }

    // Setters
    public void SetSpeaker(string speakerName)
    {
        _speakerName = speakerName;
    }

    public void SetCapacity(int speakerCapacity)
    {
        _speakerCapacity = speakerCapacity;
    }
}