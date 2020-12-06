using System;
using System.Linq;

namespace Boarding
{
    class Program
    {
        static void Main(string[] args)
        {
            var loader = new DataLoader("input.txt");
            var passes = loader.Passes;
            Console.WriteLine("Part1: " + passes.Max(pass => pass.Id));
        }
    }
}
