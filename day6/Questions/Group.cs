using System;
using System.Collections.Generic;

namespace Questions{
    internal class Group{
        internal List<Person> Members {get; private set;}
        internal List<char> Answers {get; private set;}
        internal List<char> CombinedAnswers {get; private set;}
        internal List<char> OverlappingAnswers {get; private set;}
        internal Group(){
            Members = new List<Person>();
        }

        internal void CombineAnswers(){
            CombinedAnswers = new List<char>();
            foreach(var person in Members){
                foreach(var answer in person.Answers){
                    if (!CombinedAnswers.Contains(answer))
                    {
                        CombinedAnswers.Add(answer);
                    }
                }
            }
        }

        internal void FilterOverlappingAnswers(){
            if (CombinedAnswers == null)
                CombineAnswers();
            OverlappingAnswers = new List<char>();
            foreach(var answer in CombinedAnswers)
                OverlappingAnswers.Add(answer);
            foreach(var person in Members){
                foreach(var answer in CombinedAnswers){
                    if (!person.Answers.Contains(answer)){
                        OverlappingAnswers.Remove(answer);
                    }
                }
            }
        }
    }
}