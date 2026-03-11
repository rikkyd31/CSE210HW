using System.Runtime.CompilerServices;
using System.IO;

public class Menu
{
    private string _menuChoice; // String for determining the user's menu choice
    private bool _correctInput; // Bool used to keep the menu loop until the user quits
    private bool _correctGoal; // Bool used to ensure the user puts in correct input
    private string _goalType; // String to determining the user's goal choice
    private int _goalNumber; // Int to iterate through the goal list loops
    private int _targetNumber; // Int to find the goal the user accomplished
    private int _totalPoints; // Int that accumulates the user's points
    private int _goalPoints; // Int that stores the specific goals points
    private List<Goal>_goalList = new List<Goal>(); // List that stores all the goal objects. It uses Polymorphism.
    private string _fileName; // String name of file to save goals to.
    private string _classType; // string class type for each goal
    private string _goalName; // String name of goal object
    private string _goalDescription; // String description in goal object
    private bool _isComplete; // Bool that says whether goal object is complete or not
    private int _goalBonus; // Int bonus for checklist goal objects
    private int _goalRepeat; // Int repeats needed for bonus points for checklist goal objects
    private int _timesCompleted; // Int number of times completed for goal objects

    /*
        Constructor for Menu Class. It initializes a few values.
    */
    public Menu()
    {
        _menuChoice = "c";
        _correctInput = true;
        _correctGoal = true;
    }
    
