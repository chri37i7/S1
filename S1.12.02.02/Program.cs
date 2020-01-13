using System;

namespace S1._12._02._02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare array for storing heights
            int[] averageHeight = new int[10];

            // Output message
            Console.WriteLine("Indtast højden på 10 personer.");

            // Take input & store in array
            for(int i = 0; i < averageHeight.Length; i++)
            {
                // Ask user for input
                Console.Write("Indtast højde " + i + ": ");

                // Store input in string & try to convert to int
                string userInput = Console.ReadLine();
                int.TryParse(userInput, out int inputHeight);

                // Store converted int in array
                averageHeight[i] = inputHeight;
            }

            // Int for storing all heights combined
            int totalAverage = 0;

            // Combine all heights in array to singe number
            for(int i = 0; i < averageHeight.Length; i++)
            {
                totalAverage += averageHeight[i];
            }

            // Output average by deviding the combined heights with the ammount of heights
            Console.WriteLine((totalAverage / averageHeight.Length));
        }
    }
}
