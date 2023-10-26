using System;

namespace _01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] daysOfWeek = new string[7];
            daysOfWeek[0] = "Monday";
            daysOfWeek[1] = "Tuesday";
            daysOfWeek[2] = "Wednesday";
            daysOfWeek[3] = "Thursday";
            daysOfWeek[4] = "Friday";
            daysOfWeek[5] = "Saturday";
            daysOfWeek[6] = "Sunday";

            int dayNumber = int.Parse(Console.ReadLine());

            if (dayNumber < 1 || dayNumber > 7)
            {
                Console.WriteLine("Invalid day!");
                return;
            }
            Console.WriteLine(daysOfWeek[dayNumber - 1]);
        }
    }
}