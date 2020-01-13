using System;
using System.IO;
using System.Text;
using System.Linq;


namespace S1._23._01
{
    class Program
    {
        static void Main()
        {
            // Define path
            string path = @"C:\Users\chri37i7\Desktop\hundredRandomNumbers.txt";

            // Declare int for sum
            int numberSum = 0;

            // Declare int for average
            int numberAverage = 0;

            // Create using block with StreamReader object
            using(StreamReader documentReader = File.OpenText(path))
            {
                // Empty string for reading document line
                string documentLine = "";
                // Read the next line
                // If end of line is reached, returns null
                while((documentLine = documentReader.ReadLine()) != null)
                {
                    string[] numbers = documentLine.Split("\t");
                    for(int i = 0; i < numbers.Length; i++)
                    {
                        int.TryParse(numbers[i], out int sum);
                        numberSum += sum; 
                    }
                    numberAverage = numberSum / 100;
                }
                Console.WriteLine(numberAverage);
                Console.WriteLine(numberSum);
            }
        }
    }
}
