using System;

namespace Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            var loader = new DataLoader("input.txt");
            foreach(var group in loader.Groups)
                group.CombineAnswers();
            var analyzer = new GroupAnalyzer(loader.Groups);
            Console.WriteLine("Part1: " + analyzer.SumUpAllAnswerCounts());
        }
    }
}
