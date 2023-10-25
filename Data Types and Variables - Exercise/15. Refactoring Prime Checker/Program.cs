using System;

namespace _15._Refactoring_Prime_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());

            for (int i = 2; i <= endNumber; i++)
            {
                bool isPrime = true;
                for (int j = 2; j < i; j++)
                {
                    Console.WriteLine(i % j);
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                
                if (isPrime)
                {
                    Console.WriteLine($"{i} -> true");
                }
                else
                {
                    Console.WriteLine($"{i} -> false");
                }
            }
        }
    }
}