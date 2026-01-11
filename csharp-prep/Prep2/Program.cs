using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask the Student for their Grade Percentage
        Console.Write("What is your grade percentage? ");
        string gradeString = Console.ReadLine();
        int gradePercent = int.Parse(gradeString);
        
        // Initialize Grade Variables
        string letter = "";
        string gradeModifier = "";

        // Conditional Statement to Determine Letter Grade
        if (gradePercent >= 90)
        {
            letter = "A";
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Conditional Statement to Ignore Grade Modifier if Grade is an "F"
        if (letter != "F")
        {
            // Conditional Statement to Find Grade Modifier
            if (((gradePercent % 10) >= 7) && (letter != "A"))
            {
                gradeModifier = "+";
            }
            else if ((gradePercent % 10) < 3)
            {
                gradeModifier = "-";
            }
        }

        // Write Grade and Modifier to Console
        Console.WriteLine($"Your grade is: {letter}{gradeModifier}");

        // Determine if the Student Passed the Class
        if (gradePercent >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course!");
        }
        else
        {
            Console.WriteLine("You failed to pass the course. Better luck next time.");
        }
    }
}