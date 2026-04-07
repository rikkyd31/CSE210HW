public class Running : Activity
{
    // Attributes
    

    // Constructor
    public Running() : base()
    {
        
    }

    public override int GetDistance()
    {
        return _distance;
    }

    public void SetDistance(int distance)
    {
        _distance = distance;
    }


}