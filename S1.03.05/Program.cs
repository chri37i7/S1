using System;

namespace S1._03._05
{
    class Program
    {
        static void Main(string[] args)
        {

            // Opgave 5
            Console.WriteLine("Indtast temperaturen med to decimaler.");
            string userTemp = Console.ReadLine();
            double temp = double.Parse(userTemp);

            Console.WriteLine("Indtast byen du er i.");
            string userLocation = Console.ReadLine();

            Console.WriteLine($"{temp} er da en fin temperatur for {userLocation}.");

        }
    }
}
