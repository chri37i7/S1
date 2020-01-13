using System;

namespace S1._11._07
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare int, and value
            int number = 10;

            // Loop
            do
            {
                    // Subtract single number per cycle.
                    int consoleOutput = number--;

                    // Output single number
                    Console.WriteLine(consoleOutput);

              // loop while userNumber is equal, or higher than 0
            } while(number > 0);
        }
    }
}
