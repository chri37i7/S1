using System;

namespace S1._11._04
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            while(input != "exit")
            {
                Console.WriteLine("Skriv exit for at stoppe programmet");
                input = Console.ReadLine().ToLower();
            }
        }
    }
}
