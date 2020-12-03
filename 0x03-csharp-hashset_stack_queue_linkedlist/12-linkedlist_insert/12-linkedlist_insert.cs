using System;
using System.Collections.Generic;
    class LList
    {
        public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
        {
            List<int> l = new List<int>();
            int c = 0;
            myLList.AddFirst(n);
            foreach(var itm in myLList)
                l.Add(itm);
            c = myLList.Count;
            for(int i = 1; i <= c; i++)
                myLList.RemoveFirst();         
            l.Sort(); 
            foreach(var it in l)
            {
                myLList.AddLast(it);
            }
            return(myLList.First);
        }
    }

