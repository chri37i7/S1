using System;

namespace S1._08._03._03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop the program
            while(true)
            {
                // Ask for input
                Console.Write("Indtast et pris, og få moms udregnet: ");
                // Save input in string variable
                string userInput = Console.ReadLine();
                // Try to convert string to int
                int.TryParse(userInput, out int outputPrice);
                // Output tax price, if higher than 0.
                if(outputPrice > 0)
                {
                    // Output message
                    Console.WriteLine($"Momsen af {outputPrice} er lig med: " + (outputPrice * 1.25));
                }
                else
                {
                    // Change text background color
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    // Output message
                    Console.WriteLine("Fejl, du indtastede ikke et tal.");
                }
                // Prevent reset, before keypress.
                Console.ReadLine();
                //  Reset the color from the error message
                Console.ResetColor();
                // Clear all console output before reset.
                Console.Clear();
            }
        }
    }
}