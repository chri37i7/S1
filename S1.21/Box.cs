using System;
using System.Collections.Generic;
using System.Text;

namespace S1._21
{
    class Box
    {
        // Fields
        private int height;
        private int length;
        private int width;
        private int volume;
        private int surface;

        // Constructor
        public Box(int height, int length, int width)
        {
            Height = height;
            Length = length;
            Width = width;
        }

        // Properties
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }
        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        public int Volume
        {
            get
            {
                return volume;
            }
            private set
            {
                volume = value;
            }
        }
        public int Surface
        {
            get
            {
                return surface;
            }
            private set
            {
                surface = value;
            }
        }

        // Method
        public void PrintInfo()
        {
            Console.WriteLine(
                $"Kassen har følgende mål:\n" +
                $"Højde\t\t{Height} cm\n" +
                $"Længde:\t\t{Length} cm\n" +
                $"Bredde:\t\t{Width} cm\n\n" +
                $"Overfladearealet er:\t{surface} cm2\n" +
                $"Rumfanget er:\t\t{volume} cm3");
        }

        // Method
        public void CalculateVolume()
        {
            volume = Height * Length * Width;
        }

        // Method
        public void CalculateSurface()
        {
            surface = (Width * Height + Height * Length + Width * Length);
        }
    }
}