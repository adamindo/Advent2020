using System;
using System.Collections.Generic;

namespace Questions{
    internal class DataLoader{

        internal List<Group> Groups {get; private set;}
        internal DataLoader(string filePath){
            Groups = new List<Group>();
            string line;
            var group = new Group();

            System.IO.StreamReader file =
                new System.IO.StreamReader(filePath);
            while((line = file.ReadLine()) != null)
            {  
                if (line == string.Empty)
                {
                    Groups.Add(group);
                    group = new Group();
                }
                else{
                    group.Members.Add(new Person(line));
                }
            } 
            if (group.Members.Count > 0)
            {
                Groups.Add(group);
            }
            
            file.Close();
        }
    }
}