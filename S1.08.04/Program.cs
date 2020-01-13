using System;

namespace S1._08._04
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                // Output message
                Console.Write("Indtast vægten på brevet, i gram: ");
                string mailWeight = Console.ReadLine();
                int.TryParse(mailWeight, out int weight);
                if(weight == 0)
                // Error message
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("FEJL! Der opstod en fejl, prøv igen senere.");
                    Console.ResetColor();
                    // Output message
                    Console.Write("\nVil du prøve igen? (J/N): ");
                    string repeat = Console.ReadLine().ToLower();
                    // Try again false, stop
                    if(repeat == "n")
                    {
                        break;
                    }
                    // Try again true, start over
                    else if(repeat == "j")
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
                // Output message
                Console.Write("Vil du have din pakke express leveret, (J/N)? ");
                string isExpress = Console.ReadLine().ToLower();
                // Is express delivery?
                bool isTrue = isExpress == "j";
                bool isFalse = isExpress == "n";
                // Express delivery true
                if(isTrue && weight > 0 && weight < 20)
                {
                    Console.WriteLine("Prisen er: 10,-");
                }
                // Express delivery false
                else if(isFalse && weight > 0 && weight < 20)
                {
                    Console.WriteLine("Prisen er: 5,-");
                }
                // Express delivery true
                else if(isTrue && weight >= 20 && weight < 50)
                {
                    Console.WriteLine("Prisen er: 13,-");
                }
                // Express delivery false
                else if(isFalse && weight >= 20 && weight < 50)
                {
                    Console.WriteLine("Prisen er: 7,-");
                }
                // Express delivery true
                else if(isTrue && weight >= 50 && weight < 100)
                {
                    Console.WriteLine("Prisen er: 17,-");
                }
                // Express delivery false
                else if(isFalse && weight >= 50 && weight < 100)
                {
                    Console.WriteLine("Prisen er: 12,-");
                }
                // Express delivery true
                else if(isTrue && weight >= 100 && weight < 250)
                {
                    Console.WriteLine("Prisen er: 20,-");
                }
                // Express delivery false
                else if(isFalse && weight >= 100 && weight < 250)
                {
                    Console.WriteLine("Prisen er: 15,-");
                }
                // Express delivery true
                else if(isTrue && weight >= 250)
                {
                    Console.WriteLine("Prisen er: 35,-");
                }
                // Express delivery false
                else if(isFalse && weight >= 250)
                {
                    Console.WriteLine("Prisen er: 30,-");
                }
                // Error message
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("FEJL! Der opstod en fejl, prøv igen senere.");
                    Console.ResetColor();
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
