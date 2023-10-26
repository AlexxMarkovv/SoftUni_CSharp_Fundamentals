using System;
using System.Globalization;
using System.Linq;

namespace _17_02_Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dnaLength = int.Parse(Console.ReadLine());
            int[] currentLongestSequence = new int[dnaLength];
            int currentSequenceLength = 0;
            int currentStartingIndex = 0;
            int currentSum = 0;
            int dnaSample = 0;

            int counter = 0;
            while (true)
            {
                counter++;
                string input = Console.ReadLine();
                if (input == "Clone them!")
                {
                    break;
                }

                int[] numbersArr = input.Split("!", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToArray();

                int length = 0;
                foreach (var item in numbersArr)
                {
                    if (item == 1)
                    {
                        length++;
                    }
                    else if (length > 0 && item == 0)
                    {
                        break;
                    }
                }

                int startingIndex = Array.IndexOf(numbersArr, 1);
                int sum = numbersArr.Sum();

                if (length >= currentSequenceLength || length == currentSequenceLength && currentStartingIndex > startingIndex ||
                    length == currentStartingIndex && currentStartingIndex == startingIndex && sum > currentSum)
                {
                    currentLongestSequence = numbersArr;
                    currentSequenceLength = length;
                    currentStartingIndex = startingIndex;
                    currentSum = sum;
                    dnaSample = counter;
                }
            }

            Console.WriteLine($"Best DNA sample {dnaSample} with sum: {currentSum}.");
            Console.WriteLine(string.Join(" ", currentLongestSequence));
        }
    }
}