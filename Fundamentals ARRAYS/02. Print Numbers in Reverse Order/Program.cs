
using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numbers.Length / 2; i++)
            {
                var temp = numbers[i];
                numbers[i] = numbers[numbers.Length - 1 - i];
                numbers[numbers.Length - 1 - i] = temp;
            }
            Console.WriteLine(string.Join(" ", numbers));

            //for (int i = numbers.Length - 1; i >= 0; i--)
            //{
            //    int number = int.Parse(Console.ReadLine());
            //    numbers[i] = number;
                
            //}
            //Console.WriteLine(string.Join(" ", numbers));
        }
    }
}