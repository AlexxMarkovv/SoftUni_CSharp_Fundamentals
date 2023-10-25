using System;

namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte numberOfChars = byte.Parse(Console.ReadLine());
            int symbolSum = 0;

            for (int i = 0; i < numberOfChars; i++)
            {
                char symbol = char.Parse(Console.ReadLine());
                symbolSum += symbol;
            }
            Console.WriteLine($"The sum equals: {symbolSum}");
        }
    }
}