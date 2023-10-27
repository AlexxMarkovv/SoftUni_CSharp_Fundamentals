using System;
using System.Linq;
using System.Collections.Generic;

namespace _09._Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pokesForCatch = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> removedElements = new List<int>();

            while (pokesForCatch.Count > 0)
            {
                int index = int.Parse(Console.ReadLine());
                int lastRemovedElement = 0;

                if (index < 0)
                {
                    lastRemovedElement = pokesForCatch[0];
                    pokesForCatch.RemoveAt(0);
                    pokesForCatch.Insert(0, pokesForCatch[pokesForCatch.Count - 1]);
                }
                else if (index > pokesForCatch.Count - 1)
                {
                    lastRemovedElement = pokesForCatch[pokesForCatch.Count - 1];
                    pokesForCatch.RemoveAt(pokesForCatch.Count - 1);
                    pokesForCatch.Insert(pokesForCatch.Count, pokesForCatch[0]);
                }
                else
                {
                    lastRemovedElement = pokesForCatch[index];
                    pokesForCatch.RemoveAt(index);
                }

                removedElements.Add(lastRemovedElement);

                for (int i = 0; i < pokesForCatch.Count; i++)
                {
                    if (pokesForCatch[i] <= lastRemovedElement)
                    {
                        pokesForCatch[i] += lastRemovedElement;
                    }
                    else
                    {
                        pokesForCatch[i] -= lastRemovedElement;
                    }
                }
            }

            Console.WriteLine(removedElements.Sum());
        }
    }
}