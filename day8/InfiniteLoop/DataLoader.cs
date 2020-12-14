using System;
using System.IO;

namespace InfiniteLoop{
    internal class DataLoader {
        public LineOfCode[] Code {get; private set;}
        internal DataLoader(string filePath){
            string line;

            System.IO.StreamReader file =
                new System.IO.StreamReader(filePath);
            
            Code = new LineOfCode[File.ReadAllLines(filePath).Length];
            var counter = 0;
            while((line = file.ReadLine()) != null)
            {  
                if (line != string.Empty)
                {
                    Code[counter] = new LineOfCode(line);
                    counter++;
                }
            }
            
            file.Close();
        }
    }
}