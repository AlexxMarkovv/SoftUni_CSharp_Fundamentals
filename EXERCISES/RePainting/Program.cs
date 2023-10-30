using System;

namespace RePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            double nylon = double.Parse(Console.ReadLine());
            double paint = double.Parse(Console.ReadLine());
            double diluent = double.Parse(Console.ReadLine());
            double workHours = double.Parse(Console.ReadLine());

            double nylonPrice = (nylon + 2) * 1.50;
            double paintPrice = (paint * 14.50);
            double paintPriceBonus = paintPrice * 0.1;
            double diluentPrice = diluent * 5.00;
            double price = nylonPrice + paintPriceBonus + paintPrice + diluentPrice;
            double workerPrice = (price * 0.3) * workHours;

            Console.WriteLine(price + workerPrice);

                



        }
    }
}
