public class Swimming : Activity
{
    // Attributes
    const double LAP_LENGTH = 50;
    const double KM_LENGTH = 1000;
    const double MILE_CONVERSION = 0.62;
    private int _nummberLaps;
    

    // Constructor
    public Swimming() : base("Swimming")
    {
        
    }

    // Override the abstract GetDistance() method in the base Activity class.
    public override double GetDistance()
    {
        _distance = (_nummberLaps * LAP_LENGTH / KM_LENGTH) * MILE_CONVERSION;

        return _distance;
    }

    // Override the abstract GetSpeed() method in the base Activity class.
    public override double GetSpeed()
    {
        // Calculate without using any special variables
        _speed = (((_nummberLaps * LAP_LENGTH / KM_LENGTH) * MILE_CONVERSION) / _length) * SECONDS;

        return _speed;
    }

    // Override the abstract GetPace() method in the base Activity class.
    public override double GetPace()
    {
        // Calculate without using any special variables
        _pace = _length / ((_nummberLaps * LAP_LENGTH / KM_LENGTH) * MILE_CONVERSION);

        return _pace;
    }

    // Setter
    public void SetLaps(int numberLaps)
    {
        _nummberLaps = numberLaps;
    }


}