using System;

namespace _06._World_Swimming_Record
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMetres = double.Parse(Console.ReadLine());
            double timeInSecondsPerOneMeter = double.Parse(Console.ReadLine());

            double timeForWholeDistance = distanceInMetres * timeInSecondsPerOneMeter;
            double delateTime = ((Math.Floor (distanceInMetres / 15) * 12.5));
            double totalTime = timeForWholeDistance + delateTime;

            if (recordInSeconds > totalTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }

            else
            {
                Console.WriteLine($"No, he failed! He was {(totalTime - recordInSeconds):f2} seconds slower.");
            }

        }
    }
}
