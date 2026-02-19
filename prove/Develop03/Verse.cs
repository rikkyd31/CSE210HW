using System.Runtime.CompilerServices;

public class ScriptureWords
{
    // Attributes

    // {"Trust", "in", "the", "Lord", ... }
    private List<string> _verse = new List<string>();
    private string _blankString;
    private bool _isNumber;

    // Default Constructor
    public ScriptureWords()
    {
        _blankString = "---";
        _isNumber = false;
    }

    // Getter Method
    public List<string> GetScriptureWords()
    {
        return _verse;
    }

    // Setter Method
    public void SetScriptureVerse(List<string> verse)
    {
        _verse = verse;
    }

    // Custom Method to replace a word at a random location
    // passed in as an argument with three dashes "---"
    public string HideWord(int randKey, List<string> verses)
    {
        // Check to see if the word being hidden is the verse number
        _isNumber = int.TryParse(verses[randKey], out _);

        // Check to see if the word is already hidden.
        if (verses[randKey] != "---" && _isNumber == false)
        {
            _blankString = verses[randKey];
            verses[randKey] = "---";
        }

        if (_isNumber == true)
        {
            _blankString = verses[randKey];
        }

        // Return the word, prior to being hidden.
        return _blankString;
    }


    // Return the size of the list
    public int GetListSize(List<string> verses)
    {
        int listSize = verses.Count;
        return listSize;
    }
}