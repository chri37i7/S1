using System;

namespace S1._18._02._02
{
    class Program
    {
        static void Main()
        {
            PrintToConsole();
            string firstInput = Console.ReadLine();
            TimeSpan firstTime = StringToTimeSpan(firstInput);


            PrintToConsole();            
            string secondInput = Console.ReadLine();
            TimeSpan secondTime = StringToTimeSpan(secondInput);


            Console.WriteLine(firstTime.Subtract(secondTime));
        }

        static TimeSpan StringToTimeSpan(string userInput)
        {
            // Convert userInput to TimeSpan
            TimeSpan.TryParse(userInput, out TimeSpan stringToTimeSpan);

            return stringToTimeSpan;
        }

        static void PrintToConsole()
        {
            Console.WriteLine("Indtast to tidspunker, og få tidsforskellen. Format(Dag:Time:Minut:Sekund)");
            Console.Write("Indtast tidspunkt: ");
        }
    }
}