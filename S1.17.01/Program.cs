using System;

namespace S1._17._01
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 1
            // a
            DateTime myBirthDate = new DateTime(2001, 5, 31);
            // b
            DateTime queensBirthDate = new DateTime(1940, 4, 16);
            // c
            DateTime constitutionDate = new DateTime(1849, 6, 5);
            // d
            DateTime firstHandBallDate = new DateTime(2019, 1, 10);
            // e
            DateTime aspitChristmasDate = new DateTime(2019, 12, 20);
            //
            // Opgave 2
            //
            Console.WriteLine(myBirthDate.ToLongDateString());
            Console.WriteLine(queensBirthDate.ToLongDateString());
            Console.WriteLine(constitutionDate.ToLongDateString());
            Console.WriteLine(firstHandBallDate.ToLongDateString());
            Console.WriteLine(aspitChristmasDate.ToLongDateString());
            Console.WriteLine(myBirthDate.ToShortDateString());
            Console.WriteLine(queensBirthDate.ToShortDateString());
            Console.WriteLine(constitutionDate.ToShortDateString());
            Console.WriteLine(firstHandBallDate.ToShortDateString());
            Console.WriteLine(aspitChristmasDate.ToShortDateString());
            Console.WriteLine(myBirthDate.ToString());
            Console.WriteLine(queensBirthDate.ToString());
            Console.WriteLine(constitutionDate.ToString());
            Console.WriteLine(firstHandBallDate.ToString());
            Console.WriteLine(aspitChristmasDate.ToString());
            //
            // Opgave 3
            // a
            DateTime currentTime = new DateTime(1, 1, 1, 11, 05, 55);
            // b
            DateTime socialActivities = new DateTime(2019, 12, 6, 12, 0, 0);
            // c
            DateTime todayMetInClass = new DateTime(1, 1, 1, 8, 23, 00);
            // d
            DateTime televisionNews = new DateTime(1, 1, 1, 21, 30, 00);
            // e
            DateTime newCurrentTime = new DateTime(1, 1, 1, 11, 09, 05);
            //
            // Opgave 4
            Console.WriteLine(currentTime.ToLongDateString());
            Console.WriteLine(socialActivities.ToLongDateString());
            Console.WriteLine(todayMetInClass.ToLongDateString());
            Console.WriteLine(televisionNews.ToLongDateString());
            Console.WriteLine(newCurrentTime.ToLongDateString());
            Console.WriteLine(currentTime.ToShortDateString());
            Console.WriteLine(socialActivities.ToShortDateString());
            Console.WriteLine(todayMetInClass.ToShortDateString());
            Console.WriteLine(televisionNews.ToShortDateString());
            Console.WriteLine(newCurrentTime.ToShortDateString());
            Console.WriteLine(currentTime.ToString());
            Console.WriteLine(socialActivities.ToString());
            Console.WriteLine(todayMetInClass.ToString());
            Console.WriteLine(televisionNews.ToString());
            Console.WriteLine(newCurrentTime.ToString());
        }
    }
}
