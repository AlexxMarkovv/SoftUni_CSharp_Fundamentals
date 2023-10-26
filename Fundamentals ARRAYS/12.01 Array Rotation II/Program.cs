using System;
using System.Linq;
using System.Text;

namespace _12._01_Array_Rotation_II
{
    internal class Program
    {
        static void ArrayRotate(ref int[] arr,int step)
        {
            int temp = arr[0];
            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                index -= step;

                while (index < 0)
                {
                    index += arr.Length;
                }

                int swap = temp;
                temp = arr[index];
                arr[index] = swap;
            }
        }

        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Console.ReadLine());

            int step = int.Parse(Console.ReadLine());

            int[] arr = sb.ToString().Split(" ").Select(int.Parse).ToArray();

            step = step % arr.Length;

            if (step < 0)
            {
                step += arr.Length;
            }

            if (step != 0)
            {
                if ((step % 2) == 0)
                {
                    ArrayRotate(ref arr, step - 1);
                    ArrayRotate(ref arr, 1);
                }
                else
                {
                    ArrayRotate(ref arr, step);
                }
            }

            Console.WriteLine(String.Join(" ", arr));
        }
    }
}