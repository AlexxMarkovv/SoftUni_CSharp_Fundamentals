using System;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short numOfLines = short.Parse(Console.ReadLine());
            short tankCapacity = 255;
            short currentTankVolume = 0;

            for (short i = 0; i < numOfLines; i++)
            {
                short litres = short.Parse(Console.ReadLine());
                if (litres <= tankCapacity)
                {
                    tankCapacity -= litres;
                    currentTankVolume += litres;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }
            Console.WriteLine(currentTankVolume);
        }
    }
}