using System;

namespace S1._12._02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop the code
            while(true)
            {
                // Declare Array with 5 empty positions
                string[] boyNames = new string[5];

                // Write to user
                Console.WriteLine("Indtast 5 drengenavne.");

                // Take input & store in array
                for(int i = 0; i < boyNames.Length; i++)
                {
                    Console.Write("Indtast navn " + i + ": ");
                    boyNames[i] = Console.ReadLine();
                }

                // Empty line for spacing
                Console.WriteLine();

                // Output the inputs stored in array
                for(int i = 0; i < boyNames.Length; i++)
                {
                    Console.WriteLine("Navn " + i + ": " + boyNames[i]);
                }
            }
        }
    }
}
