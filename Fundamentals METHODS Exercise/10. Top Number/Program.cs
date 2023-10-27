using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endNumber = int.Parse(Console.ReadLine());
            CheckIfIntegerIsTop(endNumber);
        }


        static void CheckIfIntegerIsTop(int endNumber)
        {
            for (int i = 1; i <= endNumber; i++)
            {
                int sumOfDigits = 0;
                int oddDigitCounter = 0;
                int currNum;
                int numberToCheck = i;

                while (numberToCheck > 0)
                {
                    currNum = numberToCheck % 10;
                    numberToCheck /= 10;
                    sumOfDigits += currNum;

                    if (currNum % 2 != 0)
                    {
                        oddDigitCounter++;
                    }
                }

                if (sumOfDigits % 8 == 0 && oddDigitCounter > 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}