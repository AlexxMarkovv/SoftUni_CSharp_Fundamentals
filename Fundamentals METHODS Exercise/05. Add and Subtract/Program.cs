using System;
using System.Linq;

namespace _05._Add_and_Subtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            int thirdInt = int.Parse(Console.ReadLine());

            int result = SubtractThirdIntFromSum(firstInt, secondInt, thirdInt);
            Console.WriteLine(result);
        }

        static int AddTwoIntegers(int num1, int num2, int num3)
        {
            int sum = num1 + num2;
            return sum;
        }

        static int SubtractThirdIntFromSum(int num1, int num2, int num3)
        {
            int subtract = AddTwoIntegers(num1, num2, num3);
            return subtract - num3;
        }
    }
}