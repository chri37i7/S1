using System;

namespace S1._17._02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Opgave 1
            DateTime rightNow = DateTime.Now;
            // 
            DateTime today = DateTime.Today;
            // 
            DateTime utcNow = DateTime.UtcNow;
            //
            Console.WriteLine(rightNow);
            Console.WriteLine(today);
            Console.WriteLine(utcNow);
            //
            Console.WriteLine();
            // Opgave 2
            // 
            DateTime now = DateTime.Now;

            // a
            TimeSpan oneHour = new TimeSpan(365, 0, 0, 0);

            DateTime oneYearMore = (now + oneHour);

            Console.WriteLine(oneYearMore.ToString());

            // b
            TimeSpan twoYears = new TimeSpan(731, 0, 0, 0);

            DateTime twoYearsLess = (now - twoYears);

            Console.WriteLine(twoYearsLess.ToString());

            // c
            TimeSpan thirtyDays = new TimeSpan(30, 0, 0, 0);

            DateTime thirtyDaysMore = (now + thirtyDays);

            Console.WriteLine(thirtyDaysMore.ToString());

            // d
            TimeSpan sevenTeenDays = new TimeSpan(17, 0, 0, 0);

            DateTime sevenTeenDaysLess = (now - sevenTeenDays);

            Console.WriteLine(sevenTeenDaysLess.ToString());

            // e
            TimeSpan threeMonths = new TimeSpan(91, 0, 0, 0);

            DateTime threeMonthsMore = (now + threeMonths);

            Console.WriteLine(threeMonthsMore.ToString());

            // f
            TimeSpan sevenMonths = new TimeSpan(213, 0, 0, 0);

            DateTime sevenMonthsLess = (now - sevenMonths);

            Console.WriteLine(sevenMonthsLess.ToString());

            // g
            TimeSpan twentyThreeHours = new TimeSpan(23);

            DateTime twentyThreeHoursMore = (now + twentyThreeHours);

            Console.WriteLine(twentyThreeHoursMore.ToString());

            // h
            TimeSpan elevenHours = new TimeSpan(11);

            DateTime elevenHoursLess = (now - elevenHours);

            Console.WriteLine(elevenHoursLess.ToString());

            // i
            TimeSpan twentyThreeHoursAndSevenTeenMinutes = new TimeSpan(23, 17, 0);

            DateTime twentyThreeHoursAndSevenTeenMinutesLess = (now - twentyThreeHoursAndSevenTeenMinutes);

            Console.WriteLine(twentyThreeHoursAndSevenTeenMinutesLess.ToString());

            //
            // Opgave 3
            //
            Console.WriteLine();

            DateTime owo = DateTime.Now;

            DateTime uwu = owo;

            Console.WriteLine(owo.ToString());
            Console.WriteLine(uwu.ToString());

            //
            // Opgave 4
            //
            Console.WriteLine();

            bool isLeapYear = DateTime.IsLeapYear(2019);

            Console.WriteLine(isLeapYear);
        }
    }
}