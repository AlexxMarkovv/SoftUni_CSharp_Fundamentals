using System;
using System.Linq;

namespace _15._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int seqNumCounter = 0;
            int numFromLongestSequence = 0;
            int theLongestSequence = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    seqNumCounter++;
                }
                else
                {
                    seqNumCounter = 0;
                }

                if (seqNumCounter > theLongestSequence)
                {
                    theLongestSequence = seqNumCounter;
                    numFromLongestSequence = numbers[i];
                }
            }

            for (int i = 0; i <= theLongestSequence; i++)
            {
                Console.Write(numFromLongestSequence + " ");
            }
        }
    }
}