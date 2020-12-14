using System;

namespace InfiniteLoop{
    internal class LineOfCode{
        internal Operation Command {get; private set;}
        internal int Argument {get; private set;}
        internal LineOfCode(string text){
            var splittedLine = text.Split(" ");
            Argument = int.Parse(splittedLine[1]);
            if (splittedLine[0].Contains("acc"))
                Command = Operation.ACC;
            else if(splittedLine[0].Contains("jmp"))
                Command = Operation.JMP;
            else if(splittedLine[0].Contains("nop"))
                Command = Operation.NOP;
            else throw new ArgumentException();
        }
    }

    internal enum Operation{
        ACC,
        JMP,
        NOP
    }
}