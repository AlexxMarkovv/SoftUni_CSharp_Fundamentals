using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Dictionary<char, int> chars = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                string word = text[i];
                for (int j = 0; j < word.Length; j++)
                {
                    char symbol = word[j];
                    if (!chars.ContainsKey(symbol))
                    {
                        chars.Add(symbol, 1);
                    }
                    else
                    {
                        chars[symbol]++;
                    }
                }
            }

            foreach(var item in chars)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}