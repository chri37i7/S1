using System;

namespace S1._06._07
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Indtast en højde: ");
                string firstInput = Console.ReadLine();
                int.TryParse(firstInput, out int firstOutput);

                Console.Write("Indtast en anden højde: ");
                string secondInput = Console.ReadLine();
                int.TryParse(secondInput, out int secondOutput);

                Console.Write("Indtast en trejde højde: ");
                string thirdInput = Console.ReadLine();
                int.TryParse(thirdInput, out int thirdOutput);

                Console.Write("Indtast en fjerde højde: ");
                string fourthInput = Console.ReadLine();
                int.TryParse(secondInput, out int fourthOutput);

                Console.Write("Indtast en femte højde: ");
                string fifthInput = Console.ReadLine();
                int.TryParse(thirdInput, out int fifthOutput);

                if (firstOutput > 260 | secondOutput > 260 | thirdOutput > 260 | fourthOutput > 260 | fifthOutput > 260)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nDu indtastede et alt for stort tal!");

                    Console.ReadLine();
                }
                else if (firstOutput == 0 | secondOutput == 0 | thirdOutput == 0 | fourthOutput == 0 | fifthOutput == 0)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nDu indtastede ikke et tal!");

                    Console.ReadLine();
                }
                else
                {
                    int heightResult = (firstOutput + secondOutput + thirdOutput + fourthOutput + fifthOutput) / 5;
                    Console.WriteLine($"\nGennemsnits højden er: {heightResult}");

                    Console.ReadLine(); 
                }
                Console.ResetColor();
                Console.Clear();
            }
        }
    }
}
