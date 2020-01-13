using System;

namespace S1._21._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Print();

            Print(4);

            PrintResult(8, 6);

            Console.WriteLine(IsPositive(16));

            Console.WriteLine(IsEven(2));

            CalculateAndPrint(7);


            Console.WriteLine(Max(7,3));


            string firstInput = Console.ReadLine();
            double.TryParse(firstInput, out double firstConvertedInt);

            string secondInput = Console.ReadLine();
            double.TryParse(secondInput, out double secondConvertedInt);

            Console.WriteLine(Max(firstConvertedInt, secondConvertedInt));
        }

        private static void Print()
        {
            Console.WriteLine("Hello World! from a method!");
        }

        private static void Print(int heltal)
        {
            Console.WriteLine("Tallet er: {0}", heltal);
        }

        private static void PrintResult(int firstNumber, int secondNumber)
        {
            int plusResult = firstNumber + secondNumber;
            Console.WriteLine("{0} plus {1} giver: {2}",
                firstNumber,
                secondNumber,
                plusResult);

            int minusResult = firstNumber - secondNumber;
            Console.WriteLine("{0} plus {1} giver {2}",
                firstNumber,
                secondNumber,
                minusResult);

            int multiplicationResult = firstNumber * secondNumber;
            Console.WriteLine("{0} plus {1} giver {2}",
                firstNumber,
                secondNumber,
                multiplicationResult);

            int divisionResult = firstNumber / secondNumber;
            Console.WriteLine("{0} plus {1} giver {2}",
                firstNumber,
                secondNumber,
                divisionResult);
        }



        private static bool IsPositive(int positiveNumber)
        {
            if (positiveNumber > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsEven(int evenNumber)
        {
            if (evenNumber % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static void CalculateAndPrint(int squareNumber)
        {
            if (IsPositive(squareNumber) == true)
            {
                Console.WriteLine(squareNumber * squareNumber);

                Console.WriteLine("Kvadtratroden er: " + Math.Sqrt(squareNumber));
            }
            else if (IsPositive(squareNumber) == false)
            {
                Console.WriteLine(squareNumber * squareNumber);


                Console.Write(" ");
            }
        }

        private static double Max(double firstHighestNumber, double secondHighestNumber)
        {
            if (firstHighestNumber > secondHighestNumber)
            {
                return firstHighestNumber;
            }
            else if(firstHighestNumber < secondHighestNumber)
            {
                return secondHighestNumber;
            }
            return 0;
        }

        private static int Max(int firstHighestNumber, int secondHighestNumber)
        {
            if(firstHighestNumber > secondHighestNumber)
            {
                return firstHighestNumber;
            }
            else if(firstHighestNumber < secondHighestNumber)
            {
                return secondHighestNumber;
            }
            return 0;
        }
    }
}   
