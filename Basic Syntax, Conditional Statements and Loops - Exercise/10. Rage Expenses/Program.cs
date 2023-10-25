using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headSetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            double headsetCost = (lostGames / 2) * headSetPrice;
            double mouseCost = (lostGames / 3) * mousePrice;
            double keyboardCost = (lostGames / 6) * keyboardPrice;
            double displayCost = (lostGames / 12) * displayPrice;

            Console.WriteLine($"Rage expenses: {headsetCost + mouseCost + keyboardCost + displayCost:f2} lv.");
        }
    }
}
