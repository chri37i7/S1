using System;

namespace S1._16._04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop program
            while(true)
            {
                // Ask user & take input
                Console.WriteLine("Indtast højeste tal(Maximum 10): ");
                Console.Write("Indtast tal: ");


                // Store input in string & try to convert to int
                string inputHighestNumber = Console.ReadLine();
                int.TryParse(inputHighestNumber, out int highestNumber);


                // Error if input number is not from 1 to 10
                if(highestNumber > 10 || highestNumber <= 0)
                {
                    // Clear console from previous outputs
                    Console.Clear();


                    // Write error & pause
                    Console.WriteLine("FEJL! Forkert tal, vælg et fra 1 til 10.");
                    Console.ReadLine();


                    // Clear console from previous outputs & restart
                    Console.Clear();
                    continue;
                }
                // continue if input number is higher than 0 and lower than 11
                else if(highestNumber > 0 && highestNumber <= 10)
                {
                    // Declare number generator & generate random number
                    Random randomNumberGenerator = new Random();
                    int randomNumber = randomNumberGenerator.Next(1, highestNumber);


                    // Int for storing guesses
                    int randomGuess = 0;


                    // Loop until random number is guessed
                    while(true)
                    {
                        // Clear console from previous outputs
                        Console.Clear();


                        //Count guesses
                        randomGuess++;


                        // Ask user & take input
                        Console.WriteLine("Gæt hvilket tal mellem 1 og 10 jeg tænker på ;D!");
                        Console.Write("Indtast gæt: ");


                        // Store input in string & try to convert to int
                        string inputGuess = Console.ReadLine();
                        int.TryParse(inputGuess, out int userGuess);


                        // Check if answer is correct.
                        if(userGuess == randomNumber)
                        {
                            // Clear console from previous outputs
                            Console.Clear();


                            // Write correct & pause
                            Console.WriteLine("Korrekt! Tallet er {0}! Det tog dig {1} forsøg.", randomNumber, randomGuess);
                            Console.ReadLine();


                            // Clear console from previous outputs & break loop
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            // Clear console from previous outputs
                            Console.Clear();


                            // Write incorrect & pause
                            Console.WriteLine("Forkert! Du har indtil videre gættet forkert {0} gange.", randomGuess);
                            Console.ReadLine();


                            // Clear console from previous outputs & restart loop
                            Console.Clear();
                            continue;
                        }
                    }
                }
            }
        }
    }
}
