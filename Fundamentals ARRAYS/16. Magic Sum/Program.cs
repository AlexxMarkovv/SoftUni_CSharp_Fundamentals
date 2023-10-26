using System;
using System.Linq;

namespace _16._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int searchedSum = int.Parse(Console.ReadLine());
            int num1 = 0;
            int num2 = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                num1 = numbers[i];
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    num2 = numbers[j];
                    if (num1 + num2 == searchedSum)
                    {
                        Console.WriteLine(num1 + " " + num2);
                    }
                }
            }
        }
    }
}