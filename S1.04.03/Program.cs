using System;

namespace S1._04._03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Take input & Save in variable
            Console.Write("Indtast dit fornavn: ");
            string firstName = Console.ReadLine();

            // Take input & Save in variable
            Console.Write("Indtast dit efternavn: ");
            string lastName = Console.ReadLine();

            /*
             Substring(0, 1);

             Start at 0(The beginning), and take the first letter
            */

            // Save first letter in firstName
            string firstLetter = firstName.Substring(0, 1);
            // Save first letter in lastName
            string lastLetter = lastName.Substring(0, 1);

            // Output initials
            Console.WriteLine($"\nHej! {firstName} {lastName}! Dine initialer er: {firstLetter}.{lastLetter}.");

            // Prevent Reset Before keypress
            Console.ReadLine();
        }
    }
}
