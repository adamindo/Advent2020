using System;
using System.Collections.Generic;

namespace Trees
{
    internal class CountTrees{

        private const char tree = '#';
        private char[][] map;

        internal CountTrees(char[][] map){
            this.map = map;
        }

        internal int Count(int horizontalStepSize, int verticalStepSize){
            var columnNumber = 0;
            var counter = 0;
            for (var rowNumber = verticalStepSize; rowNumber < map.Length; rowNumber += verticalStepSize)
            {
                var row = map[rowNumber];
                columnNumber += horizontalStepSize;
                columnNumber %= row.Length;
                if (row[columnNumber] == tree)
                    counter++;
            }
            return counter;
        }
    }
}