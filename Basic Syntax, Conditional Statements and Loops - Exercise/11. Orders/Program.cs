using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int orders = int.Parse(Console.ReadLine());
            double pricePerOrder = 0;
            double totalSum = 0;
            for (int i = 0; i < orders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsules = int.Parse(Console.ReadLine());

                pricePerOrder = ((days * capsules) * pricePerCapsule);
                Console.WriteLine($"The price for the coffee is: ${pricePerOrder:f2}");
                totalSum += pricePerOrder;
            }

            Console.WriteLine($"Total: ${totalSum:f2}");
        }
    }
}
