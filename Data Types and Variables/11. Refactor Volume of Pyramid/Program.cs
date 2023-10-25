using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = 0;
            double width = 0;
            double height = 0;
            

            Console.Write("Length: ");
            length = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            width = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            height = double.Parse(Console.ReadLine());

            double volume = 0;
            volume = (length * width * height) / 3;
            Console.Write($"Pyramid Volume: {volume:f2}");
        }
    }
}