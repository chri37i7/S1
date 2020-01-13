using System;
using System.Linq;

namespace S1._16._03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array for storing 10001 random numbers
            double[] randomNumberArray = new double[10001];


            // Loop to generate & store random numbers
            for(int i = 0; i < randomNumberArray.Length; i++)
            {
                // Declare random number generator
                Random randomNumberGenerator = new Random();

                // Generate random number from [-100;100]
                double randomNumber = randomNumberGenerator.Next(-100, 101);

                // Save random number in array
                randomNumberArray[i] = randomNumber;
            }


            // Find highest value in array using method
            double highestArrayValue = randomNumberArray.Max();
            // Find lowest value in array using method
            double lowestArrayValue = randomNumberArray.Min();
            // Find average value in array using method
            double averageArrayValue = randomNumberArray.Average();


            // Find highest value in array using "for" loop
            double highestValue = int.MinValue;
            for(int i = 0; i < randomNumberArray.Length; i++)
            {
                if(randomNumberArray[i] > highestValue)
                {
                    highestValue = randomNumberArray[i];
                }
            }
            // Find lowest value in array using "while" loop
            int c = 0;
            double lowestValue = int.MaxValue;            
            while(c < randomNumberArray.Length)
            {
                if(randomNumberArray[c] < lowestValue)
                {
                    lowestValue = randomNumberArray[c];
                }
                c++;
            }


            // Output highest & lowest array value found by using method
            Console.WriteLine("Ved brug af metode:\n\nHøjeste værdi:\t{0}\nMindste værdi:\t{1}\nGennemsnit:\t{2:f}", highestArrayValue, lowestArrayValue, averageArrayValue);
            // For Spacing
            Console.WriteLine();
            // Output highest & lowest array value found by using loop
            Console.WriteLine("Ved brug af en løkke:\n\nHøjeste værdi:\t{0}\nMindste værdi:\t{1}", highestValue, lowestValue);


            // Pause console
            Console.ReadLine();
        }
    }
}
