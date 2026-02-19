using System.ComponentModel;
using System.Dynamic;
using System.IO.Compression;

public class Scriptures
{
    // Attributes
    private Dictionary<string, List<string>> _scripture = new Dictionary<string, List<String>>();
    private string _fileName;
    private string _currentLine;
    private string _keyValue;
    private int _numberVerses;
    private string _referenceHeader;
    private string _verseSplitter;
    private bool _isNumber;
    private string _previousWord;
    private List<string> _currentVerses;


    // Default Constructor
    public Scriptures()
    {
        _keyValue = "";
        _numberVerses = 0;
        _referenceHeader = "";
        _verseSplitter = " ";
        _previousWord = " ";
    }

    // Methods
    public Dictionary<string, List<string>> ReadFromFile()
    {
        // Read in the name of the file to load from the user.
        Console.WriteLine("What is the name of the scripture file to load?");
        Console.Write("> ");
        _fileName = Console.ReadLine();
        string file = $"{_fileName}.txt";

        try
        {
            // Create an array to gather all the lines of the txt file.
            string[] lines = System.IO.File.ReadAllLines(file);


            for (int i = 0; i<lines.Length; i++)
            {
                // Set the current line to be a string array called _currentLine
                _currentLine = lines[i];

                // Check to see if the the line is the first line
                // or if the previous line was blank
                // This means this line is a header or the scripture reference itself
                if (i == 0 || string.IsNullOrWhiteSpace(lines[i - 1]))
                {
                    try
                    {
                        // If the current line is a header (not null or whitespace)
                        if (!string.IsNullOrWhiteSpace(_currentLine))
                        {
                            _keyValue = _currentLine;
                            // Create an empty list every time there is a new scripture (follows a blank line.)
                            _currentVerses = new List<string>();
                            
                            // Add key with a new List of Lists as the value.
                            // The Key is the line with the scripture reference,
                            // following the blank line.
                            _scripture.Add(_currentLine, _currentVerses);

                            // Set the Key to a variable, so it stays around.
                            _keyValue = _currentLine;
                            Console.WriteLine(_keyValue);
                        }
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }

                // Ensure that the current line is the the Key Line (The Scripture Reference)
                if (_currentLine != _keyValue && !string.IsNullOrWhiteSpace(_currentLine))
                {    
                    // Set the new empty list to the value at the Key Reference
                    _scripture[_keyValue] = _currentVerses;

                    // Create an array of strings called words
                    // Then split the current line based off " "
                    string[] words = _currentLine.Split(_verseSplitter);
                    foreach (string word in words)
                    {
                        // Add the current word to the list.
                        _currentVerses.Add(word);   
                    }
                }

            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"ReadFromFile Problem: {e.Message}");
        } 
        return _scripture;     
    }

    public string DisplayVerses(int verseNumber, Dictionary<string, List<string>> scripts)
    {
        try
        {
            // Iterate through all the key/value pairs of verses in the dictionary.
            foreach (KeyValuePair<string, List<string>> reference in scripts)
            {
                Console.WriteLine(verseNumber);
                Console.WriteLine(_numberVerses);
                // Select this verse if it is the random verse
                // (or first verse if it is the user's file)
                if (verseNumber == _numberVerses)
                {
                    // Get the scripture reference as the Key to the dictionary
                    _referenceHeader = scripts.ElementAt(verseNumber).Key;
                    
                    // Get the set of verses that go with the reference key
                    _currentVerses = scripts[_referenceHeader];

                    Console.WriteLine(_referenceHeader);
                    // Iterate through each word in the verses to display
                    foreach (string word in _currentVerses)
                    {
                        // Check to see if the word is a number, indicating a verse
                        // The out _ just says we don't need the verse number
                        // We just need to know if it is a number
                        if (_isNumber = int.TryParse(word, out _))
                        {
                            // Write to new line if new verse.
                            Console.WriteLine("");
                            Console.Write($"{word} ");                
                        }
                        else
                        {
                            Console.Write($"{word} ");
                        }
                        _previousWord = word;
                        
                    }

                    Console.WriteLine("");
                    break;
                }
                _numberVerses = _numberVerses + 1;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"DisplayVerses Problem: {e.Message}");
        }
        return _referenceHeader;
    }
}