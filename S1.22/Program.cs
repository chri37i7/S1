using System;
using System.Linq;
using System.Threading;
using System.Collections.Generic;
using CarHandler;

namespace S1._22
{
    class Program
    {
        public static List<Car> cars = new List<Car>();

        static void Main()
        {
            while(true)
            {
                // Clear console from previous I/O
                ClearConsole();
                // Print message
                PrintMessage();
                // Capture user keypress
                MainMenuOptions();
            }
        }

        private static void MainMenuOptions()
        {
            // Register keypress
            char UserKeyPress = Console.ReadKey().KeyChar;

            // First option
            if(UserKeyPress == '1')
            {
                // Go to EnterCar
                EnterCar();
            }
            // Second option
            else if(UserKeyPress == '2')
            {
                // Go to PrintCarInformation
                PrintCarInformation();
            }
            // Third option
            else if(UserKeyPress == '3')
            {
                // Go to PrintCarInformation
                SearchForCar();
            }
            // Fourth option
            else if(UserKeyPress == '4')
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

        private static void PrintMessage()
        {
            // Output Menu
            Console.WriteLine(
                "Hej, og velkommen til biladministrationen version 1337\n\n" +
                "Du har nu tre muligheder. Ønsker du at:\n" +
                "1)\tIndtaste en bil?\n" +
                "2)\tSe informationer omkring alle biler?\n" +
                "3)\tSøge efter bilmærke?\n" +
                "4)\tAfslutte programmet?");
        }

        /*
         *  Search for car methods
         */

        private static void SearchForCar()
        {
            // Clear console from previous I/O
            ClearConsole();
            // Write message & ask for input
            Console.WriteLine("Indtast bilmærke, og find alle indtastede biler.");
            Console.Write("Indtast mærke: ");
            // Take input & search
            SearchCar(Console.ReadLine().ToLower());
        }

        private static void SearchCar(string userInput)
        {
            // Clear console from previous I/O
            ClearConsole();

            // Counter for counting
            int counter = 0;

            // Does something
            IEnumerable<Car> result = cars.Where(car => car.Make == userInput);

            // Writes message, searches & writes results if found
            Console.WriteLine("Følgende biler blev fundet:");
            foreach(Car car in result)
            {
                Console.WriteLine($"{counter}) {car.Make} {car.Model}, {car.Color}, {car.ProductionYear}");
                counter++;
            }
            // Prevents console continue.
            Console.ReadLine();
        }

        /*
         *  Print car information method
         */

        private static void PrintCarInformation()
        {
            if(cars.Count == 0)
            {
                ErrorMessage("Der er ikke blevet indtastet en bil.");

                Main();
            }

            ClearConsole();
            int counter = 0;
            foreach(Car car in cars)
            {
                Console.WriteLine($"{counter}) Mærke: {car.Make}\tModel: {car.Model}\tFarve: {car.Color}\t Årgang: {car.ProductionYear}");
                counter++;
            }

            Console.WriteLine("\nTryk på en tast, for at gå tilbage.");
            Console.ReadKey();
        }

        /*
         *  Enter Car(First option) methods
         */

        private static void EnterCar()
        {
            // Loop
            while(true)
            {
                // Clear console from previous I/O
                ClearConsole();


                // Car.Make
                Console.Write("Indtast producent: ");
                string carMaker = Console.ReadLine().ToLower();

                // Car.Model
                Console.Write("Indtast model: ");
                string carModel = Console.ReadLine().ToLower();

                // Car.Color
                Console.Write("Indtast farve: ");
                string carPaint = Console.ReadLine().ToLower();

                // Car.ProductionYear
                Console.Write("Indtast årgang: ");
                string userInput = Console.ReadLine();
                int.TryParse(userInput, out int productionYear);


                // Catch exception
                Car inputCar = default;
                try
                {
                    // Create object with inputs
                    inputCar = new Car(carMaker, carModel, productionYear, carPaint);
                }
                catch(ArgumentOutOfRangeException)
                {
                    ErrorMessage("Årstallet er for højt, eller for lavt.");

                    continue;
                }


                // Store input in list
                cars.Add(inputCar);

                // Test car startup
                if(inputCar.StartCar() == true)
                {
                    Console.WriteLine("Bilen startede uden problemer!");
                }
                else if(inputCar.StartCar() == false)
                {
                    Console.WriteLine("Bilen kunne ikke starte!");
                }
                Console.ReadLine();

                // Input more, or exit?
                UserChoice();
            }
        }

        private static void UserChoice()
        {
            // Clear console from previous I/O
            ClearConsole();

            // Output Message
            Console.WriteLine(
                "Du har nu oprettet en bil.\n\n" +
                "Der er nu er to muligheder. Ønsker du at:\n" +
                "1)\tIndtaste en bil mere?\n" +
                "2)\tGå tilbage?");

            // Register keypress & option
            EnterCarChoice();
        }

        private static void EnterCarChoice()
        {
            // Register keypress
            char UserKeyPress = Console.ReadKey().KeyChar;

            // Enter a car
            if(UserKeyPress == '1')
            {
                // Go to EnterCar
                EnterCar();
            }
            // Stop loop
            else if(UserKeyPress == '2')
            {
                // Go to CarInformation
                Main();
            }
            // Prevent shutdown if other keys are presset
            else
            {
                // Return to Main menu
                EnterCarChoice();
            }
        }

        /*
         *  Misc Methods
         */

        private static void ExitProgram()
        {
            // Clear Previous Input
            ClearConsole();

            // Goodbye message
            Console.WriteLine("Programmet lukker, farvel...");

            // Pause for 2.5 seconds
            Thread.Sleep(2500);

            // Shut down programm
            System.Environment.Exit(-1);
        }

        private static void ErrorMessage(string inputMessage)
        {
            // Clear console & change background color
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkRed;

            // Output error message & pause console
            Console.WriteLine($"FEJL! {inputMessage}");
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
