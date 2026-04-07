public class Running : Activity
{
    // Constructor
    public Running() : base("Running")
    {
        
    }

    // Override the abstract GetDistance() method in the base Activity class.
    public override double GetDistance()
    {
        return _distance;
    }

    // Override the abstract GetSpeed() method in the base Activity class.
    public override double GetSpeed()
    {
        _speed = (_distance / _length) * SECONDS;

        return _speed;
    }

    // Override the abstract GetPace() method in the base Activity class.
    public override double GetPace()
    {
        _pace = (_length / _distance);

        return _pace;
    }
    

    public void SetDistance(double distance)
    {
        _distance = distance;
    }

}