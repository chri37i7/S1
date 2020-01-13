using System;

namespace S1._14._03
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                // Declare array for later use
                double[] userArray;

                // Ask for product amount & set array size
                while(true)
                {
                    // Output message & ask for input
                    Console.WriteLine("Indtast antallet af varer mellem 1 og 25.");
                    Console.Write("Indtast antal: ");

                    // Store input in string & try to convert to int
                    string consoleInput = Console.ReadLine();
                    int.TryParse(consoleInput, out int outputNum);

                    // Display error message if number is under 1, or higher than 25
                    if(outputNum < 1 || outputNum > 25)
                    {
                        // Clear console & change background color
                        Console.Clear();
                        Console.BackgroundColor = ConsoleColor.DarkRed;

                        // Output error message & pause console
                        Console.WriteLine("FEJL! Tallet opfylder ikke kravene.");
                        Console.ReadLine();

                        // Reset console color & clear console
                        Console.ResetColor();
                        Console.Clear();

                        // Restart
                        continue;
                    }
                    // Set array size to input if higher than 1, & lower than 25
                    else if(outputNum >= 1 && outputNum <= 25)
                    {
                        // Set array size
                        userArray = new double[outputNum];

                        // Break loop
                        break;
                    }
                }
                // Take product prices & store in array
                for(int i = 0; i < userArray.Length; i++)
                {
                    while(true)
                    {
                        // Clear console, write message & ask for input.
                        Console.Clear();
                        Console.WriteLine("Indtast priserne på varerne(Skal være mellem 0 og 20000).");
                        Console.Write("Indtast pris på vare " + i + ": ");

                        // Store input in string & try to convert to double
                        string userInput = Console.ReadLine();
                        double.TryParse(userInput, out double outputPrice);

                        // Save input in array or display error message
                        if(outputPrice <= 0 || outputPrice > 20000)
                        {
                            // Clear console & change background color
                            Console.Clear();
                            Console.BackgroundColor = ConsoleColor.DarkRed;

                            // Output error message & pause console
                            Console.WriteLine("FEJL! Tallet opfylder ikke kravene.");
                            Console.ReadLine();

                            // Reset console color & clear console
                            Console.ResetColor();
                            Console.Clear();

                            // Restart
                            continue;
                        }
                        else if(outputPrice > 0 && outputPrice <= 20000)
                        {
                            // Save price in array
                            userArray[i] = outputPrice;

                            // Clear console & break loop
                            Console.Clear();
                            break;
                        }
                    }
                }

                // Int for storing subtotal price
                double subTotal = 0;

                // Calculate total price without tax
                for(int i = 0; i < userArray.Length; i++)
                {
                    // Take all numbers in array & combine to single number
                    subTotal += userArray[i];
                }
                // Calculate average Price
                double avgPrice = (subTotal / userArray.Length);
                // Calculate tax combine tax from all products
                double comTax = (subTotal * 0.25);
                // Calculate total price including tax
                double totalPrice = (subTotal * 1.25);

                // Output results & pause console.
                Console.WriteLine($"Subtotal: {subTotal:f}\nGennemsnitspris: {avgPrice:f}\nSamlet moms: {comTax:f}\nSamlet pris: {totalPrice:f}");

                // Ask if user would like to try again
                Console.Write("\nVil du prøve igen? (J/N): ");
                string tryAgain = Console.ReadLine().ToLower();

                // Try again false, stop
                if(tryAgain == "n")
                {
                    break;
                }
                // Try again true, start over
                else if(tryAgain == "j")
                {
                    Console.ResetColor();
                    Console.Clear();
                    continue;
                }
                // If no input start over
                else
                {
                    Console.ResetColor();
                    Console.Clear();
                    continue;
                }
            }
        }
    }
}