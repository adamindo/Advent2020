using System;
using System.Collections.Generic;

namespace Questions{
    internal class Person{
        internal List<char> Answers {get; private set;}
        internal Person(string answers){
            Answers = new List<char>();
            foreach(var letter in answers.ToCharArray()){
                Answers.Add(letter);
            }
        }
    }
}