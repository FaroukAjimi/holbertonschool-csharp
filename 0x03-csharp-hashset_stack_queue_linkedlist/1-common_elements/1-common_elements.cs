using System;
using System.Collections.Generic;

    class List
    {
        public static List<int> CommonElements(List<int> list1, List<int> list2)
        {
            List<int> l = new List<int>();
            foreach(var i in list1)
            {
                if(list2.Contains(i))
                {
                    l.Add(i);
                }
            }
            return(l);
        }
    }
