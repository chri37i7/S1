using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace StarTrek
{
    class Program
    {
        static string path = @"C:\Users\baek\Documents\startrek.txt";
        static List<string> fileNamesList = new List<string>();

        static void Main()
        {
            // FirstTaskMethod();
            // SecondTaskMethod();
            // ThirdTaskMethod();
        }

        static void FirstTaskMethod()
        {
            // Opgave 1   
            string[] firstArray = { "S", "Sp", "Sk", "St", "T" };
            string[] secondArray = { "a", "e", "i", "o", "u", "y" };
            string[] thirdArray = { "r", "t", "p", "d", "f", "j", "k", "l", "v", "b", "n", "m" };
            string[] fourthArray = { "a", "e", "i", "o", "u", "y" };
            string[] fifthArray = { "q", "p", "k", "ck", "l" };

            for(int i = 0; i != 25000; i++)
            {
                CreateNameList();

                Random firstRndNum = new Random();
                int a = firstRndNum.Next(0, firstArray.Length);

                Random secondRndNum = new Random();
                int b = secondRndNum.Next(0, secondArray.Length);

                Random thirdRndNum = new Random();
                int c = thirdRndNum.Next(0, thirdArray.Length);

                Random fourthRndNum = new Random();
                int d = fourthRndNum.Next(0, fourthArray.Length);

                Random fifthRndNum = new Random();
                int e = fifthRndNum.Next(0, fifthArray.Length);

                string name = firstArray[a] + secondArray[b] + thirdArray[c] + fourthArray[d] + fifthArray[e];

                if(!fileNamesList.Contains(name))
                {
                    using(StreamWriter writer = new StreamWriter(path, true, Encoding.Default))
                    {
                        writer.WriteLine(name);

                        fileNamesList.Clear();
                    }
                }
            }
        }

        static void SecondTaskMethod()
        {
            // Opgave 2
            string[] firstNameArray = { "S", "Sp", "Sk", "St", "T" };
            string[] secondNameArray = { "a", "e", "i", "o", "u", "y" };
            string[] thirdNameArray = { "q", "p", "k", "ck", "l" };


            for(int i = 0; i != 1500; i++)
            {
                CreateNameList();

                Random firstNameRndNum = new Random();
                int firstRandom = firstNameRndNum.Next(0, firstNameArray.Length);

                Random secondNameRndNum = new Random();
                int secondRandom = secondNameRndNum.Next(0, secondNameArray.Length);

                Random thirdNameRndNum = new Random();
                int thirdRandom = thirdNameRndNum.Next(0, thirdNameArray.Length);

                string firstName = firstNameArray[firstRandom] + secondNameArray[secondRandom] + thirdNameArray[thirdRandom];

                if(!fileNamesList.Contains(firstName))
                {
                    using(StreamWriter writer = new StreamWriter(path, true, Encoding.Default))
                    {
                        writer.WriteLine(firstName);

                        fileNamesList.Clear();
                    }
                }
            }
        }

        static void ThirdTaskMethod()
        {
            // Opgave 3
            string[] firstArray = { "T’" };
            string[] secondArray = { "P", "K", "Q" };
            string[] thirdArray = { "a", "e", "i", "o", "u", "y" };
            string[] fourthArray = { "r", "j", "’p", "k", "l" };


            for(int i = 0; i != 1000; i++)
            {
                CreateNameList();

                Random firstRndNum = new Random();
                int a = firstRndNum.Next(0, firstArray.Length);

                Random secondRndNum = new Random();
                int b = secondRndNum.Next(0, secondArray.Length);

                Random thirdRndNum = new Random();
                int c = thirdRndNum.Next(0, thirdArray.Length);

                Random fourthRndNum = new Random();
                int d = fourthRndNum.Next(0, fourthArray.Length);

                string name = firstArray[a] + secondArray[b] + thirdArray[c] + fourthArray[d];

                if(!fileNamesList.Contains(name))
                {
                    using(StreamWriter writer = new StreamWriter(path, true, Encoding.Default))
                    {
                        writer.WriteLine(name);

                        fileNamesList.Clear();
                    }
                }
            }
        }

        static void CreateNameList()
        {
            // FileStream & StreamReader for reading the textfile
            using(FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                using(StreamReader reader = new StreamReader(fileStream))
                {
                    while(!reader.EndOfStream)
                    {
                        string documentLine;
                        // Read until end is reached
                        while((documentLine = reader.ReadLine()) != null)
                        {
                            // Split document lines into array
                            string[] lineArray = documentLine.Split("\t");

                            // Create film object with array
                            string textLine = lineArray[0];
                            // Add film to list
                            fileNamesList.Add(textLine);
                        }
                    }
                }
            }
        }
    }
}