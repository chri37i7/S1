using System;
using System.Collections.Generic;
using System.Text;

namespace S1._21
{
    class Car
    {
        // Fields
        private string make;
        private string model;
        private string color;
        private double price;
        private bool isSold;
        private bool isOnSale;

        // Constructor
        public Car(string make, string model, string color, double price, bool isSold)
        {
            Make = make;
            Model = model;
            Color = color;
            Price = price;
            IsSold = isSold;
            IsOnSale = false;
        }

        // Override
        public override string ToString()
        {
            return $"{make} {model}";
        }

        // Properties
        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                make = value;
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public bool IsSold
        {
            get
            {
                return isSold;
            }
            set
            {
                isSold = value;
            }
        }
        public bool IsOnSale
        {
            get
            {
                return isOnSale; 
            }
            set
            {
                isOnSale = value;
            }
        }

        // Method
        public void PrintInfo()
        {
            // If sold is true print sold
            if(IsSold == true)
            {
                Console.WriteLine($"SOLGT! Bilen er en {make} {model} i farven {color}. Prisen er {price} DKK.");

                return;
            }
            // If sold is false print normal
            Console.WriteLine($"Bilen er en {make} {model} i farven {color}. Prisen er {price} DKK.");
        }

        // Method
        public void PutOnSale()
        {
            // If already on sale, ignore
            if(IsOnSale == true)
            {
                return;
            }
            // Set on sale status to true
            IsOnSale = true;       
            // Calculate 10% off price
            Price *= 0.9;
        }
    }
}
