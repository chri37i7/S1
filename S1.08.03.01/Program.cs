using System;

namespace S1._08._03._01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("iNdtAsT eT tAL: ");
            string firstNum = Console.ReadLine();
            int.TryParse(firstNum, out int firstOut);
            Console.WriteLine("InD TAst Et AnDEt TAl: ");
            string secondNum = Console.ReadLine();
            int.TryParse(secondNum, out int secondOut);
            if(firstOut == secondOut)
            {
                Console.WriteLine("Tallene er ens!");
            }
            else
            {
                Console.WriteLine("Tallene er ikke ens.");
            }
        }
    }
}
