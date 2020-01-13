using System;

namespace S1._03._04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 4
            Console.WriteLine("Indtast din alder!");
            string userAge = Console.ReadLine();
            int Age = int.Parse(userAge);
            if(Age == 29)
            {
                Console.WriteLine("Utroligt du kun er 29!");
            }
            else
            {
                Console.WriteLine($"Er du {Age}? Wow!");
            }
        }
    }
}
