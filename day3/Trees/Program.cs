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
            Console.WriteLine("Part1:" + treeCounter.Count(3,1));
        }
    }
}
