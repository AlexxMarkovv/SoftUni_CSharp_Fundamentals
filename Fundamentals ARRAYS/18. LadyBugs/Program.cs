using System;
using System.Linq;

namespace _18._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            int[] field = new int[fieldSize];

            int[] initialIndexes = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();


            foreach (int index in initialIndexes)
            {
                if (index >= 0 && index < field.Length)
                {
                    field[index] = 1;
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArrgs = command
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                int ladyBugIndex = int.Parse(commandArrgs[0]);
                string direction = commandArrgs[1];
                int flyLength = int.Parse(commandArrgs[2]);

                if (ladyBugIndex < 0 || ladyBugIndex >= field.Length)
                {
                    continue;
                }

                if (field[ladyBugIndex] == 0)
                {
                    continue;
                }

                //Try to proceed move
                //Right -> ladybugIndex + flyLength
                //Left -> ladybugIndex - flyLength
                field[ladyBugIndex] = 0;  // ladybug fly AWAY!

                if (direction == "left")
                {
                    flyLength *= -1;
                }

                // 0 right 1 -> 0 + 1 = 1    !!!
                // 5 left 2 => 5 + (-2) = 3  !!!

                int nextIndex = ladyBugIndex + flyLength;
                while (nextIndex >= 0 && nextIndex < field.Length && field[nextIndex] == 1)
                {
                    nextIndex += flyLength;
                }

                if (nextIndex < 0 || nextIndex >= field.Length)
                {
                    //Outside of the field
                    continue;
                }

                // Or land ladybug on next valid index

                field[nextIndex] = 1;
            }

            Console.WriteLine(String.Join(" ", field));
        }
    }
}