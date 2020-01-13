using System;

namespace S1._06._05
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1. −5 ⋅ 2+(−6⋅−2) = 2
             * 
             * 2. 11+(−20)+36⋅(−8) = ?????????
             * 
             * 3. −1234567+9876543 = 8642592
             * 
             * 4. 2⋅(2+2−2−2)⋅2⋅2 = 0
             * 
             * 5. 3,14⋅0 = 0
             * 
             * 6. 2,7−7,2 = -5,5
             * 
             * 7. 2,7⋅0,1+(−3,14+6⋅7,5) = ??
             */

            // 1.
            // Calculate
            double firstCalculation = -5 * 2 + (-6 * -2);
            // Output
            Console.WriteLine("Spørgsmål nr. 1:  " + firstCalculation);
            //
            // 2.
            // Calculate
            double secondCalculation = 11 + (-20) + 36 * (-8);
            // Output
            Console.WriteLine("\nSpørgsmål nr. 2:  " + secondCalculation);
            //
            // 3.
            // Calculate
            double thirdCalculation = -1234567 + 9876543;
            // Output 
            Console.WriteLine("\nSpørgsmål nr. 3:  " + thirdCalculation);
            //
            // 4.
            // Calculate
            int fourthCalculation = 2 * (2 + 2 - 2 - 2) * 2 * 2;
            // Output
            Console.WriteLine("\nSpørgsmål nr. 4:  " + fourthCalculation);
            //
            // 5.
            // Calculate
            double fifthCalculation = 3.14 * 0;
            // Output
            Console.WriteLine("\nSpørgsmål nr. 5:  " + fifthCalculation);
            //
            // 6.
            // Calculate
            double sixthCalculation = 2.7 - 7.2;
            // Output
            Console.WriteLine("\nSpørgsmål nr. 6:  " + sixthCalculation);
            //
            // 7.
            // Calculate
            double seventhCalculation = 2.7 * 0.1 + (-3.14 + 6 * 7.5);
            // Output
            Console.WriteLine("\nSpørgsmål nr. 7:  " + seventhCalculation);
            //
            // Prevent close before keypress
            Console.ReadLine();
        }
    }
}
