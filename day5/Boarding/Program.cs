using System;
using System.Linq;
using System.Collections.Generic;

namespace Boarding
{
    class Program
    {
        static void Main(string[] args)
        {
            var loader = new DataLoader("input.txt");
            var passes = loader.Passes;
            var maxID = passes.Max(pass => pass.Id);
            Console.WriteLine("Part1: " + maxID);
            var emptySeats = new List<int>();
            for (int i = 1; i < maxID; i++)
            {
                if (passes.Any(pass => pass.Id == i))
                    continue;
                if (!passes.Any(pass => pass.Id == i + 1))
                    continue;
                if (!passes.Any(pass => pass.Id == i - 1))
                    continue;
                emptySeats.Add(i);
            }
            Console.WriteLine($"Part2: Found {emptySeats.Count()} empty seats: {emptySeats.First()}");
        }
    }
}
