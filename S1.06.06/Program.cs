using System;

namespace S1._06._06
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                // Ask user for input
                Console.Write("Indtast et antal sekunder: ");
                // Store user input in string
                string userInput = Console.ReadLine();
                // Try to convert string to int
                int.TryParse(userInput, out int userOutput);
                // Calculate minutes & remaining seconds
                int outputMinutes = userOutput / 60;
                double outputSeconds = userOutput % 60;
                // Error message if result is 0
                if(userOutput == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;

                    Console.WriteLine("Fejl, du indtastede ikke et tal!");

                    Console.ReadLine();
                }
                // Output results of calculations, if error isn't triggered
                else
                {
                    Console.WriteLine($"\n{userOutput} svarer til {outputMinutes} minutter og {outputSeconds} sekunder!");

                    Console.ReadLine();
                }
                // Clear console before reset.
                Console.ResetColor();
                Console.Clear();
            }
        }   
    }
}
