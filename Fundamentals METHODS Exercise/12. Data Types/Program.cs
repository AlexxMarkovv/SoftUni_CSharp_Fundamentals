using System;

namespace _12._Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            if (input1 == "int")
            {
                ReturnInteger(input1, input2);
            }
            else if (input1 == "real")
            {
                ReturnDouble(input1, input2);
            }
            else
            {
               ReturnString(input1, input2);
            }
        }



        static void ReturnInteger(string input1, string input2)
        {
            if (input1 == "int")
            {
                int number = int.Parse(input2);
                int result = number * 2;
                Console.WriteLine(result);
            }
        }

        static void ReturnDouble(string input1, string input2)
        {
            if (input1 == "real")
            {
                double number = double.Parse(input2);
                double result = number * 1.5;
                Console.WriteLine($"{result:f2}");
            }
        }

        static void ReturnString(string input1, string input2)
        {
            if (input1 == "string")
            {
                Console.WriteLine($"${input2}$"); 
            }
        }
    }
}