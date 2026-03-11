public class ChecklistGoal : Goal
{
    /*
        Constructor. Intializes a few Attributes.
    */
    public ChecklistGoal() : base()
    {
        _timesCompleted = 0;
        _xComplete = " ";
        _isComplete = false;
        _goalPoints = 0;
        _goalRepeat = 1;
        _goalBonus = 0;
    }

    // Overrides the CreateGoal method in the parent class, since checklist goal objects requrie additional information.
    public override void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();

        Console.Write("What is a short description of your goal? ");
        _goalDescription = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        _goalPoints = int.Parse(Console.ReadLine()); 

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _goalRepeat = int.Parse(Console.ReadLine());

        Console.Write($"What are the bonus points for accomplishing it {_goalRepeat} times? ");
        _goalBonus = int.Parse(Console.ReadLine());
    }

    /*
        Overrides DisplayGoal method in base class, since Checklist Goals display more information.
    */
    public override void DisplayGoal(int listNumber)
    {
        _lineGoal = ($"{listNumber}. [{_xComplete}] {_goalName} ({_goalDescription}) -- Currently Completed: {_timesCompleted}/{_goalRepeat}");
        Console.WriteLine(_lineGoal);
    }

    /*
        Overrides IncrementGoalPoints method in base class, since Checklist goals require more complicated logic.
    */
    public override int IncrementGoalPoints()
    {

        _timesCompleted = _timesCompleted + 1;

        if (_timesCompleted == _goalRepeat)
        {
            _goalPoints = _goalBonus + _goalPoints;
            _xComplete = "X";
            _isComplete = true;
        }
        else if (_timesCompleted > _goalRepeat)
        {
            _isComplete = true;
            _xComplete = "X";
        }

        return _goalPoints;
    }

    /*
        Getters
    */
    public override string GetClassType()
    {
        _classType = "Checklist Goal";
        return _classType;
    }

    public override bool GetIsComplete()
    {
        return _isComplete;
    }
}