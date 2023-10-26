using System;

namespace _09._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagonsNum = int.Parse(Console.ReadLine());
            int[] people = new int[wagonsNum];
            int peopleSum = 0;

            for (int i = 0; i <= people.Length - 1; i++)
            {
                int peopleNum = int.Parse(Console.ReadLine());
                people[i] = peopleNum;
                peopleSum += people[i];
            }

            Console.WriteLine(string.Join(" ", people));

            //for (int i = 0; i < people.Length; i++)
            //{
            //    Console.Write(people[i] + " ");
            //}
            Console.Write(peopleSum);
        }
    }
}