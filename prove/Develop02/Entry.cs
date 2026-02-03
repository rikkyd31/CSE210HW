using System.ComponentModel;
using System.Runtime;
using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public string _randomPrompt;
    public string _userInput;
    public List<string> _fullEntry = [""];
    

    // Constructor
    public Entry()
    {
        
    }

    
    public List<string> GetUserEntry()
    {
        // Create a new object of the DateTime class called currentDate
        DateTime currentDate = DateTime.Now;
        string dateText = currentDate.ToShortDateString();

        // Create an instance of the Prompt class called newPrompt, as an object
        Prompt newPrompt = new Prompt();

        // Create a string called randomPrompt, which access the GetRandomPrompt method of the newPrompt object
        _randomPrompt = newPrompt.GetRandomPrompt();

        // Pass in the randomPrompt string and dateText string
        // into the DisplayRandomPrompt method of the newPrompt object
        newPrompt.DisplayRandomPrompt(_randomPrompt, dateText);
        Console.Write("> ");
        _userInput = Console.ReadLine();

        // Add the Date, Prompt, and User Response the the _fullEntry List
        _fullEntry.Add($"Date: {dateText}");
        _fullEntry.Add($"Prompt: {_randomPrompt}");
        _fullEntry.Add(_userInput);

        return _fullEntry;
    }
}