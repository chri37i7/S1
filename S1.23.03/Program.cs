using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace S1._23._03
{
    class Program
    {
        // List for storing box objecs
        private static List<Person> personList = new List<Person>();

        // Lists for string person values 
        private static List<string> firstNameList = new List<string>();
        private static List<string> lastNameList = new List<string>();
        private static List<int> ageList = new List<int>();

        static void Main()
        {
            // Define path
            string path = @"C:\Users\chri37i7\Desktop\persons.txt";

            // Find out who is oldest
            WhoIsOldest(path);

            // Find out who is youngest
            WhoIsYoungest(path);

            // Find who has longest first name
            LongestFirstName(path);

            // Find who has shortest first name
            ShortestFirstName(path);

            // Find who has longest name
            LongestName(path);

            // Find who has shortest name
            ShortestName(path);
        }

        static void WhoIsOldest(string path)
        {
            if(CreatePersons(path) == true)
            {
                Person oldestPerson = personList[0];
                foreach(Person person in personList)
                {
                    if(person.Age > oldestPerson.Age)
                    {
                        oldestPerson = person;
                    }
                }
                Console.WriteLine("Ældste: " + oldestPerson.FirstName);
            }
            else
            {
                Console.WriteLine("FEJL!");
            }
        }

        static void WhoIsYoungest(string path)
        {
            if(CreatePersons(path) == true)
            {
                Person youngestPerson = personList[0];
                foreach(Person person in personList)
                {
                    if(person.Age < youngestPerson.Age)
                    {
                        youngestPerson = person;
                        
                    }
                }
                Console.WriteLine("Yngste: " + youngestPerson.FirstName);
            }
            else
            {
                Console.WriteLine("FEJL!");
            }
        }

        static void LongestFirstName(string path)
        {
            if(CreatePersons(path) == true)
            {
                Person longestFirstName = personList[0];
                foreach(Person person in personList)
                {
                    if(person.FirstName.Count() >= longestFirstName.FirstName.Count())
                    {
                        longestFirstName = person;
                        
                    }
                }
                Console.WriteLine("Længste fornavn: " + longestFirstName.FirstName);
            }
            else
            {
                Console.WriteLine("FEJL!");
            }
        }

        static void ShortestFirstName(string path)
        {
            if(CreatePersons(path) == true)
            {
                Person shortestFirstName = personList[0];
                foreach(Person person in personList)
                {
                    if(person.FirstName.Count() <= shortestFirstName.FirstName.Count())
                    {
                        shortestFirstName = person;

                    }
                }
                Console.WriteLine("Korteste fornavn: " + shortestFirstName.FirstName);
            }
            else
            {
                Console.WriteLine("FEJL!");
            }
        }

        static void LongestName(string path)
        {
            if(CreatePersons(path) == true)
            {
                Person longestName = personList[0];
                foreach(Person person in personList)
                {
                    if(person.FirstName.Count() >= longestName.FirstName.Count() && person.LastName.Count() >= longestName.LastName.Count())
                    {
                        longestName = person;

                    }
                }
                Console.WriteLine("Længste fornavn & efternavn: " + longestName.FirstName);
            }
            else
            {
                Console.WriteLine("FEJL!");
            }
        }

        static void ShortestName(string path)
        {
            if(CreatePersons(path) == true)
            {
                Person shortestName = personList[0];
                foreach(Person person in personList)
                {
                    if(person.LastName.Count() <= shortestName.LastName.Count() && person.FirstName.Count() <= shortestName.FirstName.Count())
                    {
                        shortestName = person;

                    }
                }
                Console.WriteLine("Korteste fornavn & efternavn: " + shortestName.FirstName);
            }
            else
            {
                Console.WriteLine("FEJL!");
            }
        }

        static bool CreatePersons(string path)
        {
            // Check if file exists on defined path
            bool pathExists = File.Exists(path);

            // If path exists
            if(pathExists == true)
            {
                // 
                GetPersonFromFile(path);
                for(int i = 0; i != ageList.Count; i++)
                {
                    try
                    {
                        Person person = new Person(firstNameList[i], lastNameList[i], ageList[i]);
                        personList.Add(person);
                    }
                    catch(ArgumentOutOfRangeException)
                    {
                        // Return values
                        return false;
                    }
                }
                return true;
            }
            // If path does not exist
            else if(pathExists == false)
            {
                return false;
            }
            return false;
        }

        /*
         *
         * Load 
         * 
         */

        static void GetPersonFromFile(string path)
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
                string[] readerArray = documentLine.Split(",");
                // Loop
                for(int i = 0; i < readerArray.Length; i += 4)
                {
                    string sum = readerArray[i];
                    firstNameList.Add(sum);
                }
                // Loop
                for(int i = 1; i < readerArray.Length; i += 4)
                {
                    string sum = readerArray[i];
                    lastNameList.Add(sum);
                }
                // Loop
                for(int i = 2; i < readerArray.Length; i += 4)
                {
                    int.TryParse(readerArray[i], out int sum);
                    ageList.Add(sum);
                }
            }
        }
    }
}