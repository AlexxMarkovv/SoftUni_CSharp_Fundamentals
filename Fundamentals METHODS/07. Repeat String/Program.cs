using System;

namespace _07._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num = int.Parse(Console.ReadLine());
            string newText = Concatanate(input, num);
            Console.WriteLine(newText);
        }

        static string Concatanate(string input, int num)
        {
            string newText = "";
            for (int i = 0; i < num; i++)
            {
                newText += input;
            }
            return newText;
        }
    }
}