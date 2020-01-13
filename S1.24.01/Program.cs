using System;
using System.IO;

namespace S1._24._01
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Indtast et filnavn der eksistrer i dokumentmappen.");
            Console.Write("Indtast: ");
            string consoleInput = Console.ReadLine();
                   

            if(FileExist(consoleInput) == true)
            {
                Console.WriteLine("ok");
            }
            else
            {
                Console.WriteLine("Fejl! Filen findes ikke.");
            }
        }

        static bool FileExist(string path)

        {
            bool fileExists = File.Exists(path);

            return fileExists;
        }
    }
}
