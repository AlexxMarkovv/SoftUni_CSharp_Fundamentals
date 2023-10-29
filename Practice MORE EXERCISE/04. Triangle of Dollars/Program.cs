using System;
namespace _04._Triangle_of_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short number = short.Parse(Console.ReadLine());

            for (int row = 1; row <= number; row++)
            {
                for (int i = 0; i < row; i++)
                {
                    Console.Write("$ ");
                }
                Console.WriteLine();
            }
        }
    }
}