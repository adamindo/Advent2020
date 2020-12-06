using System;
using System.Collections.Generic;

namespace Passport{
    internal class DataLoader{

        public List<Passport> Passports;
        internal DataLoader(string filePath)
        {
            Passports = new List<Passport>();
            string line;
            string passportString = string.Empty;

            System.IO.StreamReader file =
                new System.IO.StreamReader(filePath);
            while((line = file.ReadLine()) != null)
            {
                if (line.Equals(string.Empty))
                {
                    if (passportString != string.Empty)
                    {
                        Passports.Add(new Passport(passportString));
                        passportString = string.Empty;
                    }
                }
                else{
                    passportString = string.Concat(passportString, " ", line);
                }
            } 
            
            if (passportString != string.Empty)
            {
                Passports.Add(new Passport(passportString));
            }

            file.Close();

        }
    }
}