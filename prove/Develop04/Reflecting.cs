public class Reflecting : Activity
{
    private string _reflectingPartOne;
    private string _reflectingPartTwo;
    private List<string> _reflectionPrompt = new List<string>();
    private List<string> _reflectionQuestions = new List<string>();
    private int _randomInt;
    private int _lengthPromptList;
    private int _lengthQuestionList;
    private int _spinnerTime;

    // Pass "Reflecting" on to base constructor as activity type
    public Reflecting() : base("Reflecting")
    {
        _reflectingPartOne = "This activity will help you reflect on times in your life when you have shown strength and resilience.";
        _reflectingPartTwo = "This will help you recognize the power and determination you already have.";
        _reflectionPrompt = ["Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."];
        _reflectionQuestions = ["Why was this experience meaningful to you?", "Have you ever done anything like this before?",
            "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"];
        _totalTime = 0;
    }

    /*
        This method simply displays the description for the Reflecting Activity.
    */
    public void DisplayReflectingDescription()
    {
        Console.WriteLine(_reflectingPartOne);
        Console.WriteLine(_reflectingPartTwo);
        Console.WriteLine("");
    }

    /*
        This method displays the random reflection prompt to the user.
        It then displays random questions regarding the prompt until the timer runs out.
    */
    public void DisplayWritingPrompt(int _sessionTime)
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");

        // Get the size of the Reflection Prompt list.
        _lengthPromptList = _reflectionPrompt.Count();

        // Generate a new random number
        Random randomGenerator = new Random();
        _randomInt = randomGenerator.Next(0, _lengthPromptList);

        // Intialize List
        _usedIntegers = [];
        // Iterate through each index in the Reflection Prompt list.
        for (int i = 0; i < _lengthPromptList; i++)
        {
            // Match the random integer to the location in the Reflection Prompt list.
            if (i == _randomInt)
            {
                if (_usedIntegers.Contains(_randomInt))
                {
                    // If this prompt has already been done, then do nothing, skip.
                }
                else
                {
                    Console.WriteLine($"--- {_reflectionPrompt[i]} ---");
                    _usedIntegers.Add(_randomInt);
                }
            }

            // If every prompt has already been used and added to the usedIntegers list, then break out of the loop.
            if (_usedIntegers.Count() >= _lengthPromptList)
            {
                break;
            }
        }

        Console.WriteLine("When you have something in mind, press ENTER to continue.");
        // Activates when the user presses enter.
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine("");

        CountdownTimer();

        // Get the length of the Reflection Questions list.
        _lengthQuestionList = _reflectionQuestions.Count();

        // Convert into microseconds.
        _sessionTime = _sessionTime * 1000;

        // Intialize _usedIntegers list.
        _usedIntegers = [];
        _breakOut = false;

        while (_totalTime < _sessionTime)
        {
            // Generate a random number.
            Random randomGenerator2 = new Random();
            _randomInt = randomGenerator2.Next(0, _lengthQuestionList);

            for (int i = 0; i < _lengthQuestionList; i++)
            {
                // If the random integer matches the index in the Relection Questions list...
                if (i == _randomInt)
                {
                    if (_usedIntegers.Contains(_randomInt))
                    {
                        // If this question has already been done, then do nothing, Skip
                    }
                    else
                    {
                        Console.WriteLine($"{_reflectionQuestions[i]}");

                        // Display the spinner between each question.
                        Activity myActivity = new Activity("Reflecting");
                        _spinnerTime = myActivity.GetReadySpinner();
                        
                        _totalTime = _totalTime + _spinnerTime;
                        Console.WriteLine("");   
                        _usedIntegers.Add(_randomInt);
                    }

                    // If every prompt has already been used and added to the usedIntegers list, then break out of the loop.
                    if (_usedIntegers.Count() >= _lengthQuestionList)
                    {
                        _breakOut = true;
                        break;
                    }
                }
            }

            if (_breakOut == true)
            {
                Console.WriteLine("That is every question!");
                Console.WriteLine("");
                break;
            }
        }
        Console.WriteLine("Well Done!");
        Console.WriteLine("");
    }
}