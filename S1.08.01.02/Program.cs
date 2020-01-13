using System;

namespace S1._08._01._02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast et tal mellem 1 & 20: ");
            string userInput = Console.ReadLine();
            int.TryParse(userInput, out int numberOutput);
            if(numberOutput == 10)
            {
                Console.WriteLine($"Tallet {numberOutput}, er lig med tallet {numberOutput}");
            }
            else if(numberOutput > 10)
            {
                Console.WriteLine($"Tallet {numberOutput} er større end 10.");
            }
            else if(numberOutput < 10)
            {
                Console.WriteLine($"Tallet {numberOutput} er mindre end 10.");
            }
            else
            {
                Console.WriteLine("Uventet fejl.");
            }
        }
    }
}
