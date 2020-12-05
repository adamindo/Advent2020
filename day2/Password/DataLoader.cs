using System;
using System.Collections.Generic;

namespace Password
{
    internal class DataLoader{

        internal List<Tuple<int, int, char, string>> DataList {get; private set;}

        internal DataLoader(string filePath){
            DataList = new List<Tuple<int, int, char, string>>();
            string line;

            System.IO.StreamReader file =
                new System.IO.StreamReader(filePath);  
            while((line = file.ReadLine()) != null)
            {  
                var splittedLine = line.Split(' ');
                var min = int.Parse(splittedLine[0].Split('-')[0]);
                var max = int.Parse(splittedLine[0].Split('-')[1]);
                var letter = splittedLine[1].ToCharArray()[0];
                var password = splittedLine[2];
                DataList.Add(new Tuple<int, int, char, string>(min, max, letter, password));
            } 
            
            file.Close();
        }
    }
}