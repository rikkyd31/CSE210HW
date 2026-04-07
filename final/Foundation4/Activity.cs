// Since there are abstract methods, this could be considered an abstract class
public abstract class Activity
{
    // Attributes
    protected const int SECONDS = 60;
    protected DateOnly _date;
    protected int _length;
    protected string _activityType;
    protected double _speed;
    protected double _pace;
    protected double _distance;


    // Constructor
    public Activity(string activity)
    {
        _activityType = activity;
    }

    // Getters
    /* I use abstract here so that the derived methods can easily override these empty shells */
    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    // Setters
    public void SetDate(DateOnly date)
    {
        _date = date;
    }

    public void SetLength(int length)
    {
        _length = length;
    }

    // Summarizes all the data
    public void GetSummary()
    {
        // Call the three Getter methods first, which will work for each of the derived classes
        _distance = GetDistance();
        _speed = GetSpeed();
        _pace = GetPace();

        // Round distance, pace, and speed
        _distance = Math.Round(_distance, 2); 
        _speed = Math.Round(_speed, 2);
        _pace = Math.Round(_pace, 2);


        Console.WriteLine($"{_date} {_activityType} ({_length} Minutes) - Distance: {_distance} miles, Speed: {_speed} mph, Pace: {_pace} min per mile");
        Console.WriteLine("");
    }


}