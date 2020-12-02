using System;
using System.Collections.Generic;

    class Dictionary
    {
        public static string BestScore(Dictionary<string, int> myList)
        {
            if (myList.Count == 0)
                return("None");
            List<int> l = new List<int>();
            foreach(var item in myList)
                l.Add(item.Value);
            int i = l[0];
            foreach(var y in l)
            {
                if (y > i)
                    i = y;
            }
            string champ = "";
            foreach(var z in myList)
                {
                    if (z.Value == i)
                        champ = z.Key;
                }
            return(champ);
        }
    }
