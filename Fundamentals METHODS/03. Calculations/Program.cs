using System;

namespace _03._Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            switch (command)
            {
                case "add": Addition(firstNum, secondNum); break;
                case "multiply": Multiply(firstNum, secondNum); break;
                case "subtract": Subtraction(firstNum, secondNum); break;
                case "divide": Divide(firstNum, secondNum); break;
            }
        }

        private static void Divide(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum / secondNum); 
        }

        private static void Multiply(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum * secondNum);
        }

        private static void Subtraction(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum - secondNum);
        }

        private static void Addition(int firstNum, int secondNum)
        {
            Console.WriteLine(firstNum + secondNum);
        }
    }
}