class Fraction
{
    private int _top;
    private int _bottom;

    // Default Constructor
    public Fraction()
    {
        // Intialize attributes
        _top = 1;
        _bottom = 1;
    }

    // Non-Default Constructor
    public Fraction(int WholeNumber)
    {
        _top = WholeNumber;
        _bottom = 1;
    }

    // Non-Default Constructor 2
    public Fraction(int userTop, int userBottom)
    {
        _top = userTop;
        _bottom = userBottom;
    }

    public int GetTop()
    {
        return _top;   
    }

    public void SetTop(int userTop)
    {
        _top = userTop;   
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int userBottom)
    {
        // Cannot Divide by Zero
        if (userBottom == 0)
        {
            // Set it to 1 as an arbitrary value
            _bottom = 1;
        }
        else
        {
            _bottom = userBottom;
        }
    }

    public string GetFractionString()
    {
        // Add string formatting to make it look like a fraction
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }

    public double GetDecimalValue()
    {
        // This ensures both the _top and _bottom attributes will be treated as doubles
        return (double)_top / (double)_bottom;
    }
}

