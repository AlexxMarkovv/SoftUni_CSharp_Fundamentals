using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Random random = new Random();
            
            for (int i = 0; i < text.Length; i++)
            {
                int randomIndex = random.Next(0, text.Length);

                string currWord = text[i];
                string nextWord = text[randomIndex];

                text[i] = nextWord;
                text[randomIndex] = currWord;
            }
            Console.WriteLine(string.Join(Environment.NewLine, text));
        }
    }
}