using System;

namespace S1._06._08
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask user for product & store in string
            Console.Write("Indtast en vare: ");
            string firstProduct = Console.ReadLine();
            // Ask for price & store in string
            Console.Write("Indtast prisen på varen: ");
            string firstPrice = Console.ReadLine();
            // Ask user for product & store in string
            Console.Write("Indtast en vare: ");
            string secondProduct = Console.ReadLine();
            // Ask for price & store in string
            Console.Write("Indtast prisen på varen: ");
            string secondPrice = Console.ReadLine();
            // Ask user for product & store in string
            Console.Write("Indtast en vare: ");
            string thirdProduct = Console.ReadLine();
            // Ask for price & store in string
            Console.Write("Indtast prisen på varen: ");
            string thirdPrice = Console.ReadLine();
            // Ask user for product & store in string
            Console.Write("Indtast en vare: ");
            string fourthProduct = Console.ReadLine();
            // Ask for price & store in string
            Console.Write("Indtast prisen på varen: ");
            string fourthPrice = Console.ReadLine();
            // Ask user for product & store in string
            Console.Write("Indtast en vare: ");
            string fifthProduct = Console.ReadLine();
            // Ask for price & store in string
            Console.Write("Indtast prisen på varen: ");
            string fifthPrice = Console.ReadLine();
            // Ask user for product & store in string
            Console.Write("Indtast en vare: ");
            string sixthProduct = Console.ReadLine();
            // Ask for price & store in string
            Console.Write("Indtast prisen på varen: ");
            string sixthPrice = Console.ReadLine();


            Console.WriteLine($"\nPris på varer:\n{firstProduct}:\t{secondProduct}:\t{thirdProduct}:\t{fourthProduct}:\t{fifthProduct}:\t{sixthProduct}:\n\n{firstPrice},-\t{secondPrice},-\t{thirdPrice},-\t{fourthPrice},-\t{fifthPrice},-\t{sixthPrice},-");


            Console.ReadLine();
        }
    }
}
