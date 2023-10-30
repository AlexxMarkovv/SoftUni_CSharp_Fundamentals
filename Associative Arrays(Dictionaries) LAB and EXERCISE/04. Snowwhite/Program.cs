using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Snowwhite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dwarfs = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Once upon a time")
                {
                    break;
                }
                    
                string[] cmndArrs = input.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);
                string name = cmndArrs[0];
                string hatColor = cmndArrs[1];
                int physics = int.Parse(cmndArrs[2]);
                string dwarfID = $"{name}:{hatColor}";

                if (!dwarfs.ContainsKey(dwarfID))
                {
                    dwarfs.Add(dwarfID, physics);
                }
                else
                {
                    dwarfs[dwarfID] = Math.Max(dwarfs[dwarfID], physics);
                }
            }

            var sortedDwarfs = dwarfs
                .OrderByDescending(x => x.Value)
                .ThenByDescending(curDwarf => dwarfs
                .Where(hatColor => hatColor.Key
                .Split(":")[1] == curDwarf.Key
                .Split(":")[1])
                .Count());

            foreach (var dwarf in sortedDwarfs)
            {
                string name = dwarf.Key.Split(":")[0];
                string hatColor = dwarf.Key.Split(":")[1];
                int physics = dwarf.Value;
                Console.WriteLine($"({hatColor}) {name} <-> {physics}");
            }
        }
    }
}