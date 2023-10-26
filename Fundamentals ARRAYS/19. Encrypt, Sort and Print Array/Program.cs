using System;
using System.Linq;
using System.Text;

namespace _01.Encrypt_SortAndPrintArray
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int stringNum = int.Parse(Console.ReadLine());
            int[] arrayOfSums = new int[stringNum];

            for (int i = 0; i < stringNum; i++)
            {
                int sum = 0;
                string strings = Console.ReadLine();


                byte[] asciiBytes = Encoding.ASCII.GetBytes(strings);
                for (int j = 0; j < asciiBytes.Length; j++)
                {
                    if (asciiBytes[j] == 65 || asciiBytes[j] == 69 || asciiBytes[j] == 73 || asciiBytes[j] == 79 || asciiBytes[j] == 85 ||
                        asciiBytes[j] == 97 || asciiBytes[j] == 101 || asciiBytes[j] == 105 || asciiBytes[j] == 111 || asciiBytes[j] == 117)
                    {
                        sum += asciiBytes[j] * strings.Length;
                    }
                    else
                    {
                        sum += asciiBytes[j] / strings.Length;
                    }
                }
                arrayOfSums[i] = sum;
            }
            Array.Sort(arrayOfSums);
            for (int i = 0; i < arrayOfSums.Length; i++)
            {
                Console.WriteLine(arrayOfSums[i]);
            }
        }
    }
}
