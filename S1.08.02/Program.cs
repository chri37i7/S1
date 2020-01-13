using System;

namespace S1._08._02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast din alder: ");
            string userInput = Console.ReadLine();
            int.TryParse(userInput, out int userAge);
            if(userAge > 17)
            {
                Console.WriteLine("Tillykke - du er nu myndig!");
            }
            else
            {
                Console.WriteLine("Du er ikke myndig.");
            }
        }
    }
}
