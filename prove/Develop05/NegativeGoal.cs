public class NegativeGoal : Goal
{
    /*
        Constructor
    */
    public NegativeGoal() : base()
    {
        
    }

    /*
        This method just gets goal information from the user and stores it in the object's attributes.
        It overrides the standard method in the Goal class.
    */
    public override void CreateGoal()
    {
        Console.WriteLine("Negative Goals are bad habits you want to avoid doing.");
        Console.WriteLine("They give you negative points.");
        Console.Write("What is the name of your negative goal? ");
        _goalName = Console.ReadLine();

        Console.Write("What is a short description of your negative goal? ");
        _goalDescription = Console.ReadLine();

        Console.Write("What is the amount of points associated with this negative goal? (enter a negative number): ");
        _goalPoints = int.Parse(Console.ReadLine());

        // Convert to negative if the user forgets.
        if (_goalPoints > 0)
        {
            _goalPoints = _goalPoints * -1;
        }
    }

    /*
        Returns the name of the class type for saving the class object to a text file.
    */
    public override string GetClassType()
    {
        _classType = "Negative Class";
        return _classType;
    }

    /*
        Overrides the SetGoalPoints in the parent class to ensure goalPoints are always negative.
    */
    public override void SetGoalPoints(int goalPoints)
    {
        if (goalPoints >= 0)
        {
            _goalPoints = (goalPoints * -1);
        }
        else
        {
            _goalPoints = goalPoints;
        }
    }
}