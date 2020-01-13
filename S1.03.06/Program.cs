using System;

namespace S1._03._06
{
    class Program
    {
        static void Main(string[] args)
        {

            // Opgave 6
            Console.WriteLine("Indtast din vægt: ");
            string input = Console.ReadLine();
            double weight = double.Parse(input);
            //double.TryParse(input, out double weight);
            Console.WriteLine($"Din vægt er {weight} kg");

        }
    }
}
