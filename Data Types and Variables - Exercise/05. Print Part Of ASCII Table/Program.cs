using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short firstIndex = short.Parse(Console.ReadLine());
            short secondIndex = short.Parse(Console.ReadLine());

            for (int i = firstIndex; i <= secondIndex; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}