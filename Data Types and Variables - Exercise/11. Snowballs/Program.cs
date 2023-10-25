using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short snowBallsNum = short.Parse(Console.ReadLine());
            BigInteger snowBallValue = 0;
            BigInteger bestSnowBallValue = 0;
            short bestA = 0;
            short bestB = 0;
            short bestC = 0;

            for (int i = 1; i <= snowBallsNum; i++)
            {
                short snowBallSnow = short.Parse(Console.ReadLine());
                short snowBallTime = short.Parse(Console.ReadLine());
                short snowBallQuality = short.Parse(Console.ReadLine());

                snowBallValue = BigInteger.Pow((snowBallSnow / snowBallTime), snowBallQuality);

                if (snowBallValue > bestSnowBallValue)
                {
                    bestSnowBallValue = snowBallValue;
                    bestA = snowBallSnow;
                    bestB = snowBallTime;
                    bestC = snowBallQuality;
                }
                snowBallValue = 0;

                if (i == snowBallsNum)
                {
                    Console.WriteLine(($"{bestA} : {bestB} = {bestSnowBallValue} ({bestC})"));
                    break;
                }
            }
        }
    }
}