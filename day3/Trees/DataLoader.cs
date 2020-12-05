using System;
using System.Collections.Generic;

namespace Trees
{
    internal class DataLoader{

        internal char[][] Map {get; private set;}

        internal DataLoader(string filePath){
            var listOfLines = new List<char[]>();
            string line;

            System.IO.StreamReader file =
                new System.IO.StreamReader(filePath);
            while((line = file.ReadLine()) != null)
            {  
                listOfLines.Add(line.ToCharArray());
            } 
            
            file.Close();

            Map = listOfLines.ToArray();
        }
    }
}