using System;

namespace S1._08._03._02
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            Console.Write("Indtast et tal: ");
            string firstNumber = Console.ReadLine();
            double.TryParse(firstNumber, out double firstOutput);
            //
            Console.Write("Indtast et tal mere: ");
            string secondNumber = Console.ReadLine();
            double.TryParse(secondNumber, out double secondOutput);
            //
            if(firstOutput == 0 | secondOutput == 0)
            {
                Console.WriteLine("\nFEJL! Man kan ikke dividere med nul!");
            }
            else
            {
                Console.WriteLine($"\n{firstOutput} divideret med {secondOutput} er lig med: " + (firstOutput / secondOutput));
            }
        }
    }
}
