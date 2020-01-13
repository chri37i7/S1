using System;

namespace S1._03._07._05
{
    class Program
    {
        static void Main(string[] args)
        {

            // Opgave 7.5
            bool done = false;
            while(!done)
            {
                Console.WriteLine("Indtast temperaturen med to decimaler.");
                string userTemp = Console.ReadLine();
                double.TryParse(userTemp, out double temp);

                Console.WriteLine("Indtast byen du er i.");
                string userLocation = Console.ReadLine();

                Console.WriteLine($"{temp} er da en fin temperatur for {userLocation}.");

                //Stop Reset Before Key Is Pressed
                Console.ReadLine();

                // Clear Console For New Input
                Console.Clear();
            }
        }
    }
}