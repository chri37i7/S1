using System;

namespace S1._04._04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Take input & store
            Console.Write("Indtast dit fornavn: ");
            string firstName = Console.ReadLine();
            // Convert to UPPERCASE
            string upperFirst = firstName.ToUpper();
            // Contert to lowercase
            string lowerFirst = upperFirst.ToLower();


            // Take input & store
            Console.Write("Indtast dit efternavn: ");
            string lastName = Console.ReadLine();
            // Convert to UPPERCASE
            string upperLast = lastName.ToUpper();
            // Convert to lowercase
            string lowerLast = upperLast.ToLower();


            // Store first letter of lowerFirst
            string firstFirst = upperFirst.Substring(0, 1);
            // Store first letter of lowerLast
            string lastLast = upperLast.Substring(0, 1);


            // Output the variables to user
            Console.WriteLine($"\nHej {firstName} {lastName}!");
            // Output UPPERCASE full name
            Console.WriteLine($"\nHej med stort: {upperFirst} {upperLast}!");
            // Output lowercase full name
            Console.WriteLine($"\nHej med småt: {lowerFirst} {lowerLast}!");
            // Output name & initials
            Console.WriteLine($"\nHer er dine initialer {firstName} {lastName}: {firstFirst}.{lastLast}.");


            // Prevent reset before keypress
            Console.ReadLine();
        }
    }
}
