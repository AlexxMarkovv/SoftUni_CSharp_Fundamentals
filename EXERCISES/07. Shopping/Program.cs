using System;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCardNum = int.Parse(Console.ReadLine());
            int cpuNum = int.Parse(Console.ReadLine());
            int ramNum = int.Parse(Console.ReadLine());

            double videoCardPrice = videoCardNum * 250.0;
            double cpuPrice = (videoCardPrice * 0.35) * cpuNum ;
            double ramPrice = (videoCardPrice * 0.1) * ramNum;
            double totalSum = videoCardPrice + cpuPrice + ramPrice;

            if (videoCardNum > cpuNum)
            {
                totalSum = totalSum * 0.85;
            }

            if (budget >= totalSum)
            {
                Console.WriteLine($"You have {budget - totalSum:f2} leva left!");
            }

            else
            {
                Console.WriteLine($"Not enough money! You need {totalSum - budget:f2} leva more!");
            }
        }
    }
}
