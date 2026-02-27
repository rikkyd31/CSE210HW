using System.Security.Cryptography;

public class Activity
{
    // Strings
    private string _sessionTimeString;
    private string _activityType;
    private string _howLongSessionString;
    private string _getReady;

    // Private Ints
    private int _totalSpinnerTime;
    private int _incrementalSpinnerTime;

    // Protected Ints
    protected int _sessionTime;
    protected int _totalTime;
    protected int _countDown;
    protected int _totalTimeCounter;
    protected int _secondTime;
    protected int _sleepTime;
    protected bool _previousCursor;
    protected List<int> _usedIntegers = new List<int>();
    protected bool _breakOut;


    // base constructor
    public Activity(string activity)
    {
        // When the derived class constructor is called, it pushes its activity type to the main Activity constructor
        // I am happy with how sneaky I think this is.

        // It also sets the activity type for the rest of the object.
        _activityType = activity;

        _howLongSessionString = "How long, in seconds, would you like for your session?";
        _getReady = "Get Ready...";
        _incrementalSpinnerTime = 0;
        // Spinner changes position every half second.
        _sleepTime = 500;
        _secondTime = 1000;
        // Total time for the spinner to spin (5 seconds).
        _totalSpinnerTime = 5000;
        _getReady = "Get Ready...";
        _totalTimeCounter = 5;
        _countDown = 0;
    }

    /*
        This method justs displays the welcome message and activity type.
        The classes for the different activities push the activity type
        in their constructor.
    */
    public void DisplayWelcomeMessage()
    {
        Console.WriteLine($"Welcome to the {_activityType} Activity.");
        Console.WriteLine("");
    }

    /* 
        This method gets how long each session (Listing, Breathing, Reflecting)
        Should be (in seconds) from the user.
    */
    public int GetSessionQuestion()
    {
        Console.WriteLine(_howLongSessionString);
        Console.Write("> ");
        _sessionTimeString = Console.ReadLine();
        _sessionTime = int.Parse(_sessionTimeString);
        Console.WriteLine("");

        return _sessionTime;
    }

    /*
        This method just displays a message.
        It is placed in this Activity base class to avoid redundancy.
    */
    public void DisplayGetReady()
    {
        Console.WriteLine(_getReady);
    }

    /*
        This method is the spinner used while preparing for an activity.
        The total spinner time is initialized in the constructor.
    */
    public int GetReadySpinner()
    {
        // Hide the annoying cursor while spinning.
        _previousCursor = Console.CursorVisible;
        Console.CursorVisible = false;

        // Intialize spinner with "-" symbol
        Console.Write("-");
        // Call the IncrementSpinner private method
        IncrementSpinner();

        // The _sleepTime is initialized in the constructor
        // Right now the spinner changes positon every half second.
        while (_incrementalSpinnerTime < _totalSpinnerTime)
        {
            Console.Write("\b \b");
            // You need two \\ to get the one \
            Console.Write("\\");
            IncrementSpinner();

            Console.Write("\b \b");
            Console.Write("|");
            IncrementSpinner();

            Console.Write("\b \b");
            Console.Write("/");
            IncrementSpinner();

            // Resets back to the original position
            Console.Write("\b \b");
            Console.Write("-");
            IncrementSpinner();
        }
        // Reset the cursor back to visible.
        Console.CursorVisible = _previousCursor;

        // Clear the spinner and go to a new line.
        Console.Write("\b \b");
        Console.WriteLine("");
        return _incrementalSpinnerTime;
    }

    /*
        Helper Method to avoid code redundancy.
    */
    private void IncrementSpinner()
    {
        Thread.Sleep(_sleepTime);
        _incrementalSpinnerTime =_incrementalSpinnerTime + _sleepTime;
    }

    /*
        Simple method to display an ending message for each activity.
    */
    public void DisplayEndMessage()
    {
        Console.WriteLine($"You have completed another {_sessionTime} seconds of the {_activityType} activity.");
        Console.WriteLine("");
        Thread.Sleep(4000);
    }

    /*
        This method is a countdown timer used for the Listing and Reflecting activiites.
    */
    public void CountdownTimer()
    {
        // Hide the annoying cursor.
        Console.CursorVisible = false;
        Console.Write("You may begin in: ");
        
        // Counts down from 5 set in the constructor.
        for (int i = _totalTimeCounter; i >= _countDown; i--)
        {
            // Intial Start Count
            if (i == _totalTimeCounter)
            {
                Console.Write($"{i}");
                Thread.Sleep(_secondTime);
            }
            // Final Countdown
            else if (i == 0)
            {
                Console.Write("\b \b");
                Console.Write($"{i}");
                Thread.Sleep(_secondTime);
                Console.Write("\b \b");
            }
            // Everything in between
            else
            {
                Console.Write("\b \b");
                Console.Write($"{i}");
                Thread.Sleep(_secondTime);
            }
        }
        // Reset the cursor back to visibile.
        Console.CursorVisible = _previousCursor;
        Console.WriteLine("");
    }
}