using System;
using System.Collections.Generic;

namespace Encrypted{
    internal class DataLoader{
        internal List<ulong> Data;
        internal DataLoader(string filePath){
            Data = new List<ulong>();
            System.IO.StreamReader file = new System.IO.StreamReader(filePath);
            string line;
            while((line = file.ReadLine()) != null)
            {  
                if (line != string.Empty)
                {
                    Data.Add(ulong.Parse(line));
                }
            }
            
            file.Close();
        }
    }
}