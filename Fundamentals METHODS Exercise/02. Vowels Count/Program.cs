using System;
using System.Linq;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int result = CheckNumberOfVowels(text);
            Console.WriteLine(result);
        }

        static int CheckNumberOfVowels(string text)
        {
            int vowelSum = 0;
            char[] vowels = new char[] { 'a', 'e', 'y', 'u', 'o', 'i' };

            foreach (char letter in text.ToLower())
            {
                if (vowels.Contains(letter))
                {
                    vowelSum++;
                }
            }
            return vowelSum;
        }
    }
}