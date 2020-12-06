using System;
using System.Collections.Generic;

namespace Questions{
    internal class Group{
        internal List<Person> Members {get; private set;}
        internal List<char> Answers {get; private set;}
        internal Group(){
            Members = new List<Person>();
        }

        internal void CombineAnswers(){
            Answers = new List<char>();
            foreach(var person in Members){
                foreach(var answer in person.Answers){
                    if (!Answers.Contains(answer))
                    {
                        Answers.Add(answer);
                    }
                }
            }
        }
    }
}