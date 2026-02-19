using System.Dynamic;

public class ScriptureReference
{
    // Attributes
    private int _randomInteger;
    private string _blankString;
    private bool _isNumber;
    private int _hiddenWords;

    // Default Constructor
    public ScriptureReference()
    {
        _blankString = "---";
        _isNumber = false;
        _hiddenWords = 0;
    }

    // Methods


    // Custom Method
    public void HideRandWords(int numberRandom, List<string> verses)
    {
        
        // Create a newWords instance of the ScriptureWords class
        // Feed in the List<string> verses into the newWords constructor
        ScriptureWords newWords = new ScriptureWords();

        // Get the size of the total list of verses.
        // We already fed in the verses into the constructor
        int versesSize = newWords.GetListSize(verses);
        Random randomGenerator = new Random();

        for (int i = 0; i < numberRandom; i++)
        {
            _blankString = "---";

            // Ensure that there are more hiding spots.
            if (_hiddenWords == versesSize)
            {
                Console.WriteLine("No more words left to hide.");
                Console.WriteLine("");
                break;
            }

            // Keep regenerating a hiding spot until it finds a spot not already hidden.
            while (_blankString == "---")
            {
                // Generate a random integer between 1 and the length
                // of all the strings in the verses.
                _randomInteger = randomGenerator.Next(1, versesSize);

                // Replace the word at the randomInteger location with "---"
                _blankString = newWords.HideWord(_randomInteger, verses);

                // Check to see if the word being hidden is the verse number
                _isNumber = int.TryParse(_blankString, out _);

                // Since the word is the verse number, it should not be hidden
                // We need to rehide the word, and keep the loop going by leaving _blankString as "---"
                if (_isNumber == true)
                {
                    _blankString = "---";
                }

                _hiddenWords = 0;
                foreach (string word in verses)
                {
                    _isNumber = int.TryParse(word, out _);

                    // Count hidden words and verse numbers
                    if (_isNumber == true || word == "---")
                    {
                        _hiddenWords = _hiddenWords + 1;
                    }
                }

                if (_hiddenWords == versesSize)
                {
                    break;
                }
            }
        }
    }
}