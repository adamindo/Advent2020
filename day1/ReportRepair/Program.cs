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
            var finder = new FindTuple(sortedNumbers);
            var pair = finder.Find(2020);
            Console.WriteLine(pair.Item1 * pair.Item2);
        }
    }
}
