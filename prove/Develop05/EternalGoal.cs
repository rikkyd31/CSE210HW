public class EternalGoal : Goal
{
    
    /*
        Constructor
    */
    public EternalGoal() : base()
    {
        _timesCompleted = 0;
        _goalPoints = 0;
        _xComplete = " ";
        _isComplete = false;
    }

    /*
        Since EternalGoal objects can never be complete, ensure _xComplete is blank.
    */
    public override int IncrementGoalPoints()
    {
        _timesCompleted = _timesCompleted + 1;
        _xComplete = " ";
        _isComplete = false;

        return _goalPoints;
    }

    /*
        Getters
    */
    public override int GetGoalPoints()
    {
        _timesCompleted = _timesCompleted + 1;

        return _goalPoints;
    }

    public override string GetClassType()
    {
        _classType = "Eternal Goal";
        return _classType;
    }

    public override bool GetIsComplete()
    {
        return _isComplete;
    }

}