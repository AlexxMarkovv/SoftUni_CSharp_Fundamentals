using System;

namespace _08._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int rows = 1;
            
            while (rows <= number)
            {
                for (int i = 1; i <= rows; i++)
                {
                    Console.Write(rows + " ");
                }

                Console.WriteLine();
                rows++;
            }
        }
    }
}
