using System;

namespace S1._08._01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            while(!done)
            {
                Console.Write("Indtast et tal mellem 1 og 20: ");
                string inputNumber = Console.ReadLine();
                int.TryParse(inputNumber, out int outputNumber);
                if(outputNumber > 20)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Fejl. Du indtastede et for stort tal!");
                }
                else if(outputNumber <= 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Fejl. Du indtastede et for småt tal!");
                }
                else if(outputNumber == 10)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Tallet du indtastede er lig med " + outputNumber + ".");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Tallet {outputNumber}, er ikke lig med 10.");
                }
                Console.ReadLine();
                Console.ResetColor();
                Console.Clear();
            }

        }
    }
}
