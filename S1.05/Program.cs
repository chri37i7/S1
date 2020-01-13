using System;

namespace S3._05._decimal
{
    class Program
    {
        static void Main(string[] args)
        {
            // 
            // Opgave 1
            //

            // Delopgave 9
            decimal perMil = 0.3M;
            Console.WriteLine("Din promille er: " + perMil);

            // Delopgave 10
            decimal percent = 1;
            Console.WriteLine(percent.ToString("P"));

            // Delopgave 11
            decimal perCent = 1.25M;
            Console.WriteLine(perCent.ToString("P"));

            // Delopgave 12
            decimal percentage = .25M;
            Console.WriteLine(percentage.ToString("P"));

            // Delopgave 13
            decimal temperatur = 7;
            Console.WriteLine(temperatur + "°");
        }
    }
}