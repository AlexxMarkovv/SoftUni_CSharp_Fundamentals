using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listNums = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> finalList = new List<int>();

            for (int i = 0; i < listNums.Count; i++)
            {
                if (listNums[i] >= 0)
                {
                    finalList.Add(listNums[i]);
                }
            }

            finalList.Reverse();

            if (finalList.Count == 0) 
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(string.Join(' ', finalList));
            }
        }
    }
}