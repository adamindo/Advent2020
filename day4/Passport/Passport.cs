using System;

namespace Passport{
    internal class Passport{

    /// <summary> Birth Year </summary>
    public string byr {get; private set;}
    /// <summary> Issue Year </summary>
    public string iyr {get; private set;}
    /// <summary> Expiration Year </summary>
    public string eyr {get; private set;}
    /// <summary> Height </summary>
    public string hgt {get; private set;}
    /// <summary> Hair Color </summary>
    public string gcl {get; private set;}
    /// <summary> Eye Color </summary>
    public string ecl {get; private set;}
    /// <summary> Passport ID </summary>
    public string pid {get; private set;}
    /// <summary> Country ID </summary>
    public string cid {get; private set;}

        internal Passport(string input){
            var lined = input.Replace(' ', '\n');
            var split = lined.Split('\n');
            foreach(var line in split){
                var splitLine = line.Split(':');
                if (splitLine.Length < 2)
                    continue;
                var propertyName = splitLine[0];
                var value = splitLine[1];
                this.GetType().GetProperty(propertyName)?.SetValue(this, value);
            }
        }

        public bool IsValid(){
            if (byr == null)
            {
                return false;
            }
            if (iyr == null)
            {
                return false;
            }
            if (eyr == null)
            {
                return false;
            }
            if (hgt == null)
            {
                return false;
            }
            if (ecl == null)
            {
                return false;
            }
            if (pid == null)
            {
                return false;
            }
            return true;
        }
    }
}