using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;
using System.Diagnostics.CodeAnalysis;

namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> firstDeck = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondDeck = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (firstDeck.Count > 0 && secondDeck.Count > 0)
            {
                if (firstDeck[0] > secondDeck[0])
                {
                    firstDeck.Add(secondDeck[0]);
                    firstDeck.Add(firstDeck[0]);
                }
                else if (secondDeck[0] > firstDeck[0])
                {
                    secondDeck.Add(firstDeck[0]);
                    secondDeck.Add(secondDeck[0]);
                }
                firstDeck.Remove(firstDeck[0]);
                secondDeck.Remove(secondDeck[0]);   
            }

            if (firstDeck.Count == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondDeck.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {firstDeck.Sum()}");
            }
        }
    }
}