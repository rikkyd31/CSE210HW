public class Listing : Activity
{
    private string _listingDescriptionOne;
    private string _listingDescriptionTwo;
    private List<string> _listingPrompts = new List<string>();
    private int _randomInteger;
    private int _listPromptSize;
    private DateTime _currentTime;
    private DateTime _futureTime;
    private int _numberItems;

    // Derived Constructor passes in "Listing" to the Base Constructor.
    public Listing() : base("Listing")
    {
        _listingDescriptionOne = "This activity will help you reflect on the good things in your life.";
        _listingDescriptionTwo = "It will have you list as many things as you can in a certain area.";
        _listingPrompts = ["Who are people that you appreciate?", "What are personal strengths of yours?",
            "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"];
        _numberItems = 0;  
        _randomInteger = 0;
        _listPromptSize = 0;
    }

    /*
        This method displays the description for the listing activity.
    */
    public void DisplayListingDescription()
    {
        Console.WriteLine(_listingDescriptionOne);
        Console.WriteLine(_listingDescriptionTwo);
        Console.WriteLine("");
    }

    /*
        This is the main method for the listing activity.
        It displays the listing prompt,
        and then allows the user to answer in the alloted time.
        It passes in the session time as the paramter.
    */
    public void DisplayListingPrompt(int _sessionTime)
    {
        // Get the size of the listing prompts list.
        _listPromptSize = _listingPrompts.Count();

        // Generate a new random integer that aligns with the size of the list.
        Random randomGenerator = new Random();
        _randomInteger = randomGenerator.Next(0, _listPromptSize);

        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine("");

        // Iterate through each item in the list.
        for (int i = 0; i < _listPromptSize; i++)
        {
            // If the random integer matches the index in the list...
            if (i == _randomInteger)
            {
                // Write that list prompt.
                Console.WriteLine($"--- {_listingPrompts[i]} ---");
            }
        }
        Console.WriteLine("");

        // Call the countdown timer in the Activity base class.
        CountdownTimer();

        _currentTime = DateTime.Now;
        // Add the session time to the current time to get the future time.
        _futureTime = _currentTime.AddSeconds(_sessionTime);

        // Allow the user to write as many items as they can
        // While the timer runs down.
        while (_currentTime < _futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _numberItems = _numberItems + 1;
            _currentTime = DateTime.Now;
        }

        Console.WriteLine($"Congratulations! You have listed {_numberItems} items!");
        Console.WriteLine("");
    }
}