using System;

namespace _07._Christmas_Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte num = byte.Parse(Console.ReadLine());

            for (int row = 0; row <= num; row++)
            {
                Console.Write(new string(' ', num - row));
                Console.Write(new string('*', row));
                Console.Write(" | ");
                Console.Write(new string('*', row));
                Console.WriteLine(new string(' ', num - row));
            }
        }
    }
}