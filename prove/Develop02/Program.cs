using System;
using System.IO; 

class Program
{

    public bool _interfaceDisplay;
    public string _userResponse;

    static void Main(string[] args)
    {
        Program myProgram = new Program();
        myProgram.GetUserInterface();
    }

    public void DisplayInterface()
    {
        // Display all of the options to the user
        Console.WriteLine("Please Select one of the Following Choices");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
        
    }

    // This method calls the DisplayInterface method inside of a loop
    // and then gets the user input to execute one of the options
    public void GetUserInterface()
    {
        // Create a new instance of the Journal class called journalObj
        Journal journalObj = new Journal();
            
        // Access the _journal field of the journalObj object
        List<List<string>> journalList = journalObj._journal;

        // Call the DisplayInterface method, and then get the user input.
        // Loop through the options until the user enters correct inptut.
        _interfaceDisplay = true;
        while (_interfaceDisplay == true)
        {
            DisplayInterface();
            Console.WriteLine("What would you like to do?");
            Console.Write("> ");
            _userResponse = Console.ReadLine();

            if (_userResponse == "1" || _userResponse.ToLower() == "write" || _userResponse.ToLower() == "w")
            {
                // update the journalList variable by calling the AddEntryToJournal method
                // of the journalObj object of the Journal class
                journalObj.AddEntryToJournal(journalList);

                _interfaceDisplay = true;
            }
            else if (_userResponse == "2" || _userResponse.ToLower() == "display" || _userResponse.ToLower() == "d")
            {
                // Call the DisplayJournal method of the journalObj object of the Journal class
                journalObj.DisplayJournal(journalList);
                _interfaceDisplay = true;
            }
            else if (_userResponse == "3" || _userResponse.ToLower() == "load" || _userResponse.ToLower() == "l")
            {
                // Ask the user of the file name to load and save it as a string
                Console.WriteLine("What is the name of the file to load?");
                Console.Write("> ");
                string fileName = Console.ReadLine();
                Console.WriteLine("What is the name of the file type to load (csv or txt)?");
                Console.Write("> ");
                string fileLoadType = Console.ReadLine();
                string file = $"{fileName}.{fileLoadType}";
                
                string[] lines = System.IO.File.ReadAllLines(file);
                List<string>journalLineEntry = [""];

                foreach(string line in lines)
                {
                    if (fileLoadType.ToLower() == "csv")
                    {
                        // if (line != "")
                        // {
                        //     Console.WriteLine(line);
                        //     string[] parts = line.Split(",");

                        //     string datePart = parts[0];
                        //     Console.WriteLine($"{datePart}");
                        //     journalLineEntry.Add(datePart);

                        //     string promptPart = parts[1];
                        //     Console.WriteLine($"Prompt: {promptPart}");
                        //     journalLineEntry.Add(promptPart);
                            
                        //     string responsePart = parts[2];
                        //     Console.WriteLine($"Response: {responsePart}");
                        //     journalLineEntry.Add(responsePart);
                        // }         

                        // Do not know how to make csv work.              
                    }
                    else
                    {
                        {
                            journalLineEntry.Add(line);
                            Console.WriteLine(line);
                        }

                    }

                }
                journalList.Add(journalLineEntry);
                _interfaceDisplay = true;
            }
            else if (_userResponse == "4" || _userResponse.ToLower() == "save" || _userResponse.ToLower() == "s")
            {
                // Get the name of the file to be saved as
                Console.WriteLine("What name should this file be saved as?");
                Console.Write("> ");
                string fileSave = Console.ReadLine();

                // Get the file type for the file to be saved as (csv or txt)
                Console.WriteLine("What type should this file be saved as (txt or csv)?");
                Console.Write("> ");
                string fileType = Console.ReadLine();
                string file = $"{fileSave}.{fileType}";

                // Create an object of the streamWriter class to save file
                using (StreamWriter outputFile = new StreamWriter(file))
                {
                    // Iterate through each journal day with foreach loop
                    foreach(List<string> journalDay in journalList)
                    {
                        // Iterate through each day element with foreach loop
                        foreach(string journalLine in journalDay)
                        {
                            // Write output line to the saved file.
                            if (fileType.ToLower() == "csv")
                            {
                                outputFile.Write(journalLine);
                                outputFile.Write(",");   
                            }
                            else
                            {
                                outputFile.WriteLine(journalLine);
                            }
                        }
                        // Add spacer line at the end of each day.
                        outputFile.WriteLine("");
                    }
                }
                
                _interfaceDisplay = true;   
            }
            else if (_userResponse == "5" || _userResponse.ToLower() == "quit" || _userResponse.ToLower() == "q")
            {
                // Display quit message
                Console.WriteLine("");
                Console.WriteLine("Ending Program");
                Console.WriteLine("");
                _interfaceDisplay = false;
            }
            else
            {
                // Print an error message and restart the loop.
                Console.WriteLine("");
                Console.WriteLine("That is not a valid option. Please try again.");
                Console.WriteLine("");
                _interfaceDisplay = true;
            }
        }
    }
}