using System;

namespace S1._08._02._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("indtast en tal mellem -20 og 20: ");
            string userInput = Console.ReadLine();
            int.TryParse(userInput, out int outputNumber);
            if(outputNumber > 0)
            {
                Console.WriteLine($"Jeg synes også at {outputNumber} er et flot tal!");
            }
            else if(outputNumber<0)
            {
                Console.WriteLine("Ikke så negativ!!");
            }
        }
    }
}
