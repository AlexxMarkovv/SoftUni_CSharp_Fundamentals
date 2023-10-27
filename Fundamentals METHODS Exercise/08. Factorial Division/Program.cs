using System;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstInt = double.Parse(Console.ReadLine());
            double secondInt = double.Parse(Console.ReadLine());

            double result1 = CalculateFactorielOfNumber(firstInt);
            double result2 = CalculateFactorielOfNumber(secondInt);
            double result = result1 / result2;
            Console.WriteLine($"{result:f2}");
        }

        static double CalculateFactorielOfNumber(double num)
        {
            double result = 1;

            for (int i = 1; i <= num; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}