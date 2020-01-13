using System;

namespace S1._06._04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int firstNumber = 10;
            int secondNumber = 3;


            // Save division result
            double firstResult = firstNumber / secondNumber;
            // Outout saved result
            Console.WriteLine($"Division med int datatypen gemt i en double:\n{firstNumber} / {secondNumber} = {firstResult}\n");


            // Save converted result
            double secondResult = (double)firstNumber / (double)secondNumber;
            // Output converted result
            Console.WriteLine($"Division med konverterede int til double datatype:\n{firstNumber} / {secondNumber} = {secondResult}\n");
            // Output converted result with 2 decimals
            Console.WriteLine("Forketet til to decimaler\n{0} / {1} = {2,2:f}", firstNumber, secondNumber, secondResult);


            // Save modulus in residual 
            int restVar = firstNumber % secondNumber;
            // Output modulus
            Console.WriteLine($"\nModulus:\n {firstNumber} % {secondNumber} = {restVar}");


            Console.ReadLine();
        }
    }
}
