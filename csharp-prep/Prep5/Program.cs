using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");    
    }

    // This function is string because it is returning the string userName.
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    // This function is int because it is returning the int userNum.
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userNumber = Console.ReadLine();
        int userNum = int.Parse(userNumber);
        return userNum;
    }
    
    // This function uses the out keyword to update the integer birthYear without returning it.
    // It receives the integer birthYear as an paramter using the out keyword.
    static void PromptBirthYear(out int birthYear)
    {
        Console.Write("What is the year you were born? ");
        string userYear = Console.ReadLine();
        // You must convert the string to an integer.
        birthYear = int.Parse(userYear);
    }

    // This function returns the integer numberSquared.
    // It recieves an integer number as a parameter.
    static int SquareNumber(int number)
    {
        int numberSquared = (number * number);
        return numberSquared;
    }

    // This function receives three paramters, but returns nothing, hence void.
    static void DisplayResult(string userName, int numberSquared, int birthYear)
    {
        int currentYear = DateTime.Now.Year;
        int userAge = currentYear - birthYear;

        Console.WriteLine($"{userName}, the square of your number is {numberSquared}.");
        Console.WriteLine($"{userName}, you will turn {userAge} this year.");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string namePerson = PromptUserName();
        int numPerson = PromptUserNumber();
        int squareNumber = SquareNumber(numPerson);
        
        // Intialize birthYear integer, before using the out keyword to pass it by reference to the PromptBirthYear function.
        // It will update birthYear without returning it.
        int birthYear;
        PromptBirthYear(out birthYear);

        // DisplayResult function will then use pass in birthYear as a parameter.
        DisplayResult(namePerson, squareNumber, birthYear);
    }
}