using System;

namespace _09._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "int")
            {
                int number1 = int.Parse(Console.ReadLine());
                int number2 = int.Parse(Console.ReadLine());
                int result = GetMax(number1, number2);
                Console.WriteLine(result);
            }
            else if (input == "char")
            {
                char symbol1 = char.Parse(Console.ReadLine());
                char symbol2 = char.Parse(Console.ReadLine());
                char result = GetMax(symbol1, symbol2);
                Console.WriteLine(result);
            }
            else
            {
                string text1 = Console.ReadLine();
                string text2 = Console.ReadLine();
                string result = GetMax(text1, text2);
                Console.WriteLine(result);
            }
        }

        static int GetMax(int number1, int number2)
        {
            if (number1 > number2)
            {
                return number1;
            }
            return number2;
        }

        static char GetMax(char symbol1, char symbol2)
        {
            if (symbol1 > symbol2)
            {
                return symbol1;
            }
            return symbol2;

        }

        static string GetMax(string text1, string text2)
        {
            int result = text1.CompareTo(text2);
            if (result > 0)
            {
                return text1;
            }
            return text2;
        }
    }
}