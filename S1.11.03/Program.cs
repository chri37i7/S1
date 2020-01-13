using System;

namespace S1._11._03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask for input
            Console.Write("Indtast en kort tekst: ");
            // Store input string in userInput
            string userInput = Console.ReadLine();
            // Store userInput length in inputLength
            int inputLength = userInput.Length;
            // Counter for substring index
            int indexCounter = 0;
            // Loop while inputLength is higher than 0
            while(inputLength > 0)
            {
                // Get 1 character for output.
                string substringOutput = userInput.Substring(indexCounter++, 1);
                // Output single character
                Console.WriteLine(substringOutput);
                // Remove 1 number from inputLength
                inputLength--;
            }
            Console.ReadLine();
        }
    }
}
