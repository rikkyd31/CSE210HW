using System;

class Program
{

    // Void = return nothing
    static void Main(string[] args)
    {
        // Intialize string to start program.
        string playGame = "yes";

        // Loop to play the guessing game.
        while (playGame.ToLower() == "yes" || playGame.ToLower() == "y")
        {
            
            Console.Write("Would you like to play the guessing game? ");
            playGame = Console.ReadLine();

            // Logic to see if user wants to play.
            if (playGame.ToLower() != "yes" && playGame.ToLower() != "y")
            {
                break;
            }           

            // Create instance of random class.
            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1, 51);

            Console.WriteLine("Generating a random number between 1 and 50!");

            // Intialize variables to use in guessing loop.
            int guessNum = 0;
            int guessCount = 0;

            // Loop prompts user until the user guesses the number.
            do {

                // Get guess from user.
                Console.Write("What is your guess? ");
                string guessString = Console.ReadLine();
                guessNum = int.Parse(guessString);

                // Logic to see if user guess is higher or lower than magic number.
                if (guessNum > magicNum)
                {
                    Console.WriteLine("Lower");
                    guessCount ++;

                }
                else if (guessNum < magicNum)
                {
                    Console.WriteLine("Higher");
                    guessCount ++;
                }
                else if (guessNum == magicNum)
                {
                    Console.WriteLine("You Guessed It!");
                    guessCount ++;
                    Console.WriteLine($"You guessed {guessCount} times!");
                }
                else
                {
                    Console.WriteLine("Not a Number");
                }

            } while (guessNum != magicNum);
        }
    }
}