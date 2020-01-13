using System;

namespace S1._21._02
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMenuHeader("Animals");
            PrintMenuItem("Cow");

            PrintMenuHeader("Countries");
            PrintMenuItems("Tuvalu", "Nauru");

            PrintMenuHeader("Great Leaders");
            PrintMenuItems("Donald Trump", "Vladimir Putin", "Kim Jong-un");



            Console.ReadLine();
        }

        private static void PrintMenuHeader(
            string menuHeader)
        {
            Console.WriteLine("*** {0} ***",
                menuHeader);
        }

        private static void PrintMenuItem(
            string firstMenuItem)
        {
            Console.WriteLine("1) {0}",
                firstMenuItem);
        }

        /*
        private static void PrintMenuItems(
            string firstMenuItem, // First input 
            string secondMenuItem) // Second input
        {
            // Output first input
            Console.WriteLine("1) {0}",
                firstMenuItem);
            // Output second input
            Console.WriteLine("2) {0}",
                secondMenuItem);
        }*/

        private static void PrintMenuItems(
            string firstMenuItems,  // First Input
            string secondMenuItems, // Second Input
            string thirdMenuItems)  // Third Input
        {
            // Output First Input
            Console.WriteLine("1) {0}",
                firstMenuItems);
            // Output Second Input
            Console.WriteLine("2) {0}",
                secondMenuItems);
            //Output Third Input
            Console.WriteLine("3) {0}",
                thirdMenuItems);
        }

        private static void PrintMenuItems(string firstMenuItem, string secondMenuItem)
        {
            // Output first input
            Console.WriteLine("1) {0}", firstMenuItem);
            // Output second input
            Console.WriteLine("1) {0}", secondMenuItem);
        }
    }
}