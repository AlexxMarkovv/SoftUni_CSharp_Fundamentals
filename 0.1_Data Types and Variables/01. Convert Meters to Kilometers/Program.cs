﻿using System;

namespace _01._Convert_Meters_to_Kilometers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());
            double kilometres = (double)meters / 1000;

            Console.WriteLine($"{kilometres:f2}");
        }
    }
}