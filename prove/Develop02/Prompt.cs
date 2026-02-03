public class Prompt
{
    // Create a list of strings, and leave it public so it can be accessed by classes.
    public List<string> _listPrompts = 
    ["Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    ];


    // Constructor
    public Prompt()
    {

    }

    public string GetRandomPrompt()
    {
        // Create a new instance of the random class called randomGenerator
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 4);
        string randomPrompt = _listPrompts[randomNumber];
        return randomPrompt;
    }
    
    public void DisplayRandomPrompt(string randomPrompt, string dateText)
    {
        // Display the dateText string and randomPrompt string
        // passed into this method
        Console.WriteLine($"Date: {dateText}");
        Console.WriteLine($"Prompt: {randomPrompt}");
    }

}