using System;
using System.Linq;

namespace _02._Odd_Occurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            Dictionary<string, int> listWithWords = new Dictionary<string, int>();

            foreach(string word in words)
            {
                string wordLowerCase = word.ToLower();

                if (listWithWords.ContainsKey(wordLowerCase))
                {
                    listWithWords[wordLowerCase]++;
                }
                else
                {
                    listWithWords.Add(wordLowerCase, 1);
                }
            }    

            foreach (var word in listWithWords)
            {
                if (word.Value % 2 != 0)
                {
                    Console.Write(word.Key + " ");
                }
            }
        }
    }
}