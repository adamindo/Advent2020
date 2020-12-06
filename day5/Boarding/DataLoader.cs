using System;
using System.Collections.Generic;

namespace Boarding
{
    internal class DataLoader{

        internal List<BoardingPass> Passes {get; private set;}

        internal DataLoader(string filePath){
            Passes = new List<BoardingPass>();
            string line;

            System.IO.StreamReader file =
                new System.IO.StreamReader(filePath);
            while((line = file.ReadLine()) != null)
            {  
                Passes.Add(new BoardingPass(line));
            } 
            
            file.Close();
        }
    }
}