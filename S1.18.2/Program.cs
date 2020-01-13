using System;

namespace S1._18._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // Opgave 1
            //
            // a.
            DateTime christMasEve = new DateTime(2019, 12, 24, 18, 00, 00);
            //
            TimeSpan timeTillChristmasEve = christMasEve - DateTime.Now;
            //
            Console.WriteLine("Tid tilbage til juleaften: {0}", timeTillChristmasEve.ToString("dd\\:hh\\:mm"));
            //
            // b.
            DateTime newYear = new DateTime(2019, 12, 31, 23, 59, 59);
            //
            TimeSpan timeTillNewYear = newYear.Subtract(DateTime.Now);
            //
            Console.WriteLine("Tid tilbage indtil nytår: {0}", timeTillNewYear.ToString("dd\\:hh\\:mm"));
            //
            // c.
            DateTime birth = new DateTime(2001, 5, 31);
            //
            TimeSpan timeSinceBirth = birth.Subtract(DateTime.Now);
            //
            Console.WriteLine("Tid siden fødsel: {0}", timeSinceBirth.ToString("dd\\:hh\\:mm"));
            //
            // d.
            DateTime crowned = new DateTime(1972, 1, 14);
            //
            TimeSpan timeSinceCrowned = crowned.Subtract(DateTime.Now);
            //
            Console.WriteLine("Tid siden fødsel: {0}", timeSinceCrowned.ToString("dd\\:hh\\:mm"));
            //
            // e.
            DateTime tvNews = new DateTime(2019, 12, 14, 20, 00, 00);
            //
            TimeSpan timeTillTvNews = tvNews.Subtract(DateTime.Now);
            //
            Console.WriteLine("Tid indtil lørdagsnyheder: {0}", timeTillTvNews);
        }
    }
}
