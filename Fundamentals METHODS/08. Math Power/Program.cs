using System;

namespace _08._Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseNum = double.Parse(Console.ReadLine());
            double powerNum = double.Parse(Console.ReadLine());

            double result = GetPower(baseNum, powerNum);
            Console.WriteLine(result);
        }

        static double GetPower(double baseNum, double powerNum)
        {
            return Math.Pow(baseNum, powerNum);
        }
    }
}