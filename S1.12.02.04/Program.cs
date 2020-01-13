using System;

namespace S1._12._02._04
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] userNumber = new double[5];

            Console.WriteLine("Indtast 5 tal, med 2 decimaler.");

            // Take input & store in array
            for(int i = 0; i < userNumber.Length; i++)
            {
                Console.Write("Indtast tal " + i + ": ");
                string userInput = Console.ReadLine();
                double.TryParse(userInput, out double output);

                userNumber[i] = output;
            }
            
            // Empty line for spacing
            Console.WriteLine();

            // Output the inputs stored in array
            for(int i = 0; i < userNumber.Length; i++)
            {
                Console.WriteLine(userNumber[i]);
            }
        }
    }
}
