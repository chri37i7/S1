using System;

namespace S1._16._01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Random from 0 to 9
            for(int i = 0; i < 5; i++)
            {

                Random rndGen = new Random();

                int randomNumber = rndGen.Next(0, 10);

                Console.Write(randomNumber + " ");

            }

            // Line for spacing
            Console.WriteLine();

            // Random from -10 to 10
            for(int i = 0; i < 5; i++)
            {

                Random rndGen = new Random();

                double randomNumber = rndGen.Next(-10, 10);

                Console.Write(randomNumber + " ");

            }

            // Line for spacing
            Console.WriteLine();

            // Random with comma from 0,0 to 1,0
            for(int i = 0; i < 5; i++)
            {

                Random rndGen = new Random();

                double randomNumber = rndGen.NextDouble();

                Console.Write($"{randomNumber:f}" + " ");

            }
        }
    }
}
