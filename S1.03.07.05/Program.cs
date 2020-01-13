using System;

namespace S1._03._07
{
    class Program
    {
        static void Main(string[] args)
        {

            // Opgave 7.4
            while(true)
            { 
                Console.WriteLine("Indtast din alder!");
                string userAge = Console.ReadLine();
                int.TryParse(userAge, out int Age);
                if (Age == 0)
                {
                    Console.WriteLine("Du indtastede ikke et tal.");

                    // Stop Reset Before Keypress
                    Console.ReadLine();
                }
                else if (Age == 29)
                {
                    Console.WriteLine("Utroligt du kun er 29!");

                    // Stop Reset Before Keypress
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine($"Er du {Age}? Wow!");

                    // Stop Reset Before Keypress
                    Console.ReadLine();
                }
                // Clear Console For New Input
                Console.Clear();
            }
        }
    }
}

