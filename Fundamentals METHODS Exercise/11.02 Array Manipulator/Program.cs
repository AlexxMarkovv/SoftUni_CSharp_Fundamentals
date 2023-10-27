namespace _11._02_Array_Manipulator
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Security.Authentication;

    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                if (input.StartsWith("exchange"))
                {
                    int index = int.Parse(input.Split().Last());
                    if (index < 0 || index >= array.Length)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    array = Exchange(array, index);
                }
                else if (input.StartsWith("max"))
                {
                    string condition = input.Split().Last();
                    MaxIndexForCondition(array, condition == "even");
                }
                else if (input.StartsWith("min"))
                {
                    string condition = input.Split().Last();
                    MinIndexForCondition(array, condition == "even");
                }
                else if (input.StartsWith("first"))
                {
                    string[] conditions = input.Split();
                    int count = int.Parse(conditions[1]);
                    FirstElementsForCondition(array, count, conditions.Last() == "even");
                }
                else if (input.StartsWith("last"))
                {
                    string[] conditions = input.Split();
                    int count = int.Parse(conditions[1]);
                    LastElementsForCondition(array, count, conditions.Last() == "even");
                }
            }

            Console.WriteLine($"[{string.Join(", ", array)}]");
        }

        static int[] Exchange(int[] array, int index)
        {
            return array.Skip(index + 1).Take(array.Length)
                .Concat(array.Take(index + 1)).ToArray();
        }

        static void MaxIndexForCondition(int[] array, bool isEven)
        {
            if (!array.Any(number => isEven == (number % 2 == 0)))
            {
                Console.WriteLine("No matches");
            }
            else
            {
                int max = array.Where(number => isEven == (number % 2 == 0)).Max();
                Console.WriteLine(Array.LastIndexOf(array, max));
            }
        }

        static void MinIndexForCondition(int[] array, bool isEven)
        {
            if (!array.Any(number => isEven == (number % 2 == 0)))
            {
                Console.WriteLine("No matches");
            }
            else
            {
                int min = array.Where(number => isEven == (number % 2 == 0)).Min();
                Console.WriteLine(Array.LastIndexOf(array, min));
            }
        }

        static void FirstElementsForCondition(int[] array, int count, bool isEven)
        {
            if (count >= array.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int[] result = array.Where(number => isEven == (number % 2 == 0))
                    .Take(count).ToArray();
                Console.WriteLine($"[{string.Join(", ", result)}]");
            }
        }

        static void LastElementsForCondition(int[] array, int count, bool isEven)
        {
            if (count > array.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else
            {
                int[] result = array.Where(number => isEven == (number % 2 == 0))
                    .TakeLast(count).ToArray();
                Console.WriteLine($"[{string.Join(", ", result)}]");
            }
        }
    }
}