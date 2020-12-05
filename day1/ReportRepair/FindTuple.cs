using System;
using System.Collections.Generic;

namespace ReportRepair
{
    internal class FindTuple
    {

        private List<int> sortedList;
        private List<int> inverseSortedList;

        internal FindTuple(List<int> sortedList)
        {   
            this.sortedList = sortedList;
            inverseSortedList = sortedList;
            inverseSortedList.Reverse();
        }

        internal Tuple<int, int> Find(int goal){

            foreach(var number in sortedList)
            {
                foreach(var partner in inverseSortedList)
                {
                    if (number + partner == goal)
                        return new Tuple<int, int>(number, partner);
                    if (number + partner > goal)
                        continue;
                }
            }
            throw new ArgumentException();
        }
    }
}
