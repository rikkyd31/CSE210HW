using System;

class Program
{
    static void Main(string[] args)
    {
        // Create 3 new Fraction objects using the three different constructors
        Fraction frac = new Fraction();
        Fraction frac2 = new Fraction(5);
        Fraction frac3 = new Fraction(5, 8);

        // Call the associated methods for the frac3 Object
        frac3.GetBottom();
        frac3.GetTop();
        frac3.SetBottom(4);
        frac3.SetTop(2);
        frac3.GetFractionString();
        frac3.GetDecimalValue();

        // Create a new fraction object
        Fraction frac4 = new Fraction(1, 1);

        // Loop 20 Times
        for (int i=1; i<21; i++)
        {
            // Randomly get the top and bottom integers using the Random class
            Random randomGenerator = new Random();
            // Get Random Number between 1 and 9
            int randomTop = randomGenerator.Next(1, 10);
            // Get Random Number between 10 and 19
            int randomBottom = randomGenerator.Next(10, 20);

            // Call the SetTop and SetBottom methods to set the private _top and _bottom attributes inside the Fraction class
            frac4.SetTop(randomTop);
            frac4.SetBottom(randomBottom);

            // Return the Fraction as a String and Decimal
            string fracString = frac4.GetFractionString();
            double fracDecimal = frac4.GetDecimalValue();

            Console.WriteLine($"Fraction {i}: String: {fracString} Decimal: {fracDecimal}");
        }
    }
}