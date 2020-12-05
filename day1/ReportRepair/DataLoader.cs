using System;
using System.Collections.Generic;

namespace ReportRepair
{
    class DataLoader
    {
        public List<int> Numbers;

        internal DataLoader(string filePath)
        {    
            Numbers = new List<int>();
            string line;

            System.IO.StreamReader file =
                new System.IO.StreamReader(filePath);  
            while((line = file.ReadLine()) != null)
            {  
                Numbers.Add(int.Parse(line));
            } 
            
            file.Close();
        }
    }
}
