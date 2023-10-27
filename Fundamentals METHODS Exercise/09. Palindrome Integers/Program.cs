using System;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                bool result = IsPalindromeOrNot(input);
                Console.WriteLine(result);
                input = Console.ReadLine();
            }
        }

        static bool IsPalindromeOrNot(string input)
        {
            if (input[0] == input[input.Length - 1])
            {
                return true;
            }
            return false;
        }
    }
}