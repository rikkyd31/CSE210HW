public class Biking : Activity
{
    // Constructor
    public Biking() : base("Biking")
    {
        
    }

    // Override the abstract GetDistance() method in the base Activity class.
    public override double GetDistance()
    {
        _distance = _length / (SECONDS / _speed);

        return _distance;
    }

    // Override the abstract GetSpeed() method in the base Activity class.
    public override double GetSpeed()
    {
        return _speed;
    }

    // Override the abstract GetPace() method in the base Activity class.
    public override double GetPace()
    {
        _pace = SECONDS / _speed;

        return _pace;
    }

    // Setter
    public void SetSpeed(double speed)
    {
        _speed = speed;
    }
}