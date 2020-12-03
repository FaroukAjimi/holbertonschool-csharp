using System;
using System.Collections.Generic;

    class LList
    {
        public static void Delete(LinkedList<int> myLList, int index)
        {
            List<int> l = new List<int>();
            int c = 0;
            int c2 = 0;
            foreach(var itm in myLList)
             {
                if (c2 == index)
                {
                    c2++;
                    continue;
                }
                l.Add(itm);
                c2++;
             }
            c = myLList.Count;
            for(int i = 1; i <= c; i++)
                myLList.RemoveFirst();         
            foreach(var it in l)
            {
                myLList.AddLast(it);
            }
        }
    }

