public class Swimming : Activity
{
    // Attributes
    const int LAP_LENGTH = 50;
    const int KM_LENGTH = 1000;
    private int _nummberLaps;
    

    // Constructor
    public Swimming() : base()
    {
        
    }

    public override int GetDistance()
    {
        _distance = _nummberLaps * LAP_LENGTH / KM_LENGTH;

        return _distance;
    }

}