    /*
        Main menu loop method. It has the 6 main options.
    */
    public void GetMenuOption()
    {
        // While loop ensures the user enters a real option, otherwise it keeps looping.
        while (_correctInput == true)
        {
            Console.WriteLine($"Total Points: {_totalPoints}");
            Console.WriteLine("");
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");

            // Get the users menu choice.
            Console.Write("Select a choice from the menu: ");
            _menuChoice = Console.ReadLine();


            // Create a new goal by calling the private NewGoal() method here in the Menu class.
            if (_menuChoice.ToLower() == "create new goal" || _menuChoice.ToLower() == "create" || _menuChoice.ToLower() == "c" || _menuChoice.ToLower() == "1")
            {
                NewGoal();
            }
            // Call the private ListGoals() method here in the Menu class.
            else if (_menuChoice.ToLower() == "list goals" || _menuChoice.ToLower() == "list" || _menuChoice.ToLower() == "li" || _menuChoice.ToLower() == "2")
            {
                ListGoals();
            }
            // Call the private SaveGoals() method here in the Menu class.
            else if (_menuChoice.ToLower() == "save goals" || _menuChoice.ToLower() == "save" || _menuChoice.ToLower() == "s" || _menuChoice.ToLower() == "3")
            {
                SaveGoals();
            }
            // Call the private LoadGoals() method here in the menu class.
            else if (_menuChoice.ToLower() == "load goals" || _menuChoice.ToLower() == "load" || _menuChoice.ToLower() == "lo" || _menuChoice.ToLower() == "4")
            {
                LoadGoals();
            }
            // Record a goal event.
            else if (_menuChoice.ToLower() == "record event" || _menuChoice.ToLower() == "record" || _menuChoice.ToLower() == "r" || _menuChoice.ToLower() == "5")
            {
                // First, it lists all of the goals.
                ListGoals();

                // Then, it asks the user to choose the goal they completed.
                Console.Write("Which goal did you accomplish? ");
                _targetNumber = int.Parse(Console.ReadLine());

                // This is a loop that iterates through the _goalList list until if finds the goal the user chose to complete.
                _goalNumber = 1;
                foreach (Goal goal in _goalList)
                {
                    if (_targetNumber == _goalNumber)
                    {
                        // Once it finds the right goal, it calls the IncrementGoalPoints() public method of the Goal base class (or overriding derived classes)
                        _goalPoints = goal.IncrementGoalPoints();
                    }
                    // Increment the number in the goal list by 1 and restart loop.
                    _goalNumber = _goalNumber + 1;
                }
                // Calculate the total goal points.
                _totalPoints = _totalPoints + _goalPoints;

                if (_goalPoints >= 0)
                {
                    Console.WriteLine($"Congratulations! You earned {_goalPoints} points!");
                }
                else
                {
                    Console.WriteLine($"Oh No! You earned {_goalPoints} points!");
                }
                Console.WriteLine($"You now have {_totalPoints} points.");
                Console.WriteLine("");

            }
            // Ends Program
            else if (_menuChoice.ToLower() == "quit" || _menuChoice.ToLower() == "q" || _menuChoice.ToLower() == "6")
            {
                Console.WriteLine("");
                Console.WriteLine("Ending Program.");
                Console.WriteLine("");
                _correctInput = false;
                break;
            }
            // Catch if the user does not enter a menu option to restart the menu loop.
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Invalid Input.");
                Console.WriteLine("Please Try again.");
                Console.WriteLine("");
                _correctInput = true;
            }
        }
    }

    /*
        This hosts the new goal sub-menu, with three goal options to create.
    */
    private void NewGoal()
    {
        _correctGoal = true;

        // Loop ensures the user enters a valid goal option to create.
        while (_correctGoal == true)
        {
            Console.WriteLine("The three types of goals:");
            Console.WriteLine(" 1. Simple Goal");
            Console.WriteLine(" 2. Eternal Goal");
            Console.WriteLine(" 3. Checklist Goal");
            Console.WriteLine(" 4. Negative Goal");

            // Get goal option from the user.
            Console.Write("Which type of goal would you like to create? ");
            _goalType = Console.ReadLine();
        
            if (_goalType.ToLower() == "simple goal" || _goalType.ToLower() == "simple" || _goalType.ToLower() == "s" || _goalType.ToLower() == "1")
            {
                // Create a new instance of the SimpleGoal class.
                SimpleGoal mySGoal = new SimpleGoal();
                // Call the CreateGoal parent method from Goal class (SimpleGoal has no such method) of the mySGoal object.
                mySGoal.CreateGoal();
                // Add the mySGoal object to the _goalList list of Goal child objects.
                _goalList.Add(mySGoal);
                _correctGoal = false; // End loop
            }
            else if (_goalType.ToLower() == "eternal goal" || _goalType.ToLower() == "eternal" || _goalType.ToLower() == "e" || _goalType.ToLower() == "2")
            {
                // Create a new instance of the EternalGoal class.
                EternalGoal myEGoal = new EternalGoal();
                // Call the CreateGoal override method of the myEGoal object.
                myEGoal.CreateGoal();
                // Add the myEGoal object to the _goalList list of Goal child objects.
                _goalList.Add(myEGoal);
                _correctGoal = false; // End loop
            }
            else if (_goalType.ToLower() == "checklist goal" || _goalType.ToLower() == "checklist" || _goalType.ToLower() == "c" || _goalType.ToLower() == "3")
            {
                // Create a new instance of the ChecklistGoal class.
                ChecklistGoal myCGoal = new ChecklistGoal();
                // Call the CreateGoal override method of the myCGoal object.
                myCGoal.CreateGoal();
                // Add the myCGoal object to the _goalList list of Goal child objects.
                _goalList.Add(myCGoal);
                _correctGoal = false; // End loop
            }
            else if (_goalType.ToLower() == "negative goal" || _goalType.ToLower() == "negative" || _goalType.ToLower() == "n" || _goalType.ToLower() == "4")
            {
                // Create new instance of the NegativeGoal class.
                NegativeGoal myNGoal = new NegativeGoal();
                // Call the CreateGoal override method of the myNGoal object.
                myNGoal.CreateGoal();
                // Add the myNGoal object to the _goalList list of Goal child objects.
                _goalList.Add(myNGoal);
                _correctGoal = false; // End loop
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Invalid Input.");
                Console.WriteLine("Please Try again.");
                Console.WriteLine("");
                _correctGoal = true;
            }
        }
    }

    /*
        Simple method that lists the goal objects (including child objects) in the _goalList list.
    */
    private void ListGoals()
    {
        // Iterate through each Goal child object in the _goalList list.
        _goalNumber = 1;
        foreach (Goal goal in _goalList)
        {
            // Call the ListGoal method of the Goal child objects.
            goal.DisplayGoal(_goalNumber);
            _goalNumber = _goalNumber + 1;
        }      
        Console.WriteLine(""); 
    }

    /*
        This method saves the _goalList list of goal objects to a txt file.
        It is essentially the opposite of the LoadGoals() private method.
    */
    private void SaveGoals()
    {
        Console.Write("What is the name of the goal file to save? ");
        _fileName = Console.ReadLine();
    
        // Using the special StreamWriter class to write to the file (Requires using System.IO)
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            // The first line should be the total points the user has.
            outputFile.WriteLine($"{_totalPoints}");

            // Iterate through each goal object in the _goalList list.
            foreach (Goal goal in _goalList)
            {
                // Call a bunch of getters for all class types.
                _classType = goal.GetClassType();
                _goalPoints = goal.GetGoalPoints();
                _goalName = goal.GetGoalName();
                _goalDescription = goal.GetGoalDescription();
                _isComplete = goal.GetIsComplete();

                // Call special getter methods for the checklist class type.
                if (_classType.ToLower() == "checklist goal")
                {
                    _goalBonus = goal.GetBonus();
                    _goalRepeat = goal.GetGoalRepeat();
                    _timesCompleted = goal.GetTimesComplete();
                    // Write to file with complete line of comma seperated values
                    outputFile.WriteLine($"{_classType}||{_goalName}||{_goalDescription}||{_goalPoints}||{_goalBonus}||{_timesCompleted}||{_goalRepeat}");
                }
                else
                {
                    // Write to file with complete line of comma seperated values for all other class types.
                    outputFile.WriteLine($"{_classType}||{_goalName}||{_goalDescription}||{_goalPoints}||{_isComplete}");
                }
            }
        }
    }

    /*
        This private method of the menu class loads goals in the _goalList list from a text file.
        It is essentially the opposite of the SaveGoals() private method.
    */
    private void LoadGoals()
    {
        Console.WriteLine("What is the name of the goal file to load? ");
        _fileName = Console.ReadLine();

        // Use a string array (string[]) called lines that reads in the lines of the file.
        string[] lines = System.IO.File.ReadAllLines(_fileName);

        // Iterate through each string in the array of strings called lines.
        _goalNumber = 1;
        foreach (string line in lines)
        {
            // Grab the total user points from the first line.
            if (_goalNumber == 1)
            {
                _totalPoints = int.Parse(line);
            }
            // Split by comma for all other lines.
            else
            {
               string[] parts = line.Split("||");

                // Grab the basic parts for each goal object
                _classType = parts[0];
                _goalName = parts[1];
                _goalDescription = parts[2];
                _goalPoints = int.Parse(parts[3]);
                
                // Grab the specialty parts for checklist goal objects
                if (_classType.ToLower() == "checklist goal")
                {
                    _goalBonus = int.Parse(parts[4]);
                    _timesCompleted = int.Parse(parts[5]);
                    _goalRepeat = int.Parse(parts[6]);
                }
                // Grab the specialty parts for all other goal objects
                else
                {
                    _isComplete = bool.Parse(parts[4]);
                }


                // Create a new CheckList object called myChecklist
                // and set the values in the object from the text file.
                if (_classType.ToLower() == "checklist goal")
                {
                    ChecklistGoal myChecklist = new ChecklistGoal();

                    myChecklist.SetGoalBonus(_goalBonus);
                    myChecklist.SetGoalRepeat(_goalRepeat);
                    myChecklist.SetTimesComplete(_timesCompleted);
                    myChecklist.SetGoalName(_goalName);
                    myChecklist.SetGoalDescription(_goalDescription);
                    myChecklist.SetGoalPoints(_goalPoints);

                    _goalList.Add(myChecklist);
                }
                // Create a new EternalGoal object called myEternal
                // and set the values in the object from the text file.
                else if (_classType.ToLower() == "eternal goal")
                {
                    EternalGoal myEternal = new EternalGoal();

                    myEternal.SetGoalPoints(_goalPoints);
                    myEternal.SetGoalDescription(_goalDescription);
                    myEternal.SetGoalName(_goalName);
                    myEternal.SetIsComplete(_isComplete);

                    _goalList.Add(myEternal);
                }
                // Create a new SimpleGoal object called mySimple
                // and set the values in the object from the text file.
                else if (_classType.ToLower() == "simple goal")
                {
                    SimpleGoal mySimple = new SimpleGoal();

                    mySimple.SetGoalPoints(_goalPoints);
                    mySimple.SetGoalDescription(_goalDescription);
                    mySimple.SetGoalName(_goalName);
                    mySimple.SetIsComplete(_isComplete);

                    _goalList.Add(mySimple);
                }
                // Create a new NegativeGoal object called myNegative
                // and set the values in the object from the text file.
                else if (_classType.ToLower() == "negative goal")
                {
                    NegativeGoal myNegative = new NegativeGoal();

                    myNegative.SetGoalPoints(_goalPoints);
                    myNegative.SetGoalDescription(_goalDescription);
                    myNegative.SetGoalName(_goalName);
                    myNegative.SetIsComplete(_isComplete);

                    _goalList.Add(myNegative);
                }
                // Not actually used, but this would be just a default parent goal.
                else
                {
                    Goal myGoal = new Goal();

                    myGoal.SetGoalPoints(_goalPoints);
                    myGoal.SetGoalDescription(_goalDescription);
                    myGoal.SetGoalName(_goalName);
                    myGoal.SetIsComplete(_isComplete);

                    _goalList.Add(myGoal);
                } 
            }
            // Line incrementer to distinguish the first line of the text file.
            _goalNumber = _goalNumber + 1;         
        }
    }
}
