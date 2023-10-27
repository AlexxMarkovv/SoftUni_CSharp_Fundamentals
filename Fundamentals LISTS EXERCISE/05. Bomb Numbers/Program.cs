using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] optionNums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bombNumber = optionNums[0];
            int power = optionNums[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    BombNumber(numbers, power, i);
                }
            }
            Console.WriteLine(numbers.Sum());
        }

        static void BombNumber(List<int> numbers, int power, int index)
        {
            int start = Math.Max(0, index - power);
            int end = Math.Min(numbers.Count - 1, index + power);
            for (int i = start; i <= end; i++)
            {
                numbers[i] = 0;
            }
        }
    }
}