using System;

namespace S1._21
{
    class Program
    {
        static void Main()
        {
            // Opgave 1:
            // Create new object, with dimensions
            Box box = new Box(40, 60, 20);

            // Calculate surface
            box.CalculateSurface();
            // Calculate volume
            box.CalculateVolume();
            // Print box dimensions
            box.PrintInfo();

            // Empty line for spacing
            Console.WriteLine();
            ;
            // Opgave 2:
            // Create first new object
            Car firstCar = new Car("Dacia", "Logan", "Beige", 17000, false);

            // Create second new object
            Car secondCar = new Car("Toyota", "Yaris", "Rød", 89000, true);

            // Create third new object
            Car thirdCar = new Car("Honda", "Civic", "Hvid", 199000, false);


            // Put first car on sale
            firstCar.PutOnSale();


            // Print first car
            firstCar.PrintInfo();
            // Print second car
            secondCar.PrintInfo();
            // Print third car
            Console.WriteLine(thirdCar.ToString());
        }
    }
}