using System;
using System.Collections.Generic;
using System.Linq;

namespace InfiniteLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            var code = new DataLoader("input.txt").Code;
            var alreadyReached = new List<LineOfCode>();
            var accumulator = 0;
            var currentLineIndex = 0;
            while (!alreadyReached.Contains(code[currentLineIndex])){
                var currentLine = code[currentLineIndex];
                alreadyReached.Add(currentLine);
                switch (currentLine.Command){
                    case Operation.ACC:
                        accumulator += currentLine.Argument;
                        currentLineIndex++;
                        Console.WriteLine(accumulator);
                        break;
                    case Operation.JMP:
                        currentLineIndex += currentLine.Argument;
                        break;
                    case Operation.NOP:
                        currentLineIndex++;
                        break;
                    default: throw new ArgumentException();
                }
            }
            Console.WriteLine("Part1: " + accumulator);

            var targetLine = code.Last();
            var propperTerminated = false;
            var adaptedLines = new List<LineOfCode>();
            while (!propperTerminated)
            {
                alreadyReached = new List<LineOfCode>();
                accumulator = 0;
                currentLineIndex = 0;
                var lineAdapted = false;
                while (!alreadyReached.Contains(code[currentLineIndex])){
                    var currentLine = code[currentLineIndex];
                    alreadyReached.Add(currentLine);
                    var currentLineCommand = currentLine.Command;
                    if (!lineAdapted && currentLineCommand != Operation.ACC && !adaptedLines.Contains(currentLine))
                    {
                        if (currentLineCommand == Operation.NOP)
                            currentLineCommand = Operation.JMP;
                        else if (currentLineCommand == Operation.JMP)
                            currentLineCommand = Operation.NOP;
                        else throw new ArgumentException();
                        lineAdapted = true;
                        adaptedLines.Add(currentLine);
                    }
                    switch (currentLineCommand){
                        case Operation.ACC:
                            accumulator += currentLine.Argument;
                            currentLineIndex++;
                            Console.WriteLine(accumulator);
                            break;
                        case Operation.JMP:
                            currentLineIndex += currentLine.Argument;
                            break;
                        case Operation.NOP:
                            currentLineIndex++;
                            break;
                        default: throw new ArgumentException();
                    }
                    if (currentLine.Equals(targetLine)){
                        propperTerminated = true;
                        break;
                    }
                }
            }
            Console.WriteLine("Part2: " + accumulator);
        }
    }
}
