using System;

namespace Boarding{
    internal class BoardingPass{

        private const int NumberOfRows = 128;
        private const int NumberOfColumns = 8;

        internal int Row {get; private set;}
        internal int Column {get; private set;}
        internal int Id {get; private set;}
        internal BoardingPass(string code){
            var maxRow = NumberOfRows - 1;
            var minRow = 0;
            var row = 0;
            var maxColumn = NumberOfColumns - 1;
            var minColumn = 0;
            var column = 0;
            foreach(var letter in code.ToCharArray())
            {
                switch (letter)
                {
                    case 'F':
                        maxRow = Convert.ToInt32(Math.Floor((maxRow - (maxRow - minRow) / 2.0)));
                        row = maxRow;
                        break;
                    case 'B':
                        minRow = Convert.ToInt32(Math.Ceiling((minRow + (maxRow - minRow) / 2.0)));
                        row = minRow;
                        break;
                    case 'L':
                        maxColumn = Convert.ToInt32(Math.Floor((maxColumn - (maxColumn - minColumn) / 2.0)));
                        column = maxColumn;
                        break;
                    case 'R':
                        minColumn = Convert.ToInt32(Math.Ceiling((minColumn + (maxColumn - minColumn) / 2.0)));
                        column = minColumn;
                        break;
                    default:
                        throw new ArgumentException();
                }
            }
            Column = column;
            Row = row;
            Id = Row*8 + Column;
        }
    }
}