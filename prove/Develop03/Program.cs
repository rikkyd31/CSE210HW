using System;

class Program
{
    static void Main(string[] args)
    {
        const string QUIT_INPUT = "quit";
        const string Q_INPUT = "q";
        const string LOAD_INPUT = "load";
        const string L_INPUT = "l";
        const string YES_INPUT = "yes";
        const string Y_INPUT = "y";
        const string NO_INPUT = "no";
        const string N_INPUT = "n";
        string userInput;
        string referenceHeader;
        string randomString;
        int verseNumber;
        int randomHidden = 0;
        bool keepHiding;
        bool hiddenIsNumber = false;
        string userHiding;
        Dictionary<string, List<string>> scriptureRef;
        List<string> scriptureList;

        do
        {
            Console.WriteLine("Welcome to the Scripture Memorizer.");
            Console.WriteLine("Press L to Load a scripture from a text file to memorize.");
            Console.WriteLine("Press Q to Quit.");
            Console.Write("> ");
            userInput = Console.ReadLine();
            Console.WriteLine("");

            if (userInput.ToLower() == QUIT_INPUT || userInput.ToLower() == Q_INPUT)
            {
                Console.WriteLine("Ending Program");
                break;
            }
            else if (userInput.ToLower() == LOAD_INPUT || userInput.ToLower() == L_INPUT)
            {
                // Create a new instance of the LoadScriptures class
                // Then call the ReadFromFile method
                Scriptures LoadScriptures = new Scriptures();
                scriptureRef = LoadScriptures.ReadFromFile();

                // Assume the user always wants to memorize the first scripture in the file.
                verseNumber = 0;

                // Display The scripture first.
                referenceHeader = LoadScriptures.DisplayVerses(verseNumber, scriptureRef);

                keepHiding = true;
                try
                {
                    while (keepHiding == true)
                    {
                        hiddenIsNumber = false;
                        while (hiddenIsNumber == false)
                        {
                            try
                            {
                                // Ask the user how many words they want to hide
                                Console.WriteLine("How many words would you like to hide?");
                                Console.Write("Enter a number: ");
                                randomString = Console.ReadLine();
                                randomHidden = int.Parse(randomString);
                                hiddenIsNumber = true;   
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine("Not a number");
                                Console.WriteLine($"Error: {e.Message}");
                                Console.WriteLine("");
                                hiddenIsNumber = false;
                            }
                        }

                        // Access the list at the appropriate Key in the dictionary
                        scriptureList = scriptureRef[referenceHeader];

                        // Create a new instance of the ScriptureReference Class called newReference
                        ScriptureReference newReference = new ScriptureReference();
                        newReference.HideRandWords(randomHidden, scriptureList);

                        // Display the reference with the hidden words.
                        referenceHeader = LoadScriptures.DisplayVerses(verseNumber, scriptureRef);

                        Console.WriteLine("Would you like to keep hiding words?");
                        Console.Write("Enter Yes or No: ");
                        userHiding = Console.ReadLine();

                        if (userHiding.ToLower() == YES_INPUT || userHiding.ToLower() == Y_INPUT)
                        {
                            keepHiding = true;
                        }
                        else if (userHiding.ToLower() == NO_INPUT || userHiding.ToLower() == N_INPUT)
                        {
                            keepHiding = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input");
                            Console.WriteLine("Please try again");
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Hiding Error: {e.Message}");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine("Please try again");
                Console.WriteLine("");
            }

        }  while (userInput.ToLower() != QUIT_INPUT || userInput.ToLower() != Q_INPUT);
    }
}