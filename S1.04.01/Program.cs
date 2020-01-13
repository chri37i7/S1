using System;

namespace S1._04._01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop forever
            while (true)
            {
                // Take user input
                Console.Write("Indtast dit fornavn: ");
                // Store user input in a string
                string firstName = Console.ReadLine();
                // Convert lastName to uppercase letters
                string upperFirstName = firstName.ToUpper(); 
                // Convert upperLastName to lowercase letters
                string lowerFirstName = upperFirstName.ToLower();


                // Take user input
                Console.Write("Indtast dit efternavn: ");
                // Store user input in a string
                string lastName = Console.ReadLine();
                // Convert lastName to uppercase letters
                string upperLastName = lastName.ToUpper();
                // Convert upperLastName to lowercase letters
                string lowerLastName = upperLastName.ToLower();


                // All Pascal Case
                Console.WriteLine($"\nDu hedder {firstName} {lastName}");
                // ALL UPPER CASE
                Console.WriteLine($"Alt med stort: {upperFirstName} {upperLastName}");
                // all lower case
                Console.WriteLine($"Alt med småt: {lowerFirstName} {lowerLastName}");


                // Prevent Reset Before keypress
                Console.ReadLine();
                // Clear Console
                Console.Clear();
            }
        }
    }
}
