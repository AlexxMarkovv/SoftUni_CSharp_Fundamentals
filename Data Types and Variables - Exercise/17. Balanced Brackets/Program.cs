using System;

namespace _17._Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte linesNum = byte.Parse(Console.ReadLine());
            int openingBracket = 0;
            int closingBracket = 0;

            for (int i = 0; i < linesNum; i++)
            {
                string input = Console.ReadLine();
                if (input == ")" && openingBracket == 0)
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
                else if (input == "(")
                {
                    openingBracket++;
                    if(openingBracket == 2)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }
                else if (input == ")")
                {
                    closingBracket++;
                    if (closingBracket == 2)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }

                if (openingBracket == 1 && closingBracket == 1)
                {
                    openingBracket = 0; closingBracket = 0;
                }
            }

            if (openingBracket == closingBracket)
            {
                Console.WriteLine("BALANCED");
            }

            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}