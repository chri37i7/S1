using System;
using System.Threading;

namespace S1._21._03
{
    class Program
    {
        /*
         *   Menu Methods
         */

        static void Main()
        {
            // Clear Previous Input
            ClearConsole();

            // Menu Header
            PrintMenuHeader("Hovedmenu");
            // Menu Items
            PrintMenuItems("Gå til udregninger.", "Gå til tal.", "Afslut programmet.");

            // Hide input char
            Console.ForegroundColor = ConsoleColor.Black;

            // Choose Menu Options
            MainMenuOptions();
        }

        static void Calculation()
        {
            // Clear Previous Input
            ClearConsole();

            // Menu Header
            PrintMenuHeader("Udregninger");
            // Menu Items
            PrintMenuItems("Kvadrat og kvadratrod.", "Tilbage til hovedmenu.");

            // Hide input char
            Console.ForegroundColor = ConsoleColor.Black;

            // Choose Menu Options
            CalculationMenuOptions();
        }

        static void Numbers()
        {
            // Clear Previous Input
            ClearConsole();

            // Menu Header
            PrintMenuHeader("Tal");
            // Menu Items
            PrintMenuItems("Er tallet positivt?", "Er tallet lige?", "Tilbage til hovedmenu.");

            // Hide input char
            Console.ForegroundColor = ConsoleColor.Black;

            // Choose Menu Options
            NumbersMenuOptions();
        }

        /*
         *   Menu Option Methods
         */

        private static void MainMenuOptions()
        {
            // Register keypress
            char UserKeyPress = Console.ReadKey().KeyChar;

            // First option
            if (UserKeyPress == '1')
            {
                // Go to Calculation
                Calculation();
            }
            // Second option
            else if (UserKeyPress == '2')
            {
                // Go to Numbers
                Numbers();
            }
            // Third option
            else if (UserKeyPress == '3')
            {
                // Shut the program down
                ExitProgram();
            }
            // Prevent shutdown if other keys are presset
            else
            {
                // Return to Main menu
                Main();
            }
        }

        private static void CalculationMenuOptions()
        {
            // Register keypress
            char UserKeyPress = Console.ReadKey().KeyChar;

            // First option
            if (UserKeyPress == '1')
            {
                // Clear Previous Input
                ClearConsole();

                // Output message & ask for input
                Console.WriteLine("Indtast et tal, og få udregnet kvadratet. Og kvadratroden hvis det er et lige tal.");
                Console.Write("Indtast tal: ");

                // Take input & convert input to double
                string userInput = Console.ReadLine();
                int.TryParse(userInput, out int squareUserNumber);

                // Calculate square number
                CalculateAndPrintSquare(squareUserNumber);
            }
            // Second option
            else if (UserKeyPress == '2')
            {
                // Return to main menu
                Main();
            }
            // Prevent shutdown if other keys are presset
            else
            {
                // Return to Calculation Menu
                Calculation();
            }
        }

        private static void NumbersMenuOptions()
        {
            // Register keypress
            char UserKeyPress = Console.ReadKey().KeyChar;

            // First option
            if (UserKeyPress == '1')
            {
                // Clear Previous Input
                ClearConsole();

                // Output message & ask for input
                Console.WriteLine("Indtast et tal, og find ud om det er positivt!");
                Console.Write("Indtast tal: ");

                // Take input & convert input to double
                string InputPositiveNumber = Console.ReadLine();
                double.TryParse(InputPositiveNumber, out double isNumberPositive);
                // If positive output message
                if (IsPositive(isNumberPositive) == true)
                {
                    // Output message
                    Console.WriteLine("Tallet {0} er positivt!",
                        isNumberPositive);

                    // Pause console
                    Console.ReadLine();
                    // Return to Numbers Menu
                    Numbers();
                }
                // If negative output message
                else if (IsPositive(isNumberPositive) == false)
                {
                    // Output message
                    Console.WriteLine("Tallet {0} er negativt.",
                        isNumberPositive);

                    // Pause console
                    Console.ReadLine();
                    // Return to Numbers Menu
                    Numbers();
                }
            }
            // Second option
            else if (UserKeyPress == '2')
            {
                // Clear Previous Input
                ClearConsole();

                // Output message & ask for input
                Console.WriteLine("Indtast et tal, og find ud af om det er lige!");
                Console.Write("Indtast tal: ");

                // Take input & convert input to double
                string InputEvenNumber = Console.ReadLine();
                double.TryParse(InputEvenNumber, out double isNumberEven);
                // If even output message
                if (IsEven(isNumberEven) == true)
                {
                    // Output message
                    ClearConsole();
                    Console.WriteLine("Tallet {0} er lige!",
                        isNumberEven);

                    // Pause console
                    Console.ReadLine();
                    // Return to Numbers Menu
                    Numbers();
                }
                // If not even output message
                else if (IsEven(isNumberEven) == false)
                {
                    // Output message
                    ClearConsole();
                    Console.WriteLine("Tallet {0} er ikke lige.",
                        isNumberEven);

                    // Pause console
                    Console.ReadLine();
                    // Return to Numbers Menu
                    Numbers();
                }

            }
            // Third option
            else if (UserKeyPress == '3')
            {
                // Return to main menu
                Main();
            }
            // Prevent shutdown if other keys are presset
            else
            {
                // Return to Numbers Menu
                Numbers();
            }
        }

