using System;

namespace S1._03._02
{
    class Program
    {
        static void Main(string[] args)
        {

            // Opgave 2
            Console.WriteLine("Skriv dit navn!");
            string userName = Console.ReadLine();

            Console.WriteLine("Skriv din alder!");
            string userAge = Console.ReadLine();
            int age = int.Parse(userAge);

            Console.WriteLine("Skriv den by du er født i!");
            string userCity = Console.ReadLine();

            Console.WriteLine($"Der var engang en person som hed {userName}, han boede i {userCity}, og var {userAge} år gammel.");

        }
    }
}
