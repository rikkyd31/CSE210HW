using System;

class Program
{
    static void Main(string[] args)
    {
        const string USER_QUIT = "quit";
        const string USER_Q = "q";
        const string USER_4 = "4";
        const string USER_BREATHE = "breathe";
        const string USER_BREATHING = "breathing";
        const string USER_BREATH = "breath";
        const string USER_B = "b";
        const string USER_1 = "1";
        const string USER_LISTING = "listing";
        const string USER_LIST = "list";
        const string USER_L = "l";
        const string USER_3 = "3";
        const string USER_REFLECTING = "reflecting";
        const string USER_REFLECT = "reflect";
        const string USER_REFLECTION = "reflection";
        const string USER_R = "r";
        const string USER_2 = "2";

        int sessionTime;
        string userChoice;

        Console.WriteLine("Welcome to the Wellness Program!");
        Console.WriteLine("");

        userChoice = "";

        while (userChoice.ToLower() != USER_QUIT || userChoice.ToLower() != USER_Q || userChoice.ToLower() == USER_4)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity.");
            Console.WriteLine("2. Start Reflecting Activity.");
            Console.WriteLine("3. Start Listing Activity.");
            Console.WriteLine("4. Quit");

            Console.WriteLine("");
            Console.WriteLine("Please Select An Activity:");
            Console.Write("> ");

            userChoice = Console.ReadLine();
            Console.Clear();

            if (userChoice.ToLower() == USER_BREATHING || userChoice.ToLower() == USER_BREATHE || userChoice.ToLower() == USER_BREATH || userChoice.ToLower() == USER_B || userChoice.ToLower() == USER_1)
            {
                Breathing myBreathing = new Breathing();

                myBreathing.DisplayWelcomeMessage();
                myBreathing.DisplayBreathingDescription();
                sessionTime = myBreathing.GetSessionQuestion();
                myBreathing.DisplayGetReady();
                myBreathing.GetReadySpinner();
                myBreathing.DisplayBreaths(sessionTime);
                myBreathing.DisplayEndMessage();
                Console.Clear();
            }
            else if (userChoice.ToLower() == USER_REFLECTING || userChoice.ToLower() == USER_REFLECTION || userChoice.ToLower() == USER_REFLECT || userChoice.ToLower() == USER_R || userChoice.ToLower() == USER_2)
            {
                Reflecting myReflecting = new Reflecting();

                myReflecting.DisplayWelcomeMessage();
                myReflecting.DisplayReflectingDescription();
                sessionTime = myReflecting.GetSessionQuestion();
                myReflecting.DisplayGetReady();
                myReflecting.GetReadySpinner();
                myReflecting.DisplayWritingPrompt(sessionTime);
                myReflecting.DisplayEndMessage();
                Console.Clear();
            } 
            else if (userChoice.ToLower() == USER_LISTING || userChoice.ToLower() == USER_LIST || userChoice.ToLower() == USER_L || userChoice.ToLower() == USER_3)
            {
                Listing myListing = new Listing();

                myListing.DisplayWelcomeMessage();
                myListing.DisplayListingDescription();
                sessionTime = myListing.GetSessionQuestion();
                myListing.DisplayGetReady();
                myListing.GetReadySpinner();
                myListing.DisplayListingPrompt(sessionTime);
                myListing.DisplayEndMessage();
                Console.Clear();
            }
            else if (userChoice.ToLower() == USER_QUIT || userChoice.ToLower() == USER_Q || userChoice.ToLower() == USER_4)
            {
                break;
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Invalid Input");
                Console.WriteLine("Please Try Again");
                Console.WriteLine("");
                Console.Clear();
            }
        } 

        Console.WriteLine("");
        Console.WriteLine("Ending Program.");
        Console.WriteLine("");
    }
}