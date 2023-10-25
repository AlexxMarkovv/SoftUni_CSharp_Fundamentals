using System;

namespace _13._From_Left_to_The_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfInputs = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfInputs; i++)
            {
                long num1Value = 0L;
                long num2Value = 0L;

                string[] input = Console.ReadLine().Split(" ");

                //these two variables are not needed but make the code more readable
                string num1 = input[0];
                string num2 = input[1];

                long leftNumber = long.Parse(num1);
                long rightNumber = long.Parse(num2);

                for (int k = 0; k < num1.Length; k++)
                {
                    bool isDigit = long.TryParse(num1[k].ToString(), out long digit);
                    num1Value += digit;
                }

                for (int v = 0; v < num2.Length; v++)
                {
                    bool isDigit = long.TryParse(num2[v].ToString(), out long digit);
                    num2Value += digit;
                }

                if (leftNumber > rightNumber)
                {
                    Console.WriteLine(num1Value);
                }
                else
                {
                    Console.WriteLine(num2Value);
                }





                //int linesNum = int.Parse(Console.ReadLine());

                //for (int i = 0; i < linesNum; i++)
                //{
                //    string numbers = Console.ReadLine();
                //    string rightNum = "";
                //    string leftNum = "";
                //    for (int j = 0; j < numbers.Length; j++)
                //    {
                //        char ch = numbers[j];
                //        if (ch != ' ')
                //        {
                //            rightNum += ch;
                //        }
                //        else
                //        {
                //            leftNum = rightNum;
                //            rightNum = "";
                //            continue;
                //        }
                //    }

                //    long leftNumSum = 0;
                //    long rightNumSum = 0;
                //    long leftNumInt = long.Parse(leftNum);
                //    long rightNumInt = long.Parse(rightNum);
                //    leftNumInt = Math.Abs(leftNumInt);
                //    rightNumInt = Math.Abs(rightNumInt);

                //    while (leftNumInt > 0)
                //    {
                //        long currentNum = leftNumInt;
                //        currentNum %= 10;
                //        leftNumSum += currentNum;
                //        leftNumInt /= 10;
                //    }

                //    while (rightNumInt > 0)
                //    {
                //        long currentNum = rightNumInt;
                //        currentNum %= 10;
                //        rightNumSum += currentNum;
                //        rightNumInt /= 10;
                //    }

                //    if (leftNumSum > rightNumSum)
                //    {
                //        Console.WriteLine(leftNumSum);
                //    }
                //    else
                //    {
                //        Console.WriteLine(rightNumSum);
                //    }
                //}
            }
        }
    }
}