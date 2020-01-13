using System;

namespace S1._10._01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Output to user
            Console.WriteLine("Indtast et af følgende dyr: Gris, hund, kat, eller ko.");
            // Ask for input
            Console.Write("Indtast dyr: ");
            // Store input in string as lowercase 
            string userAnimal = Console.ReadLine().ToLower();
            // Switch ;D!
            switch(userAnimal)
            {
                case "gris":
                    Console.WriteLine("Grise er lavet af bacon!");
                    break;
                case "hund":
                    Console.WriteLine("Hunden er menneskets bedste ven!");
                    break;
                case "kat":
                    Console.WriteLine("Alle katte er autister!");
                    break;
                case "ko":
                    Console.WriteLine("Koen laver mælk!");
                    break;
                default:
                    Console.WriteLine("FEJL! Ukendt dyr.");
                    break;
            }
        }
    }
}
