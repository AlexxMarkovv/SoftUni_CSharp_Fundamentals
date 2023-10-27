using System;
using System.Linq;
using System.Threading.Tasks.Dataflow;

namespace _11._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] startArray = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            string input;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] inputAsArray = input.Split(" ");
                string commandType = inputAsArray[0];

                if (commandType == "exchange")
                {
                    int indexExch = int.Parse(inputAsArray[1]);
                    if (indexExch < 0 || indexExch >= startArray.Length)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    startArray = ExchangeArray(startArray, indexExch);
                }
                else if (commandType == "max")
                {
                    string subcommandType = inputAsArray[1];

                    int resultIndex = ReturnMaxIndexOfEvenOrOddElement(startArray, subcommandType);
                    if (resultIndex == -1)
                    {
                        Console.WriteLine("No matches");
                        continue;
                    }
                    Console.WriteLine(resultIndex);

                }
                else if (commandType == "min")
                {
                    string subcommandType = inputAsArray[1];

                    int resultIndex = ReturnMinIndexOfEvenOrOddElement(startArray, subcommandType);
                    if (resultIndex == -1)
                    {
                        Console.WriteLine("No matches");
                        continue;
                    }
                    Console.WriteLine(resultIndex);
                }
                else if (commandType == "first" || commandType == "last")
                {
                    int positionOfElements = int.Parse(inputAsArray[1]);
                    string typeOfInts = inputAsArray[2];

                    if (positionOfElements > startArray.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    int[] elements;
                    if (commandType == "first")
                    {
                        elements = FirstEvenOrOddElements(startArray, positionOfElements, typeOfInts);
                    }
                    else
                    {
                        elements = LastEvenOrOddElements(startArray, positionOfElements, typeOfInts);
                    }

                    PrintArray(elements);
                }
            }
            PrintArray(startArray);
        }


        static int[] ExchangeArray(int[] startArray, int index)
        {
            int[] exchangedArray = new int[startArray.Length];
            int currIndex = 0;
            for (int i = index + 1; i < startArray.Length; i++)
            {
                exchangedArray[currIndex++] += startArray[i];
            }

            for (int i = 0; i <= index; i++)
            {
                exchangedArray[currIndex++] += startArray[i];
            }
            return exchangedArray;
        }


        static int ReturnMaxIndexOfEvenOrOddElement(int[] startArray, string evenOrOdd)
        {
            int currMaxNum = int.MinValue;
            int maxIndex = -1;

            for (int i = 0; i < startArray.Length; i++)
            {
                int currNum = startArray[i];
                if (currNum % 2 == 0 && evenOrOdd == "even")
                {
                    if (currNum >= currMaxNum)
                    {
                        currMaxNum = currNum;
                        maxIndex = i;
                    }
                }
                else if (currNum % 2 != 0 && evenOrOdd == "odd")
                {
                    if (currNum >= currMaxNum)
                    {
                        currMaxNum = currNum;
                        maxIndex = i;
                    }
                }
            }
            return maxIndex;
        }


        static int ReturnMinIndexOfEvenOrOddElement(int[] startArray, string evenOrOdd)
        {
            int currMinNum = int.MaxValue;
            int minIndex = -1;

            for (int i = 0; i < startArray.Length; i++)
            {
                int currNum = startArray[i];
                if (currNum % 2 == 0 && evenOrOdd == "even")
                {
                    if (currNum <= currMinNum)
                    {
                        currMinNum = currNum;
                        minIndex = i;
                    }
                }
                else if (currNum % 2 != 0 && evenOrOdd == "odd")
                {
                    if (currNum <= currMinNum)
                    {
                        currMinNum = currNum;
                        minIndex = i;
                    }
                }
            }
            return minIndex;
        }


        static int[] FirstEvenOrOddElements(int[] startArray, int numOfInts, string firstEvenOrOdd)
        {
            int[] integersArr = new int[numOfInts];
            int counter = 0;

            for (int i = 0; i < startArray.Length; i++)
            {
                if (counter >= numOfInts)
                {
                    break;
                }

                if (startArray[i] % 2 == 0 && firstEvenOrOdd == "even")
                {
                    integersArr[counter++] = startArray[i];
                }
                else if (startArray[i] % 2 != 0 && firstEvenOrOdd == "odd")
                {
                    integersArr[counter++] = startArray[i];
                }
            }

            if (counter < numOfInts)
            {
                integersArr = ResizeIntegersArr(startArray, counter);
            }
            return integersArr;
        }


        static int[] LastEvenOrOddElements(int[] startArray, int numOfInts, string firstEvenOrOdd)
        {
            int[] integersArr = new int[numOfInts];
            int counter = 0;

            for (int i = startArray.Length - 1; i >= 0; i--)
            {
                if (counter >= numOfInts)
                {
                    break;
                }

                if (startArray[i] % 2 == 0 && firstEvenOrOdd == "even")
                {
                    integersArr[counter++] = startArray[i];
                }
                else if (startArray[i] % 2 != 0 && firstEvenOrOdd == "odd")
                {
                    integersArr[counter++] = startArray[i];
                }
            }

            if (counter < numOfInts)
            {
                integersArr = ResizeIntegersArr(startArray, counter);
            }
            integersArr = ReversedArray(integersArr);
            return integersArr;
        }

        static int[] ResizeIntegersArr(int[] startArray, int numOfInts)
        {
            int[] modifiedArr = new int[numOfInts];
            for (int i = 0; i < numOfInts; i++)
            {
                modifiedArr[i] = startArray[i];
            }
            return modifiedArr;
        }

        static int[] ReversedArray(int[] startArray)
        {
            int[] reversedArr = new int[startArray.Length];
            for (int i = startArray.Length - 1; i >= 0; i--)
            {
                reversedArr[reversedArr.Length - 1 - i] = startArray[i];
            }
            return reversedArr;
        }

        static void PrintArray(int[] startArray)
        {
            Console.WriteLine($"[{String.Join(", ", startArray)}]");
        }
    }
}
