using System;

namespace S1._17._03
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                bool isLeapYear = false;

                Console.WriteLine("Indtast årstal, og find det næste skudår!");
                Console.Write("Indtast år: ");
                string userInput = Console.ReadLine();
                int.TryParse(userInput, out int inputYear);
                if(inputYear == 0)
                {
                    // Clear console & change background color
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkRed;

                    // Output error message & pause console
                    Console.WriteLine("FEJL! Der opstod en fejl.");
                    Console.ReadLine();

                    // Reset console color & clear console
                    Console.ResetColor();
                    Console.Clear();
                }
                else
                {
                    while(isLeapYear == false)
                    {
                        inputYear++;

                        isLeapYear = DateTime.IsLeapYear(inputYear);
                    }
                    Console.WriteLine("Det næste skudår er: {0}", inputYear);
                } 
            }
        }
    }
}
