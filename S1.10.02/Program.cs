using System;

namespace S1._10._02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast et familiemedlem (f.eks. mor, bedstefar eller ligende).");
            Console.Write("Indtast et familiemedlem: ");
            string familyMember = Console.ReadLine().ToLower();

            switch(familyMember)
            {
                case "mor":
                case "far":
                    Console.WriteLine("Du har indtastet et 2. generationsmedlem af familien.");
                    break;
                case "farmor":
                case "mormor":
                    Console.WriteLine("Du har indtastet et 3. generationsmedlem af familien.");
                    break;
                default:
                    Console.WriteLine("FEJL! Du har indtastet et ukendt familiemedlem.");
                    break;
            }
        }
    }
}
