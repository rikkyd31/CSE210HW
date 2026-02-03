public class Journal
{

    public List<List<string>> _journal = [[""]];
    public string _entry = "";

    // Constructor
    public Journal()
    {
        
    }

    // Create a new method that gets the list of the date, prompt,
    // and user entry and then adds that to the journal super list
    public List<List<string>> AddEntryToJournal(List<List<string>> _journal)
    {
        // Create a new object of the Entry class called newEntry
        Entry newEntry = new Entry();
        
        // Assign the string journalPrompt to the return value
        // of the GetUserEntry method of the newEntry object.
        List<string> journalPrompt = newEntry.GetUserEntry();

        // Add the string journalPrompt to the List _journal
        _journal.Add(journalPrompt);
        return _journal;
    }

    // Create a new method that iterates through each entry
    // in the journal super list using two foreach loops.
    public void DisplayJournal(List<List<string>> _journal)
    {
        foreach (List<string> _fullEntry in _journal)
        {
            foreach (string _entry in _fullEntry)
            {
                Console.WriteLine(_entry);
            }

            // Add an extra line space between each main entry
            Console.WriteLine("");
        }
    }
}