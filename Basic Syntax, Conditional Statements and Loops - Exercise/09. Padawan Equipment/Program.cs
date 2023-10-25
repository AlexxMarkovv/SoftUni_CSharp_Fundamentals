using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amountOfMoney = decimal.Parse(Console.ReadLine());
            int studentsNum = int.Parse(Console.ReadLine());
            decimal lightsaberPrice = decimal.Parse(Console.ReadLine());
            decimal robePrice = decimal.Parse(Console.ReadLine());
            decimal beltPrice = decimal.Parse(Console.ReadLine());
            int belts = 0;

            decimal lightsabersWithBonus = Math.Ceiling(studentsNum * 1.1m);
            for (int i = 1; i <= studentsNum; i++)
            {
                if (i % 6 == 0)
                {
                    continue;
                }
                belts++;
            }

            decimal totalPrice = lightsabersWithBonus * lightsaberPrice;
            totalPrice += robePrice * studentsNum;
            totalPrice += beltPrice * belts;

            if (amountOfMoney >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalPrice - amountOfMoney:f2}lv more.");
            }
        }
    }
}
