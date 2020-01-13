using System;

namespace S1._11._05
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Indtast et tal mellem 1, og 10: ");
                string userInput = Console.ReadLine();
                int.TryParse(userInput, out int inputNumber);
                if(inputNumber > 0 && inputNumber < 11)
                {
                    Console.WriteLine("Du indtastede: " + inputNumber);
                }
                else
                {
                    Console.WriteLine("FEJL! Du indtastede ikke et tal mellem 1, og 10");
                }
                // Output message
                Console.Write("\nVil du prøve igen? (J/N): ");
                string tryAgain = Console.ReadLine().ToLower();
                // Try again false, stop
                if(tryAgain == "n")
                {
                    break;
                }
                // Try again true, start over
                else if(tryAgain == "j")
                {
                    Console.ResetColor();
                    Console.Clear();
                    continue;
                }
                else
                {
                    Console.ResetColor();
                    Console.Clear();
                    continue;
                }
            }
        }
    }
}
