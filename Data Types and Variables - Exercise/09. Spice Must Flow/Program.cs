using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            sbyte operatingDays = 0;
            int extractedSpice = 0;

            while (startingYield >= 100)
            {
                extractedSpice += startingYield;
                extractedSpice -= 26;
                startingYield -= 10;
                operatingDays++;
            }

            if (operatingDays > 0)
            {
                extractedSpice -= 26;
            }

            Console.WriteLine(operatingDays);
            Console.WriteLine(extractedSpice);
        }
    }
}