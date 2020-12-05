using System;
using System.Collections.Generic;

namespace ReportRepair
{
    internal class FindTriplet
    {

        private List<int> sortedList;
        private List<int> inverseSortedList;

        internal FindTriplet(List<int> sortedList)
        {   
            this.sortedList = sortedList;
            inverseSortedList = sortedList;
            inverseSortedList.Reverse();
        }

        internal Tuple<int, int, int> Find(int goal){

            foreach(var number in sortedList)
            {
                foreach(var partner1 in inverseSortedList)
                {
                    foreach(var partner2 in inverseSortedList)
                    {
                        if (number + partner1 + partner2 == goal)
                            return new Tuple<int, int, int>(number, partner1, partner2);
                        if (number + partner1 + partner2 > goal)
                            continue;
                    }
                    if (number + partner1 > goal)
                        continue;
                }
            }
            throw new ArgumentException();
        }
    }
}