        /*
         *   Menu Item Methods
         */

        private static void PrintMenuHeader(
            string menuHeader)
        {
            // Output Menu Input
            Console.WriteLine("*** {0} ***",
                menuHeader);
        }

        private static void PrintMenuItems(
            string firstMenuItem,  // First Input
            string secondMenuItem) // Second Input
        {
            // Output first input
            Console.WriteLine("1) {0}",
                firstMenuItem);
            // Output second input
            Console.WriteLine("2) {0}",
                secondMenuItem);
        }

        private static void PrintMenuItems(
            string firstMenuItem,  // First Input
            string secondMenuItem, // Second Input
            string thirdMenuItem)  // Third Input
        {
            // Output First Input
            Console.WriteLine("1) {0}",
                firstMenuItem);
            // Output Second Input
            Console.WriteLine("2) {0}",
                secondMenuItem);
            // Output Third Input
            Console.WriteLine("3) {0}",
                thirdMenuItem);
        }

        /*
         *   Calculation Methods
         */

        private static bool IsPositive(double positiveNumber)
        {
            // Higher than 0, return true boolean
            if (positiveNumber > 0)
            {
                // Return value
                return true;
            }
            // Else return false boolean
            else
            {
                // Return value
                return false;
            }
        }

        private static bool IsEven(double evenNumber)
        {           
            // Error message
            if (evenNumber <= 0)
            {
                // Output error message
                ErrorMessage();
                // Return to menu
                Numbers();
                // Return value
                return false;
            }
            // Number is even, if modulo is 0
            else if (evenNumber % 2 == 0)
            {
                // Return value
                return true;
            }
            // Else return false boolean
            else
            {
                // Return value
                return false;
            }
        }

        private static void CalculateAndPrintSquare(int squareNumber)
        {
            // Error message
            if(squareNumber == 0)
            {
                // Output error message
                ErrorMessage();
                // Return to menu
                Calculation();
            }
            // Calculate only square
            else if (IsPositive(squareNumber) == false)
            {
                // Clear Previous Input
                ClearConsole();

                // Output square
                Console.WriteLine("Kvadratet er: " + (squareNumber * squareNumber));

                // Pause console
                Console.ReadLine();
                // Return to menu
                Calculation();
            }
            // Calculate square & square root
            else if (IsPositive(squareNumber) == true)
            {
                // Clear Previous Input
                ClearConsole();

                // Output square
                Console.WriteLine("Kvadratet er: " + (squareNumber * squareNumber));
                // Output squareroot
                Console.WriteLine("Kvadtratroden er: " + Math.Sqrt(squareNumber));

                // Pause console
                Console.ReadLine();
                // Return to menu
                Calculation();
            }
            // Go back if everything fails
            else
            {
                // Return to menu
                Calculation();
            }
        }

        /*
         *   Misc Methods
         */

        static void ExitProgram()
        {
            // Clear Previous Input
            ClearConsole();

            // Goodbye message
            Console.WriteLine("Farvel...");

            // Pause for 2.5 seconds
            Thread.Sleep(2500);

            // Shut down programm
            System.Environment.Exit(-1);
        }

        private static void ErrorMessage()
        {
            // Clear console & change background color
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;

            // Output error message & pause console
            Console.WriteLine("FEJL! Der opstod en fejl.");
            Console.ReadLine();

            // Reset console color & clear console
            Console.ResetColor();
            Console.Clear();
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
