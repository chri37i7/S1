using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace S1._23._02
{
    class Program
    {
        // Lists for string box 
        private static List<int> height = new List<int>();
        private static List<int> length = new List<int>();
        private static List<int> width = new List<int>();

        static void Main()
        {
            string path = @"C:\Users\chri37i7\Desktop\boxes.txt";
            //
            if(GetBoxesFromFile(path, out List<Box> boxes) == true)
            {
                foreach(Box box in boxes)
                {
                    // Output message
                    Console.WriteLine(
                        $"Længde: {box.Length}\n" +
                        $"Højde: {box.Height}\n" +
                        $"Længde: {box.Width}\n");
                }

                // Declare list using method
                List<int> boxVolume = CalculateVolume(boxes);
                // Output biggest number in list
                Console.WriteLine("Højeste volumen: " + boxVolume.Max());
                // Output smallest number in list
                Console.WriteLine("Laveste volumen: " + boxVolume.Min());

                // Declare list using method
                List<int> boxSurface = CalculateSurface(boxes);
                // Output biggest number in list
                Console.WriteLine("Højeste overfladeareal: " + boxSurface.Max());
                // Output smallest number in list
                Console.WriteLine("Laveste overfladeareal: " + boxSurface.Min());
            }
            else if(GetBoxesFromFile(path, out List<Box> output) == false)
            {
                Console.WriteLine("Fejl! Check at filen eksisterer, og ikke indeholder bogstaver.");
            }
        }

        static bool GetBoxesFromFile(string path, out List<Box> boxes)
        {
            // List for storing box objecs
            List<Box> boxList = new List<Box>();

            // Check if file exists on defined path
            bool pathExists = File.Exists(path);

            // If path exists
            if(pathExists == true)
            {
                // 
                CreateDimensions(path);
                for(int i = 0; i != height.Count; i++)
                {
                    try
                    {
                        Box box = new Box(height[i], length[i], width[i]);
                        boxList.Add(box);
                    }
                    catch(ArgumentOutOfRangeException)
                    {
                        // Return values
                        boxes = null;
                        return false;
                    }
                }
                // Return values
                boxes = boxList;
                return true;
            }
            // If path does not exist
            else if(pathExists == false)
            {
                // Return values
                boxes = null;
                return false;
            }
            // Return values
            boxes = null;
            return false;
        }

        static void CreateDimensions(string path)
        {
            // Declare StreamReader
            StreamReader documentReader = File.OpenText(path);

            // Empty string for reading document line
            string documentLine;

            // Read the next line
            // If end of line is reached, returns null
            while((documentLine = documentReader.ReadLine()) != null)
            {
                // Split into substring
                string[] numberArray = documentLine.Split(",");
                // Loop
                for(int i = 0; i < numberArray.Length; i += 4)
                {
                    int.TryParse(numberArray[i], out int sum);
                    height.Add(sum);
                }
                // Loop
                for(int i = 1; i < numberArray.Length; i += 4)
                {
                    int.TryParse(numberArray[i], out int sum);
                    length.Add(sum);
                }
                // Loop
                for(int i = 2; i < numberArray.Length; i += 4)
                {
                    int.TryParse(numberArray[i], out int sum);
                    width.Add(sum);
                }
            }
        }

        static List<int> CalculateVolume(List<Box> boxes)
        {
            List<int> volumeList = new List<int>();
            foreach(Box box in boxes)
            {
                int result = box.Length * box.Height * box.Width;
                volumeList.Add(result);
            }
            return volumeList;
        }

        static List<int> CalculateSurface(List<Box> boxes)
        {
            List<int> surfaceList = new List<int>();
            foreach(Box box in boxes)
            {
                // b * h + h * l + b * l
                int result = box.Width * box.Height + box.Height * box.Length + box.Width * box.Length;
                surfaceList.Add(result);
            }
            return surfaceList;

        }
    }
}