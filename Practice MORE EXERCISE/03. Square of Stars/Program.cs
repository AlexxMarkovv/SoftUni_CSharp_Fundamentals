using System;

namespace _03._Square_of_Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                for (int j = 0; j < number; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}