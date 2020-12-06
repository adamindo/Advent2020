using System;
using System.Collections.Generic;

namespace Questions{
    internal class GroupAnalyzer{
        private List<Group> groups;
        internal GroupAnalyzer(List<Group> groups)
        {
            this.groups = groups;
        }

        internal int SumUpAllCombinedAnswerCounts(){
            var sum = 0;
            foreach(var group in groups)
            {
                sum += group.CombinedAnswers.Count;
            }
            return sum;
        }

        internal int SumUpAllOverlappingAnswerCounts(){
            var sum = 0;
            foreach(var group in groups)
            {
                sum += group.OverlappingAnswers.Count;
            }
            return sum;
        }
    }
}