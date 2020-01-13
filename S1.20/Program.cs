using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Globalization;

namespace S1._20_01
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(CalcSum(27, 82, 38, 29, 38, 48, 23, 27, 38));
            Console.WriteLine(Concatenate('g', 'a', 'y'));
            Console.WriteLine(Concatenate("Furries", "er", "gay"));
            PrintWelcome("it");

            string test = "gay";
            SetFirstCharToUpper(ref test);
        }

        static int CalcSum(params int[] sumArray)
        {
            int totalSum = sumArray.Sum();

            return totalSum;
        }

        static string Concatenate(params char[] charLetters)
        {
            string concatenatedString = new string(charLetters);

            return concatenatedString;
        }

        static string Concatenate(params string[] inputStrings)
        {
            string concatenatedString = String.Join(" ", inputStrings);

            return concatenatedString;
        }

        static void PrintWelcome(string language)
        {
            if(language == "da")
            {
                Console.WriteLine("Hej Verden!");
            }
            else if(language == "en")
            {
                Console.WriteLine("Hello World!");
            }
            else if(language == "de")
            {
                Console.WriteLine("Hallo Welt!");
            }
            else if(language == "it")
            {
                Console.WriteLine("Ciao Mondo!");
            }
            else if(language == "cn")
            {
                Console.WriteLine("你好世界");
            }
            else
            {
                Console.WriteLine("FEJL! Forkert format.");
            }
        }

        static void SetFirstCharToUpper(ref string input)
        {
            TextInfo myTI = new CultureInfo("en-US", false).TextInfo;
            if(input.Length > 1)
            {
                Console.WriteLine("{0}", myTI.ToTitleCase(input));
            }
        }
    }
}   
