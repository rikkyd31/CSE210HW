public class Breathing : Activity
{
    private string _breathingPartOne;
    private string _breathingPartTwo;
    private string _breathingPartThree;

    // Derived constructor pushes activity type to the main constructor Activity.
    public Breathing() : base("Breathing")
    {
        _breathingPartOne = "This activity will help you relax by walking you through your breathing slowly.";
        _breathingPartTwo = "You will practice breathing in and out.";
        _breathingPartThree = "Clear your mind and focus on your breathing.";
        _totalTime = 0;
    }

    /*
        This method just displays the description for the breathing activity.
    */
    public void DisplayBreathingDescription()
    {
        Console.WriteLine(_breathingPartOne);
        Console.WriteLine(_breathingPartTwo);
        Console.WriteLine(_breathingPartThree);
        Console.WriteLine("");
    }

    /*
        This is the main method for the breathing activity.
        It uses a series of loops to guide the users breathing.
    */
    public void DisplayBreaths(int _sessionTime)
    {
        // Convert session time to standard.
        _sessionTime = _sessionTime * 1000;

        // Hide the Cursor
        Console.CursorVisible = false;

        // Do a full breathing session while the elapsed time is less than the total time.
        while ( _totalTime < _sessionTime)
        {
            // Count Down while Breathing In
            Console.Write("Breathe In...");
            for (int i = 5; i >= 0; i--)
            {
                // If it is the last second of breathing in
                if (i == 0)
                {
                    // Remove the second counter
                    Console.Write("\b \b");
                    CalculateTotalTime();
                }
                // If it is the first second of breathing in
                else if (i == 5)
                {
                    // Don't remove anything, just display the second counter
                    Console.Write($"{i}");
                    CalculateTotalTime();
                }
                // For all other seconds
                else
                {
                    Console.Write("\b \b");
                    Console.Write($"{i}");
                    CalculateTotalTime();
                }
            }
            Console.WriteLine("");

            // Cound Down while Breathing Out
            Console.Write($"Breathe Out...");
            for (int i = 5; i >= 0; i--)
            {
                // If it is the last lescond of breathing out
                if (i == 0)
                {
                    // Remove the second counter
                    Console.Write("\b \b");
                    CalculateTotalTime();
                }
                // If it is the first second of breathing out
                else if (i == 5)
                {
                    // Don't remove anything, just display the second counter
                    Console.Write($"{i}");
                    CalculateTotalTime();
                }
                // For all other seconds
                else
                {
                    Console.Write("\b \b");
                    Console.Write($"{i}");
                    CalculateTotalTime();
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            // A full breathing session takes 12 seconds. 
        }
        // Reset Cursor to visible.
        Console.CursorVisible = _previousCursor;
    }
    
    /*
        This private method elapses for a second
        and adds that second to the total time.
    */
    private void CalculateTotalTime()
    {
        Thread.Sleep(_secondTime);
        _totalTime = _totalTime + _secondTime;
    }
}