using System;

namespace _02._Rectangle_of_N_x_N_Stars
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
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}