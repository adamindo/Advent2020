using System;

namespace Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            var loader = new DataLoader("input.txt");
            var analyzer = new GroupAnalyzer(loader.Groups);
            foreach(var group in loader.Groups)
                group.CombineAnswers();
            Console.WriteLine("Part1: " + analyzer.SumUpAllCombinedAnswerCounts());
            foreach(var group in loader.Groups)
                group.FilterOverlappingAnswers();
            Console.WriteLine("Part2: " + analyzer.SumUpAllOverlappingAnswerCounts());
        }
    }
}
