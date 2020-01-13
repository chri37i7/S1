using System;

namespace S1._10._04
{
    class Program
    {
        enum Importance
        {
            None,
            Trivial,
            Regular,
            Important,
            Critical
        }
            
        static void Main(string[] args)
        {
            Console.WriteLine("Brug følgende til at beskrive vigtigeden af fejlen: None, Trivial, Regular, Important, Critical");
            Console.Write("Indtast vigtigheden: ");
            string userImportance = Console.ReadLine().ToLower();
            Enum.TryParse(userImportance, true, out Importance errorImportance);
            switch(errorImportance)
            {
                case Importance.None:
                    Console.WriteLine("Ingen fejl, det perfekt!");
                    break;
                case Importance.Trivial:
                    Console.WriteLine("Det går nok, det ikke sket før!");
                    break;
                case Importance.Regular:
                    Console.WriteLine("Det sker hele tiden, det en feature!");
                    break;
                case Importance.Important:
                    Console.WriteLine("Det er en vigtig fejl!");
                    break;
                case Importance.Critical:
                    Console.WriteLine("Det hele er ude og skide!!!");
                    break;
                default:
                    Console.WriteLine("FEJL! Du indtastede ikke en valgmulighed.");
                    break;
            }

        }
    }
}
