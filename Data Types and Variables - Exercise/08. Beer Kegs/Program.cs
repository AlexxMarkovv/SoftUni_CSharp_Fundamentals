using System;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short kegsNum = short.Parse(Console.ReadLine());
            string biggerKegName = "";
            double biggerKegVolume = 0;

            for (int i = 0; i < kegsNum; i++)
            {
                string kegModel = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double kegVolume = Math.PI * Math.Pow(radius, 2) * height;

                if (kegVolume >biggerKegVolume)
                {
                    biggerKegVolume = kegVolume;
                    biggerKegName = kegModel;
                }
            }
            Console.WriteLine(biggerKegName);
        }
    }
}