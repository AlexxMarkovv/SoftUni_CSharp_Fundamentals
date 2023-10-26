using System;
using System.Linq;
using System.Reflection;

namespace _07._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse) 
                .ToArray();

            int[] secondArray = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int arraySum = 0;
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }
                
                if (firstArray[i] == secondArray[i])
                {
                    arraySum += firstArray[i];
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {arraySum}");
        }
    }
}