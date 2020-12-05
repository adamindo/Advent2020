using System;
using System.Collections.Generic;

namespace ReportRepair
{
    class Program
    {

        static void Main(string[] args)
        {    
            var loader = new DataLoader("input.txt");
            var sortedNumbers = loader.Numbers;
            sortedNumbers.Sort();
            var pariFinder = new FindTuple(sortedNumbers);
            var pair = pariFinder.Find(2020);
            Console.WriteLine(pair.Item1 * pair.Item2);
            var tripletFinder = new FindTriplet(sortedNumbers);
            var triplet = tripletFinder.Find(2020);
            Console.WriteLine(triplet.Item1 * triplet.Item2 * triplet.Item3);
        }
    }
}
