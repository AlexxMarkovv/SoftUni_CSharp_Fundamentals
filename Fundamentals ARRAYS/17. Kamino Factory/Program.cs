using System;
using System.Linq;

namespace _17._Kamino_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int length = int.Parse(Console.ReadLine());

            int[] DNA = new int[length];
            int dnaSum = 0;
            int dnaCount = -1;
            int dnaStarIndex = -1;
            int dnaSample = 0;
            int sample = 0;

            string command;
            while ((command = Console.ReadLine()) != "Clone them!")
            {
                sample++;
                int[] currDNA = command
                    .Split("!", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int currCount = 0;
                int currStartIndex = 0;
                int currEndIndex = 0;
                int currDnaSum = 0;
                bool isCurrDnaBetter = false;

                int count = 0;
                for (int i = 0; i < currDNA.Length - 1; i++)
                {
                    if (currDNA[i] != 1)
                    {
                        count = 0;
                        continue;
                    }
                    count++;

                    if (count > currCount)
                    {
                        currCount = count;
                        currEndIndex = i;
                    }
                }

                currStartIndex = currEndIndex - currCount + 1;
                currDnaSum = currDNA.Sum();

                if (currCount > dnaCount)
                {
                    isCurrDnaBetter = true;
                }
                else if (currCount == dnaCount)
                {
                    if (currStartIndex < dnaStarIndex)
                    {
                        isCurrDnaBetter = true;
                    }
                    else if (currStartIndex == dnaStarIndex)
                    {
                        if (currDnaSum > dnaSum)
                        {
                            isCurrDnaBetter = true;
                        }
                    }
                }

                if (isCurrDnaBetter)
                {
                    DNA = currDNA;
                    dnaCount = currCount;
                    dnaStarIndex = currStartIndex;
                    dnaSum = currDnaSum;
                    dnaSample = sample; 
                }
            }

            Console.WriteLine($"Best DNA sample {dnaSample} with sum: {dnaSum}.");
            Console.WriteLine(String.Join(" ", DNA));
        }
    }
}