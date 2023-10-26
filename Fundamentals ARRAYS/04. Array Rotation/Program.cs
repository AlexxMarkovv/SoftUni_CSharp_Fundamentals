using System;
using System.Linq;

namespace _12._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();
            int rotationsCount = int.Parse(Console.ReadLine());
            
            int timesToRotate = rotationsCount % numArray.Length;
            for (int r = 0; r < timesToRotate; r++)
            {
                int firstNum = numArray[0];
                for (int i = 1; i < numArray.Length; i++)
                {
                    numArray[i - 1] = numArray[i];
                }
                numArray[numArray.Length - 1] = firstNum;
            }
            Console.WriteLine(String.Join(" ", numArray));
        }
    }
}