using System;

namespace S1._06._03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int firstNumber = 30;
            int secondNumber = 15;


            // Multiply variables
            int numberMultiply = firstNumber + secondNumber;
            // Subtract variables
            int numberSubtract = firstNumber - secondNumber;
            // Times variables
            int numberTimes = firstNumber * secondNumber;
            // Divide Variables
            int numberDevide = firstNumber / secondNumber;


            // Output multiplied result
            Console.WriteLine($"{firstNumber} + {secondNumber} = " + numberMultiply);
            // Output subtracted result
            Console.WriteLine($"{firstNumber} - {secondNumber} = " + numberSubtract);
            // Output times result
            Console.WriteLine($"{firstNumber} * {secondNumber} = " + numberTimes);
            // Output devided result
            Console.WriteLine($"{firstNumber} / {secondNumber} = " + numberDevide);


            // Prevent close before keypress
            Console.ReadLine();
        }
    }
}
