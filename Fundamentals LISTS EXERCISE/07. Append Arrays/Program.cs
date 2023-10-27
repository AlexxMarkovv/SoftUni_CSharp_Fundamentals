using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> numbersArr = Console.ReadLine()
                .Split("|")
                .Reverse()
                .ToList();
            List<int> numbers = new List<int>();

            for (int i = 0; i < numbersArr.Count; i++)
            {
                numbers.AddRange(numbersArr[i].Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToList());
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}