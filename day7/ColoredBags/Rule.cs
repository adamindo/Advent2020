using System;
using System.Collections.Generic;

namespace ColoredBags{
    internal class Rule{
        internal string BagColor {get; private set;}
        internal Dictionary<string, int> CanContain {get; private set;}
        internal Rule (string bagColor)
        {
            BagColor = bagColor;
            CanContain = new Dictionary<string, int>();
        }
    }
}