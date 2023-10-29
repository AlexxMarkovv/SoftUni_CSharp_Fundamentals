using System;

namespace _08._Sunglasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());

            int formula = 2 * numb;
            string asteriks = new string('*', formula);
            string space = new string(' ', numb);


            int straightLine = (numb - 1) / 2 - 1;

            Console.WriteLine("{0}{1}{0}", asteriks, space);

            for (int row = 0; row < numb - 2; row++)
            {
                char sumbol = ' ';
                if (row == straightLine)
                {
                    sumbol = '|';
                }
                string forwarSlash = new string('/', formula - 2);
                string middelSpace = new string(sumbol, numb);
                Console.WriteLine("*{0}*{1}*{0}*", forwarSlash, middelSpace);

            }

            Console.WriteLine("{0}{1}{0}", asteriks, space);
        }
    }
}