using System;

namespace S1._06._01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare string variables
            string firstLetter = "12";
            string secondLetter = "34";
            // Declare int variables
            int firstNumber = 12;
            int secondNumber = 34;

            // Combine string variables
            string combinedLetter = firstLetter + secondLetter;
            // Combine int variables
            int combinedNumber = firstNumber + secondNumber;

            // Print combined strings
            Console.WriteLine("Tekst lagt sammen er: " + combinedLetter);
            // Print combined ints
            Console.WriteLine("Tal lagt sammen er:" + combinedNumber);

            // Combine string & int
            string combinedLetterAndNumber = firstNumber + secondLetter;
            // Print combined string & int
            Console.WriteLine("Tekst og tal lagt sammen er: " + combinedLetterAndNumber);

            // Prevent close before keypress
            Console.ReadLine();
        }
    }
}
