using System;

namespace _05._Godzilla_vs._Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int extras = int.Parse(Console.ReadLine());
            double clothes = double.Parse(Console.ReadLine());
            double deckor = budget * 0.1;
            double clothesPrice = extras * clothes;

            if (extras > 150)
            {
                clothesPrice = clothesPrice * 0.9;
            }

            if ((deckor + clothesPrice) > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {((deckor + clothesPrice) - budget):f2} leva more.");
            }

            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(budget - (deckor + clothesPrice)):f2} leva left.");
            }
        }
    }
}
