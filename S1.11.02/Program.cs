using System;

namespace S1._11._02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Repeat Counter
            int repeatCounter = 0;
            // Total number
            int totalNumber = 0;
            // Loop until repeats is 5
            while(repeatCounter < 5)
            {
                // Ask for input
                Console.Write("indtast et tal: ");
                // Store input in string
                string userInput = Console.ReadLine();
                // Try to convert string to int
                int.TryParse(userInput, out int convertedOutput);
                // Save output int in totalNumber
                totalNumber = totalNumber + convertedOutput;
                // Counts repeats by adding 1 number per repeat
                repeatCounter++;
            }
            // Output total number
            Console.WriteLine("Tallene sammenregnet er: " + totalNumber);
        }
    }
}
