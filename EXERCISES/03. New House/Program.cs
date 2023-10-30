using System;

namespace _03._New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowerNum = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double flowersPrice = 0;

            switch (flowerType)
            {
                case "Roses": flowersPrice = 5; break;
                case "Dahlias": flowersPrice = 3.8; break;
                case "Tulips": flowersPrice = 2.8; break;
                case "Narcissus": flowersPrice = 3; break;
                case "Gladiolus": flowersPrice = 2.5; break;
            }

            double totalSum = flowersPrice * flowerNum;

            if (flowerType == "Roses" && flowerNum > 80)
            {
                totalSum *= 0.90; //90%
            }
            else if (flowerType == "Dahlias" && flowerNum > 90)
            {
                totalSum *= 0.85; //85%
            }
            else if (flowerType == "Tulips" && flowerNum > 80)
            {
                totalSum *= 0.85;
            }
            else if (flowerType == "Narcissus" && flowerNum < 120)
            {
                totalSum *= 1.15;
            }
            else if (flowerType == "Gladiolus" && flowerNum < 80)
            {
                totalSum *= 1.2;
            }

            if (budget >= totalSum)
            {
                Console.WriteLine($"Hey, you have a great garden with {flowerNum} {flowerType} and {budget - totalSum:f2} leva left.");
            }
            else if (budget < totalSum)
            {
                Console.WriteLine($"Not enough money, you need {totalSum - budget:f2} leva more.");
            }
        }   

    }
}
