using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

class Program
{
    // void = this function returns nothing.
    static void Main(string[] args)
    {
        // Create a new instance of a List class.
        List<int> numbers;
        numbers = new List<int>();
        
        int listInput = 1;

        // Add numbers to the list while the user does not enter 0.
        while (listInput != 0)
        {
            Console.Write("Please enter a number: ");   
            string listString = Console.ReadLine();
            listInput = int.Parse(listString);
            
            numbers.Add(listInput);         
        }

        // Sort the List
        numbers.Sort();

        // Initialize the sum, maximum, and smallest postive number.
        int numberSum = 0;
        int numberMax = 0;
        int numberMin = 999999999;

        Console.WriteLine("Here is the numbers list.");
        // Iterate through each item in the "numbers" list.
        foreach (int number in numbers)
        {
            numberSum = numberSum + number;

            // Check to see if the new number is the highest number.
            if (number > numberMax)
            {
                numberMax = number;
            }

            // Check to see if the new number is the lowest positive number.
            if ((number < numberMin) && (number > 0))
            {
                numberMin = number;
            }

            Console.WriteLine(number);
        }

        // Find the average of all the numbers in the list.
        double numberAverage = (numberSum) / (numbers.Count);

        // Print the Results.
        Console.WriteLine($"The sum is {numberSum}.");
        Console.WriteLine($"The Maximum is {numberMax}.");
        Console.WriteLine($"The Average is {numberAverage}.");
        Console.WriteLine($"The smallest positive number is {numberMin}.");
    }
}