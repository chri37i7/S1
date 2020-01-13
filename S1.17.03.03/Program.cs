using System;

namespace S1._17._03._03
{
    class Program
    {
        /*
            Format: Fødselsdato - Dagens dato

            // Født > Dato	
            Født: 2001 12 11 
            Dato: 2019 12 10 

            Regnestykke:
            (20191210 - 20011211) / 10000 = 17.9999


            // Født < Dato
            Født: 2001 12 10
            Dato: 2019 12 11

            Regnestykke:
            (20191211 - 20011210) / 10000 = 18.0001


            Spørgsmål:
            Hvis jeg er født i dag for 18 år siden, men datoen er i går. hvor gammel er jeg?
        */
        private static void Main()
        {
            // Loop program
            while(true)
            {
                // Clear console from previous I/O
                ClearConsole();
                // Write message & ask for input
                Console.WriteLine("Indtast din fødselsdagsdato i formatet (år, måned, dag)");
                Console.Write("Indtast dato: ");
                // Store input in string
                string userInput = Console.ReadLine();
                // Test input with statements
                ErrorCheck(userInput);
            }
        }

        /*
         *  Statement Checking Methods
         */

        private static void ErrorCheck(string userInput)
        {
            if(IsDateCorrectFormat(userInput) == false)
            {
                // Output error using method
                ErrorMessage("Du anvendte et forkert format");
            }
            else if(IsBirthBeforeToday(userInput) == false)
            {
                // Output error using method
                ErrorMessage("Datoen er højere end nuværende dato");
            }
            else
            {
                // Go to AgeCheck
                AgeCheck(userInput);
            }
        }

        private static void AgeCheck(string userInput)
        {
            // Check statements using UserAge method
            if(AgeCalculation(userInput) >= 18)
            {
                // Write message using method
                WriteMessage("Du må købe øl, spiritus, og tage kørekort!");
            }
            else if(AgeCalculation(userInput) >= 17)
            {
                // Write message using method
                WriteMessage("Du må købe øl, og tage kørekort!");
            }
            else if(AgeCalculation(userInput) >= 16)
            {
                // Write message using method
                WriteMessage("Du må købe øl!");
            }
            else if(AgeCalculation(userInput) <= 15)
            {
                // Write message using method
                WriteMessage("Du må intet!");
            }
        }

        /*
         *  Age Calculation Method
         */ 

        private static int AgeCalculation(string userInput)
        {
                // Calculate age
                int ageResult = (FindCurrentDate() - FindBirthDate(userInput)) / 10000;

                // Return result
                return ageResult;
        }

        /*
         *  Find Date Methods
         */

        private static int FindBirthDate(string userInput)
        {
            // Convert userInput to DateTime
            DateTime.TryParse(userInput, out DateTime outputAge);

            // Convert DateTime to int
            int birthDate = Convert.ToInt32(outputAge.ToString("yyyyMMdd"));

            // Return birthDate int
            return birthDate;
        }

        private static int FindCurrentDate()
        {
            // Current system date
            int currentDate = int.Parse(DateTime.Now.ToString("yyyyMMdd"));

            // Return date
            return currentDate;
        }

        /*
         *   Checking methods
         */

        private static bool IsBirthBeforeToday(string birthDateInput)
        {
            // Error in BirthDate is after today
            if(FindCurrentDate() < FindBirthDate(birthDateInput))
            {
                // Return false is after today
                return false;
            }
            else 
            {
                // Return true if before today
                return true;
            }            
        }

        private static bool IsDateCorrectFormat(string userInput)
        {
            // Error if input conversion fails
            if(FindBirthDate(userInput) == 10101)
            {
                // Return false if wrong format
                return false;
            }
            else
            {
                // Return true if correct format
                return true;
            }
        }

        /*
         *  Misc Methods
         */

        private static void ErrorMessage(string errorMessageInput)
        {
            // Clear console & change background color
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;

            // Output error message & pause console
            Console.WriteLine("FEJL! {0}.", errorMessageInput);
            Console.ReadLine();

            // Reset console color & clear console
            Console.ResetColor();
            Console.Clear();
        }

        private static void WriteMessage(string writeMessageInput)
        {
            // Output message
            Console.WriteLine("{0}", writeMessageInput);

            // Pause console
            Console.ReadLine();
        }

        private static void ClearConsole()
        {
            // Reset console color
            Console.ResetColor();

            // Clear console
            Console.Clear();
        }
    }
}