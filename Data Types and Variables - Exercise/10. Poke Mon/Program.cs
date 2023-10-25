using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long pokePowerN = long.Parse(Console.ReadLine());
            int distanceM = int.Parse(Console.ReadLine());
            sbyte exhaustionFactorY = sbyte.Parse(Console.ReadLine());
            short pokesCounter = 0;
            double halfPercentageOfN = (pokePowerN * 1.0) / 2;

            while (pokePowerN >= distanceM)
            {
                pokePowerN -= distanceM;
                pokesCounter++;

                if (pokePowerN == halfPercentageOfN)
                {
                    if (pokePowerN > 0 && exhaustionFactorY > 0)
                    {
                        pokePowerN /= exhaustionFactorY;
                        continue;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            if (pokePowerN < distanceM)
            {
                Console.WriteLine(pokePowerN);
                Console.WriteLine(pokesCounter);
            }
        }
    }
}