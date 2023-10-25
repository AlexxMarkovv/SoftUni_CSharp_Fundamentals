﻿using System;

namespace _12._Refactor_Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                int digitSum = 0;
                int currentNum = i;
                while (currentNum > 0)
                {
                    digitSum += currentNum % 10;
                    currentNum /= 10;
                }

                if (digitSum == 5 || digitSum == 7 || digitSum == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}