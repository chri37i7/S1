using System;

namespace S1._10._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tryk på en tast: ");
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            switch(keyInfo.Key)
            {
                case ConsoleKey.A:
                case ConsoleKey.E:
                case ConsoleKey.I:
                case ConsoleKey.O:
                case ConsoleKey.U:
                case ConsoleKey.Y:
                    Console.WriteLine("\nDu indtastede en vokal");
                    break;
                case ConsoleKey.B:
                case ConsoleKey.C:
                case ConsoleKey.D:
                case ConsoleKey.F:
                case ConsoleKey.G:
                case ConsoleKey.H:
                case ConsoleKey.J:
                case ConsoleKey.K:
                case ConsoleKey.L:
                case ConsoleKey.M:
                case ConsoleKey.N:
                case ConsoleKey.P:
                case ConsoleKey.Q:
                case ConsoleKey.R:
                case ConsoleKey.S:
                case ConsoleKey.T:
                case ConsoleKey.V:
                case ConsoleKey.W:
                case ConsoleKey.X:
                case ConsoleKey.Z:
                    Console.WriteLine("\nDu indtastede en konsonant");
                    break;
                case ConsoleKey.Escape:
                    break;
                default:
                    Console.WriteLine("FEJL! Du trykkede ikke på et bogstav.");
                    break;
            }

        }
    }
}
