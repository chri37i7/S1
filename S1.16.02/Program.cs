using System;

namespace S1._16._02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop Program
            while(true)
            {
                // How many dices?
                Console.Write("Indtast antal tærninger(1:6): ");
                string firstInput = Console.ReadLine();
                int.TryParse(firstInput, out int userDices);

                // Error message
                if(userDices > 6 || userDices <= 0)
                {
                    // Output error & pause
                    Console.WriteLine("FEJL!");
                    Console.ReadLine();

                    // Reset loop
                    continue;
                }
                // If no error, continue
                else
                {
                    // Clear previous output
                    Console.Clear();

                    // How many sides?
                    Console.Write("Indtast antal sider(2:20): ");
                    string secondInput = Console.ReadLine();
                    int.TryParse(secondInput, out int diceSides);

                    // Error message
                    if(diceSides > 20 || diceSides <= 1)
                    {
                        // Output error & pause
                        Console.WriteLine("FEJL!");
                        Console.ReadLine();

                        // Reset loop
                        continue;
                    }
                    // If no error, continue
                    else
                    {
                        // Clear previous output
                        Console.Clear();

                        // fixes stuff
                        diceSides++;

                        // Output amount of dices entered
                        for(int i = 0; i < userDices; i++)
                        {
                            // Declare random generator
                            Random rndDice = new Random();

                            // Generate number based on sides
                            int rollDice = rndDice.Next(1, diceSides);

                            // Output number
                            Console.WriteLine("Du slog {0}", rollDice);
                        }

                        // Line for spacing
                        Console.WriteLine();

                        // Reset
                        continue;
                    }
                }
            }
        }
    }
}
