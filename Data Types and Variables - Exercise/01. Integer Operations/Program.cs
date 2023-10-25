using System;
using System.Numerics;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger num1 = BigInteger.Parse(Console.ReadLine());
            BigInteger num2 = BigInteger.Parse(Console.ReadLine());
            BigInteger num3 = BigInteger.Parse(Console.ReadLine());
            BigInteger num4 = BigInteger.Parse(Console.ReadLine());

            BigInteger result = num1+ num2;
            result /= num3;
            result *= num4;
            Console.WriteLine(result);
        }
    }
}