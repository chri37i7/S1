using System;

namespace S1._08._02._02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast dit navn: ");
            string userName = Console.ReadLine();
            int nameLenght = userName.Length;
            if(nameLenght>20)
            {
                Console.WriteLine("Wow! Dit navn er langt!");
                Console.WriteLine("\nVi ses " + userName + "!");
            }
            else
            {
                Console.WriteLine("Flot navn du har!");
                Console.WriteLine("\nVi ses " + userName + "!");
            }
            Console.ReadLine();
        }
    }
}
