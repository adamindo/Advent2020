using System;
using System.Collections.Generic;

namespace ColoredBags{
    internal class DataLoader{

        const string RULE_SEPARATOR = " contain ";
        internal List<Rule> Rules {get; private set;}
        internal DataLoader(string filePath){
            Rules = new List<Rule>();
            string line;

            System.IO.StreamReader file =
                new System.IO.StreamReader(filePath);
            while((line = file.ReadLine()) != null)
            {  
                if (line != string.Empty)
                {
                    var splittedLine = line.Split(RULE_SEPARATOR);
                    var rule = new Rule(splittedLine[0].Replace("bags", "").Trim());
                    var canContain = splittedLine[1].Replace("bags", "|").Replace("bag", "|").Replace(",", "").Replace(".", "").Split("|");
                    foreach(var bag in canContain)
                    {
                        if (bag == null || bag == "" || bag.Contains("no other"))
                            continue;
                        var splitted = bag.Trim().Split(" ", 2);
                        rule.CanContain.Add(splitted[1], int.Parse(splitted[0]));
                    }
                    Rules.Add(rule);
                }
            }
            
            file.Close();
        }
    }
}