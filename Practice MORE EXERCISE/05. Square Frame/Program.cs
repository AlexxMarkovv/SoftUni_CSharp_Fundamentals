using System;
namespace _05._Square_Frame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short number = short.Parse(Console.ReadLine());


            Console.Write("+ ");
            for (int k = 0; k < number - 2; k++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");

            for (int i = 0; i < number - 2; i++)
            {
                Console.Write("| ");
                for (int j = 1; j <= number - 2; j++)
                {
                    Console.Write("- ");
                }
                Console.Write("|");
                Console.WriteLine();
            }

            Console.Write("+ ");
            for (int k = 0; k < number - 2; k++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");
        }
    }
}