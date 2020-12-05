using System;
using System.Collections.Generic;
using System.Linq;

namespace Password{
    internal class PasswordVerifier{
        private List<Tuple<int, int, char, string>> dataSet;
        internal PasswordVerifier(List<Tuple<int, int, char, string>> dataSet){
            this.dataSet = dataSet;
        }

        internal int CountValidPasswords1(){
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

        internal int CountValidPasswords2(){
            var counter = 0;
            foreach (var tuple in dataSet)
            {
                var password = tuple.Item4;
                var letter = tuple.Item3;
                bool position1 = password.ToCharArray()[tuple.Item1 - 1] == letter;
                bool position2 = password.ToCharArray()[tuple.Item2 - 1] == letter;
                if (position1 ^ position2)
                    counter++;
            }
            return counter;
        }
    }
}