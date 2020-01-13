using System;

namespace S1._06._02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int firstNumber = 50;
            int secondNumber = 30;
            int thirdNumber = 5;
            // Multiply & subtract numbers
            int resultNumber = firstNumber + secondNumber - thirdNumber;
            // Output result
            Console.WriteLine($"Resultatet af {firstNumber} + {secondNumber} - {thirdNumber} er: " + resultNumber);
        }
    }
}
