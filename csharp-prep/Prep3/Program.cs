using System;

class Program
{
    static void Main(string[] args)
    {
        string playGame = "yes";

        while (playGame.ToLower() == "yes" || playGame.ToLower() == "y")
        {
            
            Console.Write("Would you like to play the guessing game? ");
            playGame = Console.ReadLine();

            if (playGame.ToLower() != "yes" && playGame.ToLower() != "y")
            {
                break;
            }           

            Random randomGenerator = new Random();
            int magicNum = randomGenerator.Next(1, 51);
            Console.WriteLine("Generating a random number between 1 and 50!");

            int guessNum = 0;
            int guessCount = 0;
            do {

                Console.Write("What is your guess? ");
                string guessString = Console.ReadLine();
                guessNum = int.Parse(guessString);

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