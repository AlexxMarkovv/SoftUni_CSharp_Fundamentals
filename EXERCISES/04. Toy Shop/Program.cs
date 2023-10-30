using System;

namespace _04._Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursionPrice = double.Parse(Console.ReadLine());
            int puzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            double totalSum = (puzles * 2.6) + (dolls * 3.0) + (bears * 4.1) + (minions * 8.2) + (trucks * 2.0);
            int totalToysSold = puzles + dolls + bears + minions + trucks;

            if (totalToysSold >= 50)
            {
                totalSum = totalSum * 0.75;
            }

            totalSum = totalSum * 0.9;

            if (totalSum >= excursionPrice)
            {
                Console.WriteLine($"Yes! {totalSum - excursionPrice:f2} lv left.");
            }

            else
            {
                Console.WriteLine($"Not enough money! {excursionPrice - totalSum:f2} lv needed.");
            }


        }
    }
}