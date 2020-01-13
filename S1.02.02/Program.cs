using System;

namespace S1._02._02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed; 
            Console.ForegroundColor = ConsoleColor.Gray; 
            Console.WriteLine("Error!\nDer Skete en fejl. Genstart computeren...");

            // Stop konsollen fra at lukke.
            Console.ReadLine();
        }
    }
}
