using System;
using System.Linq;

namespace _14._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }

                leftSum = 0;
                for (int sumLeft = i; sumLeft > 0; sumLeft--)
                {
                    int nextLeftElementPosition = sumLeft - 1;
                    if (sumLeft > 0)
                    {
                        leftSum += numArray[nextLeftElementPosition];
                    }
                }

                rightSum = 0;
                for (int j = i; j < numArray.Length; j++)
                {
                    int nextElementPosition = j + 1;
                    if (j < numArray.Length - 1)
                    {
                        rightSum += numArray[nextElementPosition];
                    }
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}