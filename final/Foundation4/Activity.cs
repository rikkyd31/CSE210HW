public class Activity
{
    // Attributes
    protected DateOnly _date;
    protected int _length;
    protected int _speed;
    protected int _distance;
    protected int _pace;


    // Constructor
    Activity()
    {
        
    }

    // Getters
    public virtual int GetSpeed()
    {
        _speed = (_distance / _length) * 60;

        return _speed;
    }

    public virtual int GetDistance()
    {
        _distance = _length / _pace;

        return _distance;
    }

    public virtual int GetPace()
    {
        _pace = _length / _distance;

        return _pace;
    }

    public void GetSummary()
    {
        
    }


}