﻿using System;

namespace _03._Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            decimal numSum = 0;
            for (int i = 0; i < numbers; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                numSum += num;
            }
            Console.WriteLine($"{numSum}");
        }
    }
}