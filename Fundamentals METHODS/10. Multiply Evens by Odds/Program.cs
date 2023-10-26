using System;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            int result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);
        }

        static int GetMultipleOfEvenAndOdds(int number)
        {
            int evenSum = GetEvenSum(number); 
            int oddSum = GetOddSum(number);
            int result = evenSum * oddSum;
            return result;
        }

        static int GetEvenSum(int number)
        {
            int evenSum = 0;
            int lastDigit = 0;

            while (number > 0)
            {
                lastDigit = number % 10;
                number /= 10;
                if (lastDigit % 2 == 0)
                {
                    evenSum += lastDigit;
                }
            }
            return evenSum;
        }

        static int GetOddSum(int number)
        {
            int oddSum = 0;
            int lastDigit = 0;

            while (number > 0)
            {
                lastDigit = number % 10;
                number /= 10;
                if (lastDigit % 2 != 0)
                {
                    oddSum += lastDigit;
                }
            }
            return oddSum;
        }
    }
}