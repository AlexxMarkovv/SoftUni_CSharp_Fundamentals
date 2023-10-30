using System;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerNum = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double rosesPrice = flowerNum * 5.0;
            double dahliasPrice = flowerNum * 3.80;
            double tulipsPrice = flowerNum * 2.8;
            double narcissusPrice = flowerNum * 3.0;
            double gladiolus = flowerNum * 2.5;

            if (flowerType == "Roses" && flowerNum > 80)
            {
                priceWithDiscount = rosesPrice * 0.9;

                if (budget >= priceWithDiscount)
                {
                    double priceWithDiscount = rosesPrice * 0.9;
                    Console.WriteLine($"Hey you have a great garden with {flowerNum} {flowerType} and {budget - priceWithDiscount:f2} leva left.");
                }
                else
                {

                    Console.WriteLine($"Not enough money, you need {budget - priceWithDiscount:f2} leva more.");
                }

            }


            if (flowerType == "Roses" && budget >= rosesPrice && flowerNum < 80)
            {
                Console.WriteLine($"Hey you have a great garden with {flowerNum} {flowerType} and {budget - rosesPrice:f2} leva left.");
            }
            else if (rosesPrice > budget)
            {
                Console.WriteLine($"Not enough money, you need {rosesPrice - budget:f2} leva more.");
            }

               

            
        }
    }
}