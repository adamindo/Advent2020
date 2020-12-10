using System;
using System.Collections.Generic;
using System.Linq;

namespace ColoredBags
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataLoader = new DataLoader("input.txt");
            var rules = dataLoader.Rules;
            var myBag = "shiny gold";
            var alreadySearched = new List<Rule>();
            var searchFor = new List<string>(){myBag};
            var counter = 0;
            while (searchFor.Count > 0){
                var tempSearchFor = new List<string>(searchFor);
                searchFor = new List<string>();
                foreach(var color in tempSearchFor)
                {
                    foreach(var rule in rules.Where(r => r.CanContain.ContainsKey(color)))
                    {
                        if (alreadySearched.Contains(rule))
                            continue;
                        alreadySearched.Add(rule);
                        searchFor.Add(rule.BagColor);
                    }
                }
                counter += searchFor.Count;
            }
            Console.WriteLine("Part1: " + counter);

            counter = 0;
            var toBeCounted = new List<Rule>(){rules.Single(r => r.BagColor.Equals(myBag))};
            while (toBeCounted.Count > 0){
                var rule = toBeCounted.First();
                foreach (var containedBag in rule.CanContain)
                {
                    var newRule = rules.Single(r => r.BagColor.Equals(containedBag.Key));
                    for(var i=0; i<containedBag.Value; i++){
                        toBeCounted.Add(newRule);
                        counter++;
                    }
                }
                toBeCounted.Remove(rule);
            }
            Console.WriteLine("Part2: " + counter);
        }
    }
}
