using System;
using System.Collections.Generic;
using System.Linq;

namespace Encrypted
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataInput = new DataLoader("input.txt").Data;
            var preambleSize = 25;
            var queue = new Queue<ulong>(preambleSize);
            for (var i=0; i<preambleSize; i++){
                queue.Enqueue(dataInput[i]);
            }
            ulong error = 0;
            var position = preambleSize;
            while (error == 0){
                var newValue = dataInput[position];
                var combinationFound = false;
                foreach(var first in queue){
                    foreach(var second in queue){
                        if (first == second)
                            continue;
                        if (first + second == newValue)
                        {
                            combinationFound = true;
                            break;
                        }
                    }
                    if (combinationFound)
                        break;
                }
                if (!combinationFound)
                    error = newValue;
                queue.Dequeue();
                queue.Enqueue(newValue);
                position++;
            }
            Console.WriteLine("Part1: " + error);

            var inputCopy = new List<ulong>(dataInput);
            while (true){
                ulong sum = 0;
                var area = new List<ulong>();
                foreach(var number in inputCopy){
                    if (sum < error){
                        area.Add(number);
                        sum += number;
                    }
                    else
                        break;
                }
                if (sum > error){
                    inputCopy.Remove(inputCopy.First());
                    continue;
                }
                inputCopy = area;
                break;
            }

            Console.WriteLine("Part2: " + (inputCopy.Max() + inputCopy.Min()));
        }
    }
}
