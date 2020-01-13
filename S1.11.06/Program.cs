using System;

namespace S1._11._06
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
            Console.WriteLine("Indtast en af følgende muligheder:\n\nSkriv (1) for at høre noget om køer\nSkriv (2) for at få resultatet af 2*4\nSkriv (3) for at afslutte programmet\n");
            Console.Write("Indtast valgmulighed: ");
            string userInput = Console.ReadLine();

                if(userInput == "1")
                {
                    continue;
                }
                else if(userInput == "2")
                {
                    continue;
                }
                else if(userInput == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("FEJL!");
                    continue;
                }
            }

        }
    }
}
