using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondList = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> resultList = new List<int>();

            int n = Math.Min(firstList.Count, secondList.Count);

            for (int i = 0; i < n; i++)
            {
                resultList.Add(firstList[i]);
                resultList.Add(secondList[i]);
            }

            if (firstList.Count > secondList.Count)
            {
                for (int i = n; i < firstList.Count; i++)
                {
                    resultList.Add(firstList[i]);
                }
            }
            else if (secondList.Count > firstList.Count)
            {
                for (int i = n; i < secondList.Count; i++)
                {
                    resultList.Add(secondList[i]);
                }
            }
            Console.WriteLine(string.Join(' ', resultList));
        }
    }
}