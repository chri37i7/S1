using System;

namespace S1._17._03._02
{
    class Program
    {
        static void Main()
        {
            DateTime now = DateTime.Now;

            // a.
            Console.WriteLine(now.ToString("MM-dd-yyyy"));

            Console.WriteLine();

            // b.
            Console.WriteLine(now.ToString("dd. MMMM yyyy"));

            Console.WriteLine();

            // c.
            Console.WriteLine(now.ToString("dd. MMMM yyyy HH:MM:ss"));

            Console.WriteLine();

            // d.
            Console.WriteLine(now.ToString("dd. dddd MMM yy"));
        }
    }
}
