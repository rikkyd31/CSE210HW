public class Goal
{
    // These attributes are all protected, meaning the child classes can access them and use them.
    // Strings
    protected string _goalType;
    protected string _goalName;
    protected string _goalDescription;
    protected string _xComplete;
    protected string _lineGoal;
    protected string _classType;
    // Bools
    protected bool _isComplete;
    // Ints
    protected int _timesCompleted;
    protected int _goalBonus;
    protected int _goalRepeat;
    protected int _goalPoints;

    /*
        Constructor for Goal base class. It initializes some attributes.
    */
    public Goal()
    {
        // Either X or blank space. Initialized as blank space.
        _xComplete = " ";

        _timesCompleted = 0;
        _goalPoints = 0;
        _isComplete = false;
        _goalBonus = 0;
    }

    /*
        This method just gets goal information from the user and stores it in the object's attributes.
    */
    public virtual void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        _goalDescription = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        _goalPoints = int.Parse(Console.ReadLine());
    }

    /*
        This method displays the goal objects information when the ListGoals() method is called in the Menu class.
    */
    public virtual void DisplayGoal(int listNumber)
    {
        _lineGoal = $"{listNumber}. [{_xComplete}] {_goalName} ({_goalDescription})";
        Console.WriteLine(_lineGoal);
    }

    /*
        This method gets user information for the goal they completed when the CreateEvent() method is called in the Menu class.
    */
    public virtual string RecordEvent()
    {
        Console.Write("Which goal did you accomplish? ");
        _goalType = Console.ReadLine();

        return _goalType;
    }

    /*
        This method increments the times a goal object has been completed, and sets it to complete
        when the CreateEvent() method is called in the Menu class.
    */
    public virtual int IncrementGoalPoints()
    {
        _timesCompleted = _timesCompleted + 1;
        _xComplete = "X";
        _isComplete = true;

        return _goalPoints;
    }

    /*
        Getters
    */
    public virtual string GetClassType()
    {
        _classType = "Parent Class";
        return _classType;
    }

    public virtual int GetGoalPoints()
    {
        return _goalPoints;
    }

    public virtual string GetGoalName()
    {
        return _goalName;
    }

    public virtual string GetGoalDescription()
    {
        return _goalDescription;
    }

    public virtual bool GetIsComplete()
    {
        return _isComplete;
    }

    public virtual int GetBonus()
    {
        return _goalBonus;
    }

    public virtual int GetGoalRepeat()
    {
        return _goalRepeat;
    }

    public virtual int GetTimesComplete()
    {
        return _timesCompleted;
    }

    /*
        Setters
    */
    public virtual void SetGoalPoints(int goalPoints)
    {
        _goalPoints = goalPoints;
    }

    public virtual void SetGoalName(string goalName)
    {
        _goalName = goalName;
    }

    public virtual void SetGoalDescription(string goalDescription)
    {
        _goalDescription = goalDescription;
    }

    public virtual void SetGoalBonus(int goalBonus)
    {
        _goalBonus = goalBonus;
    }

    public virtual void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
        if (isComplete == true)
        {
            _xComplete = "X";   
        }
        else
        {
            _xComplete = " ";
        }
    }

    public virtual void SetTimesComplete(int timesCompleted)
    {
        _timesCompleted = timesCompleted;
    }

    public virtual void SetGoalRepeat(int goalRepeat)
    {
        _goalRepeat = goalRepeat;
    }
}