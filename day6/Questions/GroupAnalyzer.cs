using System;
using System.Collections.Generic;

namespace Questions{
    internal class GroupAnalyzer{
        private List<Group> groups;
        internal GroupAnalyzer(List<Group> groups)
        {
            this.groups = groups;
        }

        internal int SumUpAllAnswerCounts(){
            var sum = 0;
            foreach(var group in groups)
            {
                sum += group.Answers.Count;
            }
            return sum;
        }
    }
}