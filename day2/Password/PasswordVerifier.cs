using System;
using System.Collections.Generic;
using System.Linq;

namespace Password{
    internal class PasswordVerifier{
        private List<Tuple<int, int, char, string>> dataSet;
        internal PasswordVerifier(List<Tuple<int, int, char, string>> dataSet){
            this.dataSet = dataSet;
        }

        internal int CountValidPasswords(){
            var counter = 0;
            foreach (var tuple in dataSet)
            {
                var password = tuple.Item4;
                var occurances = password.Count(ch => ch == tuple.Item3);
                if (tuple.Item1 <= occurances && occurances <= tuple.Item2)
                    counter++;
            }
            return counter;
        }
    }
}