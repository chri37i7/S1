using System;

namespace S1._12._02._03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare array for parking spots
            bool[] parkingSpots = new bool[] { false, false, false, false, false, false, false, false, false, false };

            // Output question to user
            Console.WriteLine("Svar ja, eller nej til om der holder en bil på parkeringspladserne.");
            // Ask for input from user & store
            for(int i = 0; i < parkingSpots.Length; i++)
            {
                Console.Write("Holder der en bil på plads " + i + "?: ");
                string userInput = Console.ReadLine().ToLower();
                if(userInput == "ja")
                {
                    parkingSpots[i] = true;
                }
                else if(userInput == "nej")
                {
                    parkingSpots[i] = false;
                }
                else
                {
                    Console.WriteLine("FEJL! Indtast \"Ja\" eller \"nej\".");
                }

            }

            // Empty line for spacing
            Console.WriteLine();

            // Declare variable for counting repeats
            int repeats = 0;

            // Declare variable for counting available parking spots
            int freeSpots = 0;

            // Loop
            while(repeats < parkingSpots.Length)
            {
                // Count available parking spots
                if(parkingSpots[repeats] == false)
                {
                    freeSpots++;
                }
                // Count repeats
                repeats++;
            }

            // Output total available parking spots
            Console.WriteLine("Der er " + freeSpots + " ledige pladser.");
        }
    }
}
