using System;
using System.IO;
using System.Collections.Generic;

namespace S1._23._01._02
{
    class Program
    {
        static void Main()
        {
            // Path to file
            string path = @"C:\Users\chri37i7\Desktop\hundredRandomNumbers.txt";

            // Statements
            if(GetNumbersFromFile(path, out List<int> numberList) == true)
            {
                // Output first number in list for testing
                Console.WriteLine(numberList[0]);
            }
            else if(GetNumbersFromFile(path, out numberList) == false)
            {
                // Output error
                Console.WriteLine("Fejl! Filstien findes ikke.");
            }
        }

        static bool GetNumbersFromFile(string path, out List<int> numbers)
        {
            // Declare new list for storing numbers
            List<int> numberList = new List<int>();

            bool fileExists = File.Exists(path);

            if (fileExists == false)
            {
                numbers = null;
                return false;
            }
            if (fileExists == true)
            {
                // Declare StreamReader
                StreamReader documentReader = File.OpenText(path);

                // Empty string for reading document line
                string documentLine;

                // Read the next line
                // If end of line is reached, returns null
                while ((documentLine = documentReader.ReadLine()) != null)
                {
                    // Split into substring
                    string[] numberArray = documentLine.Split("\t");
                    // Loop
                    for (int i = 0; i < numberArray.Length; i++)
                    {

                        int.TryParse(numberArray[i], out int sum);
                        numberList.Add(sum);
                    }
                }
                numbers = numberList;
                return true;
            }
            numbers = null;
            return false;
        }
    }
}