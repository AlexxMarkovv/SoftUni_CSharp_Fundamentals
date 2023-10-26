using System;
using System.Linq;

namespace _13._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < numArray.Length; i++)
            {
                int currNum = numArray[i];
                bool isTopInteger = true;
                for (int j = i + 1; j < numArray.Length; j++)
                {
                    int nextNum = numArray[j];
                    if (nextNum >= currNum)
                    {
                        isTopInteger = false;
                        break;
                    }
                }

                if (isTopInteger)
                {
                    Console.Write(currNum + " ");
                }
            }
        }
    }
}