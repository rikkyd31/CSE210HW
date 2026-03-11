// Kind of a small class with the way my program is setup.
public class SimpleGoal : Goal
{
    /*
        Constructor
    */
    public SimpleGoal() : base()
    {
        _goalPoints = 0;
        _isComplete = false;
        _xComplete = " ";
    }

    /*
        This getter helps the LoadGoals() method in Menu class to know which class type to create.
    */
    public override string GetClassType()
    {
        _classType = "Simple Goal";
        return _classType;
    }

}