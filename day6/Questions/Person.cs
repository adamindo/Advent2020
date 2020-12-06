using System;

namespace Questions{
    internal class Person{
        internal char[] Answers {get; private set;}
        internal Person(string answers) => this.Answers = answers.ToCharArray();
    }
}