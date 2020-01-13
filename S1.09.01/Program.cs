using System;

namespace S1._09._01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 4;

            // Udsagn:
            //
            // 1 - True - Korrekt
            Console.WriteLine(a == b || a > 0);
            // 2 - True - Korrekt
            Console.WriteLine(a + b > 0 && a > 0);
            // 3 - False - Korrekt
            Console.WriteLine(a == 5 && a + b > 0);
            // 4 - False - Korrekt
            Console.WriteLine((true || false) && a > b);
            // 5 - False - Korrekt
            Console.WriteLine(3 > 5 && true || a == b);
            // 6 - True - Korrekt
            Console.WriteLine(b > a && true || false || b > 4);
            // 7 - True - Korrekt
            Console.WriteLine(b < 4 && a < b || a + b > 4 && true);
            // 8 - True - Korrekt
            Console.WriteLine(true && true || false);
            // 9 - False - Korrekt
            Console.WriteLine(true && false && true);
            // 10 - True - Korrekt
            Console.WriteLine(true || false || false);
            // 11 - False - Korrekt
            Console.WriteLine(false && false);
            // 12 - True - Korrekt
            Console.WriteLine(a == 3 && b > 4 || a + 3 > b);
            // 13 - False - Korrekt
            Console.WriteLine(a > b && b < a && a + a == b);
            //
            // Alt gættet rigtigt :D!
        }
    }
}
