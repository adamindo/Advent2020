using System;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataLoader = new DataLoader("input.txt");
            var map = dataLoader.Map;
            var treeCounter = new CountTrees(map);
            Console.WriteLine("Part1: " + treeCounter.Count(3,1));
            var h1o1 = treeCounter.Count(1, 1);
            var h3o1 = treeCounter.Count(3, 1);
            var h5o1 = treeCounter.Count(5, 1);
            var h7o1 = treeCounter.Count(7, 1);
            var h1o2 = treeCounter.Count(1, 2);
            Console.WriteLine("Part2: " + h1o1*h3o1*h5o1*h7o1*h1o2);
        }
    }
}
