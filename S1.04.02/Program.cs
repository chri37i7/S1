using System;

namespace S1._04._02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write message & Take input
            Console.WriteLine("Indtast et ord!");
            string userInput = Console.ReadLine();

            // Save Character Amount in variable
            int inputLength = userInput.Length;

            // Output Character Length
            Console.WriteLine($"Du har indtastet {inputLength} bogstaver.");

            // Prevent Reset Before keypress
            Console.ReadLine();
        }
    }
}
