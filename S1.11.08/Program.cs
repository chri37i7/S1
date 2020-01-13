using System;

namespace S1._11._08
{
    class Program
    {
        static void Main(string[] args)
        {
            string exitProgram = "";
            do
            {
                Random rnd = new Random();
                int firstNumber = rnd.Next(1, 11);
                int secondNumber = rnd.Next(1, 11);
                int result = firstNumber + secondNumber;
                while(true)
                {
                    Console.WriteLine(firstNumber + " + " + secondNumber + " ?");
                    Console.Write("Skriv dit svar: ");
                    string userInput = Console.ReadLine().ToLower();
                    exitProgram = userInput;
                    int.TryParse(userInput, out int answer);
                    if(answer == result)
                    {
                        Console.WriteLine("Tillykke, du har svaret rigtigt!");
                        Console.ReadLine();
                        break;
                    }
                    else if(userInput == "q")
                    {
                        break;
                    }
                    else if(answer == 0)
                    {
                        Console.WriteLine("Du har ikke indtastet noget.");
                    }
                    else if(answer > result || answer < result)
                    {
                        Console.WriteLine("Desværre, det er ikke det rigtige svar. Prøv igen.");
                    }
                    else
                    {
                        Console.WriteLine("FEJL!");
                    }
                }
                Console.Clear();
            } while(exitProgram != "q");
        }
    }
}
