using System;
using System.Diagnostics;

namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0;

            switch (product)
            {
                case "coffee": price = 1.50; break;
                case "water": price = 1.00; break;
                case "coke": price = 1.40; break;
                case "snacks": price = 2.00; break;
            }

            PrintTotalPrice(price, quantity);
        }

        static double PrintTotalPrice(double price, int quantity)
        {
            double totalPrice = price *= quantity;
            Console.WriteLine($"{totalPrice:f2}");
            return totalPrice;
        }
    }
}