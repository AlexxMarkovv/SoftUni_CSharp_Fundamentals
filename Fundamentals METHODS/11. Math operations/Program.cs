using System;

namespace _11._Math_operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double y = double.Parse(Console.ReadLine());

            double result = GetMathOperation(x, @operator, y);
            Console.WriteLine(result);
        }

        static double GetMathOperation(double x, string @operator, double y)
        {
            double result = 0;

            switch (@operator)
            {
                case "/": result = x / y; break;
                case "*": result = x * y; break;
                case "+": result = x + y; break;
                case "-": result = x - y; break;
            }
            return result;
        }
    }
}