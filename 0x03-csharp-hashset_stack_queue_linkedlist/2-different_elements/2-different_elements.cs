using System;
using System.Collections.Generic;


    class List
    {
        public static List<int> DifferentElements(List<int> list1, List<int> list2)
        {
            List<int> l = new List<int>();
            foreach(var i in list1)
            {
                if(list2.Contains(i))
                {
                    continue;
                }
                l.Add(i);
            }
            foreach(var i in list2)
            {
                if(list1.Contains(i))
                {
                    continue;
                }
                l.Add(i);
            }
            l.Sort();
            return(l);
        }
    }
