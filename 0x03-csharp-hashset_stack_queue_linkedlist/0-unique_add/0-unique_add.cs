using System;

using System.Collections.Generic;
    class List
    {
        public static int Sum(List<int> myList)
        {
            int s = 0;
            List<int> l = new List<int>();
            foreach(var i in myList)
            {
                if(l.Contains(i))
                    continue;
                l.Add(i);
            }
            for(int c = 0; c < l.Count; c++)
            {
                s = s + l[c];
            }
            return(s);
        }
    }
