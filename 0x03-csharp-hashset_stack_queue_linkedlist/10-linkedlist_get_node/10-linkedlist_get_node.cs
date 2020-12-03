using System;
using System.Collections.Generic;
    class LList
    {
        public static int GetNode(LinkedList<int> myLList, int n)
        {
            int  i = 0;
            foreach(var itm in myLList)
            {
                if (i == n)
                    return(itm);
                i++;
            }
            return(0);
        }
    }
