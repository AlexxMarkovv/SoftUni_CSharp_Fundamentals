using System;

namespace _12._Data_Type_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                if (int.TryParse(input, out int intNum))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (double.TryParse(input, out double floatNum))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (char.TryParse(input, out char ch))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (bool.TryParse(input, out bool bL))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
                input = Console.ReadLine();
            }
        }
    }
}