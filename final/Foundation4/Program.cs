using System;

class Program
{
    static void Main(string[] args)
    {
        /* Create Variables */
        // Main Variables
        List<Activity> activityList = new List<Activity>();

        // Running Variables
        int runningLength = 60;
        DateOnly runningDate = new DateOnly(2026, 3, 31);
        double runningDistance = 10;

        // Swimming Variables
        int swimmingLength = 60;
        DateOnly swimmingDate = new DateOnly(2026, 2, 14);
        int swimmingLaps = 40;

        // Biking Variables
        int bikingLength = 60;
        DateOnly bikingDate = new DateOnly(2026, 1, 13);
        double bikingSpeed = 10;

        /* Create Objects */
        // Create Running Object
        Running myRunning = new Running();

        myRunning.SetLength(runningLength);
        myRunning.SetDate(runningDate);
        myRunning.SetDistance(runningDistance);

        activityList.Add(myRunning);

        // Create Swimming Object
        Swimming mySwimming = new Swimming();

        mySwimming.SetLength(swimmingLength);
        mySwimming.SetDate(swimmingDate);
        mySwimming.SetLaps(swimmingLaps);

        activityList.Add(mySwimming);

        // Create Biking Object
        Biking myBiking = new Biking();

        myBiking.SetLength(bikingLength);
        myBiking.SetDate(bikingDate);
        myBiking.SetSpeed(bikingSpeed);

        activityList.Add(myBiking);

        /* Display Summary */
        Console.WriteLine("Summary of Activities:");
        Console.WriteLine("");

        foreach (Activity activity in activityList)
        {
            activity.GetSummary();
        }

        
    }
}