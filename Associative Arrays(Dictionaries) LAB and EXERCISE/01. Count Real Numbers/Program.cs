using System;

namespace _01._Count_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] listOfInts = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            SortedDictionary<int,int> numbers = new SortedDictionary<int,int>();

            for (int i = 0; i < listOfInts.Length; i++)
            {
                if (!numbers.ContainsKey(listOfInts[i]))
                {
                    numbers.Add(listOfInts[i], 1);
                }
                else
                {
                    numbers[listOfInts[i]]++;
                }
            }
            
            foreach (var item in numbers)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}