using System;

namespace S1._18._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // Opgave 1
            //
            // a.
            TimeSpan twoDays = new TimeSpan(2, 4, 30, 11);
            // b.
            TimeSpan schoolDay = new TimeSpan(6, 5, 0);
            // c.
            TimeSpan wokeUp = new TimeSpan(2, 14, 0);
            //
            // Opgave 2
            //
            Console.WriteLine(twoDays.ToString());
            Console.WriteLine(schoolDay.ToString());
            Console.WriteLine(wokeUp.ToString());
            //
            // Opgave 3
            //
            // a.
            TimeSpan thirtyNineMinutes = new TimeSpan(0, 39, 2);
            // b.
            TimeSpan eightTeenDays = new TimeSpan(18, 0, 0, 0);
            // c.
            TimeSpan twentyEightDays = new TimeSpan(28, 7, 16, 22);
            //
            // Opgave 4
            //  
            Console.WriteLine(thirtyNineMinutes.ToString());
            Console.WriteLine(eightTeenDays.ToString());
            Console.WriteLine(twentyEightDays.ToString());
        }
    }
}
