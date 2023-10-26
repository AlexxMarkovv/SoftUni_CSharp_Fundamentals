using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mainArr = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            while (mainArr.Length > 1)
            {
                int[] condensedArray = new int[mainArr.Length - 1];
                for (int i = 0; i < mainArr.Length - 1; i++)
                {
                    condensedArray[i] = mainArr[i] + mainArr[i + 1];
                }
                mainArr = condensedArray;
            }
            Console.WriteLine(mainArr[0]);
        }
    }
}