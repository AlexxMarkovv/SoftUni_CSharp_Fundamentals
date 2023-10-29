using System;

namespace _06._Rhombus_of_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short number = short.Parse(Console.ReadLine());

            for (int row = 1; row < number; row++)
            {
                for (int space = 1; space <= number - row; space++)
                {
                    Console.Write(" ");
                }
                for (int star = 0; star < row; star++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }

            for (int row = number; row >= 1; row--)
            {
                for (int space = number - row; space >= 1; space--)
                {
                    Console.Write(" ");
                }
                for (int star = row; star >= 1; star--)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}